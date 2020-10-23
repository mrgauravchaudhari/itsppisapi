using System.Threading.Tasks;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace itsppisapi.Data {
    public class PAS003Repository {
        private readonly string _connectionString;
        public PAS003Repository (IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString ("DBConnection");
        }

        private PAS003Model MapToValue (SqlDataReader reader) {
            return new PAS003Model () {
                MINMONTH = reader["MINMONTH"].ToString (),
                    MINYEAR = (decimal) reader["MINYEAR"],
                    MAXMONTH = reader["MAXMONTH"].ToString (),
                    MAXYEAR = (decimal) reader["MAXYEAR"],
                    A1_YEAR = (decimal) reader["A1_YEAR"],
                    A1_MONTH = reader["A1_MONTH"].ToString (),
                    A1_STREAM_DAYS = (decimal) reader["A1_STREAM_DAYS"],
                    A1_GAS_ALLOC = (decimal) reader["A1_GAS_ALLOC"],
                    A1_FRONT_END_LOAD = (decimal) reader["A1_FRONT_END_LOAD"],
                    A1_PGRU_PROD = (decimal) reader["A1_PGRU_PROD"],
                    A1_SURPLUS_GAS_LOSS = (decimal) reader["A1_SURPLUS_GAS_LOSS"],
                    A1_AMM_PROD = (decimal) reader["A1_AMM_PROD"],
                    A1_UREA_PROD = (decimal) reader["A1_UREA_PROD"],
                    A1_AMM_SD_GAS = (decimal) reader["A1_AMM_SD_GAS"],
                    A1_AMM_PROD_GAS = (decimal) reader["A1_AMM_PROD_GAS"],
                    A1_AMM_TOTAL_GAS = (decimal) reader["A1_AMM_TOTAL_GAS"],
                    A1_AMM_NAPHTHA = (decimal) reader["A1_AMM_NAPHTHA"],
                    A1_SPG_SD_GAS = (decimal) reader["A1_SPG_SD_GAS"],
                    A1_SPG_PROD_GAS = (decimal) reader["A1_SPG_PROD_GAS"],
                    A1_SPG_TOTAL_GAS = (decimal) reader["A1_SPG_TOTAL_GAS"],
                    A1_SPG_NAPHTHA = (decimal) reader["A1_SPG_NAPHTHA"],
                    A1_SP_CONSP_AMM_NG = (decimal) reader["A1_SP_CONSP_AMM_NG"],
                    A1_SP_CONSP_AMM_NAP = (decimal) reader["A1_SP_CONSP_AMM_NAP"],
                    A1_SP_CONSP_EQ_FUEL_AMM = (decimal) reader["A1_SP_CONSP_EQ_FUEL_AMM"],
                    A1_SP_CONSP_SPG_GAS = (decimal) reader["A1_SP_CONSP_SPG_GAS"],
                    A1_SP_CONSP_SPG_NAP = (decimal) reader["A1_SP_CONSP_SPG_NAP"],
                    A1_SP_CONSP_EQ_FUEL_SPG = (decimal) reader["A1_SP_CONSP_EQ_FUEL_SPG"],
                    A1_SP_CONSP_UREA = (decimal) reader["A1_SP_CONSP_UREA"],
                    A1_NG_CONSP = (decimal) reader["A1_NG_CONSP"],
                    A1_NAP_CONSP = (decimal) reader["A1_NAP_CONSP"],
                    A1_NG_CV = (decimal) reader["A1_NG_CV"],
                    A1_NAP_CV = (decimal) reader["A1_NAP_CV"],
                    A1_REMARKS = reader["A1_REMARKS"].ToString (),
                    A1_DATE_MOD = reader["A1_DATE_MOD"].ToString (),
                    A1_USER_ID = (decimal) reader["A1_USER_ID"],
                    USER_NAME = reader["USER_NAME"].ToString (),
                    A1_UNIT_ID = reader["A1_UNIT_ID"].ToString (),
            };
        }

        public async Task<PAS003Model> putData (string MONTH, decimal YEAR) {
            using (SqlConnection sql = new SqlConnection (_connectionString)) {
                using (SqlCommand cmd = new SqlCommand ("PPIS.PPU_P_AM1_GET_PPT_AM_PRODUCTION_PLAN", sql)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add (new SqlParameter ("@IN_MONTH", MONTH));
                    cmd.Parameters.Add (new SqlParameter ("@IN_YEAR", YEAR));
                    PAS003Model response = null;
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

        public async Task saveData (PAS003SaveDto value) {
            using (SqlConnection sql = new SqlConnection (_connectionString)) {
                using (SqlCommand cmd = new SqlCommand ("PPIS.PPU_P_AM1_SAVE_PPT_AM_PRODUCTION_PLAN", sql)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_UNIT_ID", value.A1_UNIT_ID));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_USER_ID", value.A1_USER_ID));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_YEAR", value.A1_YEAR));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_MONTH", value.A1_MONTH));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_STREAM_DAYS", value.A1_STREAM_DAYS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_GAS_ALLOC", value.A1_GAS_ALLOC));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_NG_CV", value.A1_NG_CV));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_NAP_CV", value.A1_NAP_CV));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_FRONT_END_LOAD", value.A1_FRONT_END_LOAD));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_PGRU_PROD", value.A1_PGRU_PROD));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SURPLUS_GAS_PROD", value.A1_SURPLUS_GAS_PROD));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SURPLUS_GAS_LOSS", value.A1_SURPLUS_GAS_LOSS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_AMM_PROD", value.A1_AMM_PROD));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_UREA_PROD", value.A1_UREA_PROD));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_AMM_SD_GAS", value.A1_AMM_SD_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_AMM_PROD_GAS", value.A1_AMM_PROD_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_AMM_TOTAL_GAS", value.A1_AMM_TOTAL_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_AMM_NAPHTHA", value.A1_AMM_NAPHTHA));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SPG_SD_GAS", value.A1_SPG_SD_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SPG_PROD_GAS", value.A1_SPG_PROD_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SPG_TOTAL_GAS", value.A1_SPG_TOTAL_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SPG_NAPHTHA", value.A1_SPG_NAPHTHA));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_EQ_FUEL_SPG", value.A1_SP_CONSP_EQ_FUEL_SPG));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_EQ_FUEL_AMM", value.A1_SP_CONSP_EQ_FUEL_AMM));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_AMM_NG", value.A1_SP_CONSP_AMM_NG));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_AMM_NAP", value.A1_SP_CONSP_AMM_NAP));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_SPG_GAS", value.A1_SP_CONSP_SPG_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_SPG_NAP", value.A1_SP_CONSP_SPG_NAP));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SP_CONSP_UREA", value.A1_SP_CONSP_UREA));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_NG_CONSP", value.A1_NG_CONSP));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_NAP_CONSP", value.A1_NAP_CONSP));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_AMM_UNPROD_GAS", value.A1_AMM_UNPROD_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_SPG_UNPROD_GAS", value.A1_SPG_UNPROD_GAS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_A1_REMARKS", value.A1_REMARKS));
                    await sql.OpenAsync ();
                    await cmd.ExecuteNonQueryAsync ();
                    return;
                }
            }
        }
    }
}