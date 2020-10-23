using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PAS205Repository
    {
        private readonly string _connectionString;
        public PAS205Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS205Model MapToValue(SqlDataReader reader)
        {
            return new PAS205Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_NAP_TFR_TANK = reader["A2_NAP_TFR_TANK"].ToString(),
                A2_TOT_NAP_BULK_STOCK = (decimal)reader["A2_TOT_NAP_BULK_STOCK"],
                A2_BAL_NAP_TFRT_DAYTANK = (decimal)reader["A2_BAL_NAP_TFRT_DAYTANK"],
                A2_NAP_TFRT_DAYTANK_INT = (decimal)reader["A2_NAP_TFRT_DAYTANK_INT"],
                A2_NAP_TFRT_DAYTANK_INT_DIFF = (decimal)reader["A2_NAP_TFRT_DAYTANK_INT_DIFF"],
                A2_NAP_TFRT_DAYTANK = (decimal)reader["A2_NAP_TFRT_DAYTANK"],
                A2_NAP_TFRT_DAYTANK_MT_INT = (decimal)reader["A2_NAP_TFRT_DAYTANK_MT_INT"],
                A2_NAP_TFRT_DAYTANK_MT_INT_DIFF = (decimal)reader["A2_NAP_TFRT_DAYTANK_MT_INT_DIFF"],
                A2_NAP_TFRT_DAYTANK_MT = (decimal)reader["A2_NAP_TFRT_DAYTANK_MT"],
                A2_SNAP_TFRT_RNDT = (decimal)reader["A2_SNAP_TFRT_RNDT"],
                A2_NAP_OPR_TEMP = (decimal)reader["A2_NAP_OPR_TEMP"],
                A2_DAYTANK_LEVEL = (decimal)reader["A2_DAYTANK_LEVEL"],
                A2_DAYTANK_STOCK = (decimal)reader["A2_DAYTANK_STOCK"],
                TXT_DENSITY = (decimal)reader["TXT_DENSITY"],
                TXT_TANK2_STOCK = (decimal)reader["TXT_TANK2_STOCK"],
                TXT_TANK3_STOCK = (decimal)reader["TXT_TANK3_STOCK"],
                TXT_TANK1_STOCK = (decimal)reader["TXT_TANK1_STOCK"],
                TXT_NAP_RCPT_GP1 = (decimal)reader["TXT_NAP_RCPT_GP1"],
                TXT_NAP_TFR_GP1 = (decimal)reader["TXT_NAP_TFR_GP1"],
                TXT_RCPT_IOC = (decimal)reader["TXT_RCPT_IOC"],
                TXT_TOT_NAP_STOCK = (decimal)reader["TXT_TOT_NAP_STOCK"],
                TXT_DENSITY_CONSP = (decimal)reader["TXT_DENSITY_CONSP"],
                TXT_SNDT_DENSITY = (decimal)reader["TXT_SNDT_DENSITY"],
                TXT_SNT_LEVEL = (decimal)reader["TXT_SNT_LEVEL"],
                TXT_SNT_DENSITY = (decimal)reader["TXT_SNT_DENSITY"],
                TXT_SNT_STOCK = (decimal)reader["TXT_SNT_STOCK"],
                TXT_HDS_LOSS = (decimal)reader["TXT_HDS_LOSS"],
                TXT_SN_PROD = (decimal)reader["TXT_SN_PROD"],
                PARM_OU_SNT_OP_STK = (decimal)reader["PARM_OU_SNT_OP_STK"],
                PARM_SNDT_OP_STK = (decimal)reader["PARM_SNDT_OP_STK"],
                A2_TOT_NAP_CONSP_GP2 = (decimal)reader["A2_TOT_NAP_CONSP_GP2"],
                A2_NAP_HYD_FURN_INT = (decimal)reader["A2_NAP_HYD_FURN_INT"],
                A2_NAP_HYD_FURN_INT_DIFF = (decimal)reader["A2_NAP_HYD_FURN_INT_DIFF"],
                A2_NAP_CONSP_HYD_FURN = (decimal)reader["A2_NAP_CONSP_HYD_FURN"],
                A2_NAP_DESUL_FURN_INT = (decimal)reader["A2_NAP_DESUL_FURN_INT"],
                A2_NAP_DESUL_FURN_INT_DIFF = (decimal)reader["A2_NAP_DESUL_FURN_INT_DIFF"],
                A2_NAP_CONSP_DESUL_FURN = (decimal)reader["A2_NAP_CONSP_DESUL_FURN"],
                A2_NAP_TUNNEL_BURNER_INT = (decimal)reader["A2_NAP_TUNNEL_BURNER_INT"],
                A2_NAP_TUNNEL_BURNER_INT_DIFF = (decimal)reader["A2_NAP_TUNNEL_BURNER_INT_DIFF"],
                A2_NAP_CONSP_TUNNEL_BURNER = (decimal)reader["A2_NAP_CONSP_TUNNEL_BURNER"],
                A2_NAP_ARCH_BURNER_INT = (decimal)reader["A2_NAP_ARCH_BURNER_INT"],
                A2_NAP_ARCH_BURNER_INT_DIFF = (decimal)reader["A2_NAP_ARCH_BURNER_INT_DIFF"],
                A2_NAP_CONSP_ARCH_BURNER = (decimal)reader["A2_NAP_CONSP_ARCH_BURNER"],
                A2_NAP_SHEATER_BURNER_INT = (decimal)reader["A2_NAP_SHEATER_BURNER_INT"],
                A2_NAP_SHEATER_BURNER_INT_DIFF = (decimal)reader["A2_NAP_SHEATER_BURNER_INT_DIFF"],
                A2_NAP_CONSP_SHEATER_BURNER = (decimal)reader["A2_NAP_CONSP_SHEATER_BURNER"],
                A2_TOT_FUELNAP_TO_AMM2 = (decimal)reader["A2_TOT_FUELNAP_TO_AMM2"],
                A2_NAP_AB_INT = (decimal)reader["A2_NAP_AB_INT"],
                A2_NAP_AB_INT_DIFF = (decimal)reader["A2_NAP_AB_INT_DIFF"],
                A2_NAP_CONSP_AB = (decimal)reader["A2_NAP_CONSP_AB"],
                A2_NAP_HDS_INT = (decimal)reader["A2_NAP_HDS_INT"],
                A2_NAP_HDS_INT_DIFF = (decimal)reader["A2_NAP_HDS_INT_DIFF"],
                A2_NAP_CONSP_HDS = (decimal)reader["A2_NAP_CONSP_HDS"],
                A2_BAL_NAP_CONSP_HDS = (decimal)reader["A2_BAL_NAP_CONSP_HDS"],
                A2_SNDT_LEVEL = (decimal)reader["A2_SNDT_LEVEL"],
                A2_SNDT_STOCK = (decimal)reader["A2_SNDT_STOCK"],
                A2_SNAP_PROD_INT = (decimal)reader["A2_SNAP_PROD_INT"],
                A2_SNAP_PROD_INT_DIFF = (decimal)reader["A2_SNAP_PROD_INT_DIFF"],
                A2_SNAP_PROD = (decimal)reader["A2_SNAP_PROD"],
                A2_SNAP_PREF_INT = (decimal)reader["A2_SNAP_PREF_INT"],
                A2_SNAP_PREF_INT_DIFF = (decimal)reader["A2_SNAP_PREF_INT_DIFF"],
                A2_SNAP_CONSP_PREF = (decimal)reader["A2_SNAP_CONSP_PREF"],
                A2_BAL_SNAP_CONSP_PREF = (decimal)reader["A2_BAL_SNAP_CONSP_PREF"],
                A2_REMARKS = reader["A2_REMARKS"].ToString(),
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (decimal)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_A2_TRANS_DATE = reader["PRV_A2_TRANS_DATE"].ToString(),
                PRV_A2_NAP_TFR_TANK = reader["PRV_A2_NAP_TFR_TANK"].ToString(),
                PRV_A2_TOT_NAP_BULK_STOCK = (decimal)reader["PRV_A2_TOT_NAP_BULK_STOCK"],
                PRV_A2_BAL_NAP_TFRT_DAYTANK = (decimal)reader["PRV_A2_BAL_NAP_TFRT_DAYTANK"],
                PRV_A2_NAP_TFRT_DAYTANK_INT = (decimal)reader["PRV_A2_NAP_TFRT_DAYTANK_INT"],
                PRV_A2_NAP_TFRT_DAYTANK_INT_DIFF = (decimal)reader["PRV_A2_NAP_TFRT_DAYTANK_INT_DIFF"],
                PRV_A2_NAP_TFRT_DAYTANK = (decimal)reader["PRV_A2_NAP_TFRT_DAYTANK"],
                PRV_A2_NAP_TFRT_DAYTANK_MT_INT = (decimal)reader["PRV_A2_NAP_TFRT_DAYTANK_MT_INT"],
                PRV_A2_NAP_TFRT_DAYTANK_MT_INT_DIFF = (decimal)reader["PRV_A2_NAP_TFRT_DAYTANK_MT_INT_DIFF"],
                PRV_A2_NAP_TFRT_DAYTANK_MT = (decimal)reader["PRV_A2_NAP_TFRT_DAYTANK_MT"],
                PRV_A2_SNAP_TFRT_RNDT = (decimal)reader["PRV_A2_SNAP_TFRT_RNDT"],
                PRV_A2_NAP_OPR_TEMP = (decimal)reader["PRV_A2_NAP_OPR_TEMP"],
                PRV_A2_DAYTANK_LEVEL = (decimal)reader["PRV_A2_DAYTANK_LEVEL"],
                PRV_A2_DAYTANK_STOCK = (decimal)reader["PRV_A2_DAYTANK_STOCK"],
                PRV_A2_TOT_NAP_CONSP_GP2 = (decimal)reader["PRV_A2_TOT_NAP_CONSP_GP2"],
                PRV_A2_NAP_HYD_FURN_INT = (decimal)reader["PRV_A2_NAP_HYD_FURN_INT"],
                PRV_A2_NAP_HYD_FURN_INT_DIFF = (decimal)reader["PRV_A2_NAP_HYD_FURN_INT_DIFF"],
                PRV_A2_NAP_CONSP_HYD_FURN = (decimal)reader["PRV_A2_NAP_CONSP_HYD_FURN"],
                PRV_A2_NAP_DESUL_FURN_INT = (decimal)reader["PRV_A2_NAP_DESUL_FURN_INT"],
                PRV_A2_NAP_DESUL_FURN_INT_DIFF = (decimal)reader["PRV_A2_NAP_DESUL_FURN_INT_DIFF"],
                PRV_A2_NAP_CONSP_DESUL_FURN = (decimal)reader["PRV_A2_NAP_CONSP_DESUL_FURN"],
                PRV_A2_NAP_TUNNEL_BURNER_INT = (decimal)reader["PRV_A2_NAP_TUNNEL_BURNER_INT"],
                PRV_A2_NAP_TUNNEL_BURNER_INT_DIFF = (decimal)reader["PRV_A2_NAP_TUNNEL_BURNER_INT_DIFF"],
                PRV_A2_NAP_CONSP_TUNNEL_BURNER = (decimal)reader["PRV_A2_NAP_CONSP_TUNNEL_BURNER"],
                PRV_A2_NAP_ARCH_BURNER_INT = (decimal)reader["PRV_A2_NAP_ARCH_BURNER_INT"],
                PRV_A2_NAP_ARCH_BURNER_INT_DIFF = (decimal)reader["PRV_A2_NAP_ARCH_BURNER_INT_DIFF"],
                PRV_A2_NAP_CONSP_ARCH_BURNER = (decimal)reader["PRV_A2_NAP_CONSP_ARCH_BURNER"],
                PRV_A2_NAP_SHEATER_BURNER_INT = (decimal)reader["PRV_A2_NAP_SHEATER_BURNER_INT"],
                PRV_A2_NAP_SHEATER_BURNER_INT_DIFF = (decimal)reader["PRV_A2_NAP_SHEATER_BURNER_INT_DIFF"],
                PRV_A2_NAP_CONSP_SHEATER_BURNER = (decimal)reader["PRV_A2_NAP_CONSP_SHEATER_BURNER"],
                PRV_A2_TOT_FUELNAP_TO_AMM2 = (decimal)reader["PRV_A2_TOT_FUELNAP_TO_AMM2"],
                PRV_A2_NAP_AB_INT = (decimal)reader["PRV_A2_NAP_AB_INT"],
                PRV_A2_NAP_AB_INT_DIFF = (decimal)reader["PRV_A2_NAP_AB_INT_DIFF"],
                PRV_A2_NAP_CONSP_AB = (decimal)reader["PRV_A2_NAP_CONSP_AB"],
                PRV_A2_NAP_HDS_INT = (decimal)reader["PRV_A2_NAP_HDS_INT"],
                PRV_A2_NAP_HDS_INT_DIFF = (decimal)reader["PRV_A2_NAP_HDS_INT_DIFF"],
                PRV_A2_NAP_CONSP_HDS = (decimal)reader["PRV_A2_NAP_CONSP_HDS"],
                PRV_A2_BAL_NAP_CONSP_HDS = (decimal)reader["PRV_A2_BAL_NAP_CONSP_HDS"],
                PRV_A2_SNDT_LEVEL = (decimal)reader["PRV_A2_SNDT_LEVEL"],
                PRV_A2_SNDT_STOCK = (decimal)reader["PRV_A2_SNDT_STOCK"],
                PRV_A2_SNAP_PROD_INT = (decimal)reader["PRV_A2_SNAP_PROD_INT"],
                PRV_A2_SNAP_PROD_INT_DIFF = (decimal)reader["PRV_A2_SNAP_PROD_INT_DIFF"],
                PRV_A2_SNAP_PROD = (decimal)reader["PRV_A2_SNAP_PROD"],
                PRV_A2_SNAP_PREF_INT = (decimal)reader["PRV_A2_SNAP_PREF_INT"],
                PRV_A2_SNAP_PREF_INT_DIFF = (decimal)reader["PRV_A2_SNAP_PREF_INT_DIFF"],
                PRV_A2_SNAP_CONSP_PREF = (decimal)reader["PRV_A2_SNAP_CONSP_PREF"],
                PRV_A2_BAL_SNAP_CONSP_PREF = (decimal)reader["PRV_A2_BAL_SNAP_CONSP_PREF"],
                PRV_A2_REMARKS = reader["PRV_A2_REMARKS"].ToString(),
                PRV_TXT_SN_PROD = (decimal)reader["PRV_TXT_SN_PROD"],

                // DV
                ou1_nap_tfr_tank1_gpii = reader["ou1_nap_tfr_tank1_gpii"].ToString(),
                ou1_tot_gp2_nap_stk = (decimal)reader["ou1_tot_gp2_nap_stk"],
                ou1_nap_tfrt_daytank_gpii = (decimal)reader["ou1_nap_tfrt_daytank_gpii"],
                a2_nap_density = (decimal)reader["a2_nap_density"],
                G_NAP_DSGND_DENSITY = (decimal)reader["G_NAP_DSGND_DENSITY"],
                G_NAP_SNDT_CALIB = (decimal)reader["G_NAP_SNDT_CALIB"],


                PARM_OP_DT_STOCK = (decimal)reader["PARM_OP_DT_STOCK"]

            };
        }

        public async Task<PAS205Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_NAP_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS205Model response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PAS205SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_NAP_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFR_TANK", value.A2_NAP_TFR_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BAL_NAP_TFRT_DAYTANK", value.A2_BAL_NAP_TFRT_DAYTANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFRT_DAYTANK_INT", value.A2_NAP_TFRT_DAYTANK_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFRT_DAYTANK_INT_DIFF", value.A2_NAP_TFRT_DAYTANK_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFRT_DAYTANK", value.A2_NAP_TFRT_DAYTANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DAYTANK_LEVEL", value.A2_DAYTANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DAYTANK_STOCK", value.A2_DAYTANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_NAP_BULK_STOCK", value.A2_TOT_NAP_BULK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_NAP_CONSP_GP2", value.A2_TOT_NAP_CONSP_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_HYD_FURN_INT", value.A2_NAP_HYD_FURN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_HYD_FURN_INT_DIFF", value.A2_NAP_HYD_FURN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_HYD_FURN", value.A2_NAP_CONSP_HYD_FURN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_DESUL_FURN_INT", value.A2_NAP_DESUL_FURN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_DESUL_FURN_INT_DIFF", value.A2_NAP_DESUL_FURN_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_DESUL_FURN", value.A2_NAP_CONSP_DESUL_FURN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TUNNEL_BURNER_INT", value.A2_NAP_TUNNEL_BURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TUNNEL_BURNER_INT_DIFF", value.A2_NAP_TUNNEL_BURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_TUNNEL_BURNER", value.A2_NAP_CONSP_TUNNEL_BURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_ARCH_BURNER_INT", value.A2_NAP_ARCH_BURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_ARCH_BURNER_INT_DIFF", value.A2_NAP_ARCH_BURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_ARCH_BURNER", value.A2_NAP_CONSP_ARCH_BURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_SHEATER_BURNER_INT", value.A2_NAP_SHEATER_BURNER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_SHEATER_BURNER_INT_DIFF", value.A2_NAP_SHEATER_BURNER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_SHEATER_BURNER", value.A2_NAP_CONSP_SHEATER_BURNER));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOT_FUELNAP_TO_AMM2", value.A2_TOT_FUELNAP_TO_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_NET_CV", value.A2_NAP_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_AB_INT", value.A2_NAP_AB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_AB_INT_DIFF", value.A2_NAP_AB_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_AB", value.A2_NAP_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_HDS_INT", value.A2_NAP_HDS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_HDS_INT_DIFF", value.A2_NAP_HDS_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_CONSP_HDS", value.A2_NAP_CONSP_HDS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BAL_NAP_CONSP_HDS", value.A2_BAL_NAP_CONSP_HDS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_PROD_INT", value.A2_SNAP_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_PROD_INT_DIFF", value.A2_SNAP_PROD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_PROD", value.A2_SNAP_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNDT_LEVEL", value.A2_SNDT_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNDT_STOCK", value.A2_SNDT_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_PREF_INT", value.A2_SNAP_PREF_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_PREF_INT_DIFF", value.A2_SNAP_PREF_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_CONSP_PREF", value.A2_SNAP_CONSP_PREF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_BAL_SNAP_CONSP_PREF", value.A2_BAL_SNAP_CONSP_PREF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_OPR_TEMP", value.A2_NAP_OPR_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_DENSITY", value.A2_NAP_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFRT_DAYTANK_MT_INT", value.A2_NAP_TFRT_DAYTANK_MT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFRT_DAYTANK_MT_INT_DIFF", value.A2_NAP_TFRT_DAYTANK_MT_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_NAP_TFRT_DAYTANK_MT", value.A2_NAP_TFRT_DAYTANK_MT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNDT_NAP_DENSITY", value.A2_SNDT_NAP_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SNAP_TFRT_RNDT", value.A2_SNAP_TFRT_RNDT));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
