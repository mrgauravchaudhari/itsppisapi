using System.Threading.Tasks;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace itsppisapi.Data {
    public class PUS204Repository {
        private readonly string _connectionString;
        public PUS204Repository (IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString ("DBConnection");
        }

        private PUS204Model MapToValue (SqlDataReader reader) {
            return new PUS204Model () {
                MINDT = reader["MINDT"].ToString (),
                    MAXDT = reader["MAXDT"].ToString (),
                    U2_TRANS_DATE = reader["U2_TRANS_DATE"].ToString (),
                    U2_TRAIN_A_FEEDER1_INT = (decimal) reader["U2_TRAIN_A_FEEDER1_INT"],
                    U2_TRAIN_A_FEEDER1_INT_DIFF = (decimal) reader["U2_TRAIN_A_FEEDER1_INT_DIFF"],
                    U2_TRAIN_A_FEEDER2_INT = (decimal) reader["U2_TRAIN_A_FEEDER2_INT"],
                    U2_TRAIN_A_FEEDER2_INT_DIFF = (decimal) reader["U2_TRAIN_A_FEEDER2_INT_DIFF"],
                    U2_TRAIN_B_FEEDER1_INT = (decimal) reader["U2_TRAIN_B_FEEDER1_INT"],
                    U2_TRAIN_B_FEEDER1_INT_DIFF = (decimal) reader["U2_TRAIN_B_FEEDER1_INT_DIFF"],
                    U2_TRAIN_B_FEEDER2_INT = (decimal) reader["U2_TRAIN_B_FEEDER2_INT"],
                    U2_TRAIN_B_FEEDER2_INT_DIFF = (decimal) reader["U2_TRAIN_B_FEEDER2_INT_DIFF"],
                    U2_PLANT_CONSP_GROSS = (decimal) reader["U2_PLANT_CONSP_GROSS"],
                    U2_LIGHT_TRANSFMR_INT = (decimal) reader["U2_LIGHT_TRANSFMR_INT"],
                    U2_LIGHT_TRANSFMR_INT_DIFF = (decimal) reader["U2_LIGHT_TRANSFMR_INT_DIFF"],
                    U2_PDB_INT = (decimal) reader["U2_PDB_INT"],
                    U2_PDB_INT_DIFF = (decimal) reader["U2_PDB_INT_DIFF"],
                    U2_NON_PLANT_CONSP = (decimal) reader["U2_NON_PLANT_CONSP"],
                    U2_NET_CONSP = (decimal) reader["U2_NET_CONSP"],
                    U2_REMARKS = reader["U2_REMARKS"].ToString (),
                    TXT_FDR1_CONSP = (decimal) reader["TXT_FDR1_CONSP"],
                    TXT_FDR2_CONSP = (decimal) reader["TXT_FDR2_CONSP"],
                    PARM_AM_GROSS = (decimal) reader["PARM_AM_GROSS"],
                    TXT_LINE_TRANS_LOSS = (decimal) reader["TXT_LINE_TRANS_LOSS"],
                    TXT_TOT_FDR = (decimal) reader["TXT_TOT_FDR"],
                    TXT_TRANS_LOSS = reader["TXT_TRANS_LOSS"].ToString (),
                    DATE_MOD = reader["U2_DATE_MOD"].ToString (),
                    USER_NAME = reader["USER_NAME"].ToString (),

                    // PRV
                    PRV_U2_TRANS_DATE = reader["PRV_U2_TRANS_DATE"].ToString (),
                    PRV_U2_TRAIN_A_FEEDER1_INT = (decimal) reader["PRV_U2_TRAIN_A_FEEDER1_INT"],
                    PRV_U2_TRAIN_A_FEEDER1_INT_DIFF = (decimal) reader["PRV_U2_TRAIN_A_FEEDER1_INT_DIFF"],
                    PRV_U2_TRAIN_A_FEEDER2_INT = (decimal) reader["PRV_U2_TRAIN_A_FEEDER2_INT"],
                    PRV_U2_TRAIN_A_FEEDER2_INT_DIFF = (decimal) reader["PRV_U2_TRAIN_A_FEEDER2_INT_DIFF"],
                    PRV_U2_TRAIN_B_FEEDER1_INT = (decimal) reader["PRV_U2_TRAIN_B_FEEDER1_INT"],
                    PRV_U2_TRAIN_B_FEEDER1_INT_DIFF = (decimal) reader["PRV_U2_TRAIN_B_FEEDER1_INT_DIFF"],
                    PRV_U2_TRAIN_B_FEEDER2_INT = (decimal) reader["PRV_U2_TRAIN_B_FEEDER2_INT"],
                    PRV_U2_TRAIN_B_FEEDER2_INT_DIFF = (decimal) reader["PRV_U2_TRAIN_B_FEEDER2_INT_DIFF"],
                    PRV_U2_PLANT_CONSP_GROSS = (decimal) reader["PRV_U2_PLANT_CONSP_GROSS"],
                    PRV_U2_LIGHT_TRANSFMR_INT = (decimal) reader["PRV_U2_LIGHT_TRANSFMR_INT"],
                    PRV_U2_LIGHT_TRANSFMR_INT_DIFF = (decimal) reader["PRV_U2_LIGHT_TRANSFMR_INT_DIFF"],
                    PRV_U2_PDB_INT = (decimal) reader["PRV_U2_PDB_INT"],
                    PRV_U2_PDB_INT_DIFF = (decimal) reader["PRV_U2_PDB_INT_DIFF"],
                    PRV_U2_NON_PLANT_CONSP = (decimal) reader["PRV_U2_NON_PLANT_CONSP"],
                    PRV_U2_NET_CONSP = (decimal) reader["PRV_U2_NET_CONSP"],
                    PRV_U2_REMARKS = reader["PRV_U2_REMARKS"].ToString ()
            };
        }

        public async Task<PUS204Model> putData (string IN_DATE, char IN_BTN) {
            using (SqlConnection sql = new SqlConnection (_connectionString)) {
                using (SqlCommand cmd = new SqlCommand ("PPIS.PPU_P_UR2_GET_PPT_UR2_ELECT_DETAILS", sql)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add (new SqlParameter ("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add (new SqlParameter ("@IN_BTN", IN_BTN));
                    PUS204Model response = null;
                    await sql.OpenAsync ();
                    using (var reader = await cmd.ExecuteReaderAsync ()) {
                        while (await reader.ReadAsync ()) {
                            response = MapToValue (reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData (PUS204Dto value) {
            using (SqlConnection sql = new SqlConnection (_connectionString)) {
                using (SqlCommand cmd = new SqlCommand ("PPIS.PPU_P_UR2_SAVE_PPT_UR2_ELECT_DETAILS", sql)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRANS_DATE", value.U2_TRANS_DATE));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_DMY_FLG", value.U2_DMY_FLG));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_USER_ID", value.U2_USER_ID));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_FREEZE_FLG", value.U2_FREEZE_FLG));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_A_FEEDER1_INT", value.U2_TRAIN_A_FEEDER1_INT));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_A_FEEDER1_INT_DIFF", value.U2_TRAIN_A_FEEDER1_INT_DIFF));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_A_FEEDER2_INT", value.U2_TRAIN_A_FEEDER2_INT));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_A_FEEDER2_INT_DIFF", value.U2_TRAIN_A_FEEDER2_INT_DIFF));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_B_FEEDER1_INT", value.U2_TRAIN_B_FEEDER1_INT));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_B_FEEDER1_INT_DIFF", value.U2_TRAIN_B_FEEDER1_INT_DIFF));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_B_FEEDER2_INT", value.U2_TRAIN_B_FEEDER2_INT));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_TRAIN_B_FEEDER2_INT_DIFF", value.U2_TRAIN_B_FEEDER2_INT_DIFF));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_PLANT_CONSP_GROSS", value.U2_PLANT_CONSP_GROSS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_LIGHT_TRANSFMR_INT", value.U2_LIGHT_TRANSFMR_INT));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_LIGHT_TRANSFMR_INT_DIFF", value.U2_LIGHT_TRANSFMR_INT_DIFF));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_PDB_INT", value.U2_PDB_INT));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_PDB_INT_DIFF", value.U2_PDB_INT_DIFF));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_NON_PLANT_CONSP", value.U2_NON_PLANT_CONSP));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_NET_CONSP", value.U2_NET_CONSP));
                    cmd.Parameters.Add (new SqlParameter ("@IN_U2_REMARKS", value.U2_REMARKS));
                    await sql.OpenAsync ();
                    await cmd.ExecuteNonQueryAsync ();
                    return;
                }
            }
        }
    }
}