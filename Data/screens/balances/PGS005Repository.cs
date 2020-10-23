using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PGS005Repository
    {
        private readonly string _connectionString;
        public PGS005Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS005Model MapToValue(SqlDataReader reader)
        {
            return new PGS005Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),
                RW_CALC_STOCK2 = (decimal)reader["RW_CALC_STOCK2"],
                OU1_RW_CALC_STOCK = (decimal)reader["OU1_RW_CALC_STOCK"],
                OU1_RW_RECPT_KSR = (decimal)reader["OU1_RW_RECPT_KSR"],
                OU1_FW_CONSP_BW = (decimal)reader["OU1_FW_CONSP_BW"],
                OU1_RW_IMPORTF_UNIT2 = (decimal)reader["OU1_RW_IMPORTF_UNIT2"],
                OU1_FW_CONSP_BW_GP2 = (decimal)reader["OU1_FW_CONSP_BW_GP2"],
                OU1_RW_TOTAL_RECPT = (decimal)reader["OU1_RW_TOTAL_RECPT"],
                OU1_RW_CONSP_WPT = (decimal)reader["OU1_RW_CONSP_WPT"],
                OU1_RW_CONSP_DILUTION = (decimal)reader["OU1_RW_CONSP_DILUTION"],
                OU1_RW_CONSP_DILUTION_GP2 = (decimal)reader["OU1_RW_CONSP_DILUTION_GP2"],
                OU1_RW_CONSP_GB = (decimal)reader["OU1_RW_CONSP_GB"],
                OU1_RW_CONSP_GB_GP2 = (decimal)reader["OU1_RW_CONSP_GB_GP2"],
                OU1_RW_TOTAL_CONSP = (decimal)reader["OU1_RW_TOTAL_CONSP"],
                FW_STOCK2 = (decimal)reader["FW_STOCK2"],
                OU1_FW_STOCK = (decimal)reader["OU1_FW_STOCK"],
                RW_CONSP_WPT2 = (decimal)reader["RW_CONSP_WPT2"],
                OU1_FW_TOTAL_RECPT = (decimal)reader["OU1_FW_TOTAL_RECPT"],
                OU1_FW_CONSP_DMP = (decimal)reader["OU1_FW_CONSP_DMP"],
                OU1_FW_CONSP_DMP_GP2 = (decimal)reader["OU1_FW_CONSP_DMP_GP2"],
                OU1_FW_CONSP_UCT = (decimal)reader["OU1_FW_CONSP_UCT"],
                OU1_FW_CONSP_UCT_GP2 = (decimal)reader["OU1_FW_CONSP_UCT_GP2"],
                OU1_FW_CONSP_ACT = (decimal)reader["OU1_FW_CONSP_ACT"],
                OU1_FW_CONSP_ACT_GP2 = (decimal)reader["OU1_FW_CONSP_ACT_GP2"],
                OU1_FW_CONSP_DW = (decimal)reader["OU1_FW_CONSP_DW"],
                OU1_FW_CONSP_DW_GP2 = (decimal)reader["OU1_FW_CONSP_DW_GP2"],
                FW_CONSP_BW2 = (decimal)reader["FW_CONSP_BW2"],
                FW_CONSP_BW2_GP2 = (decimal)reader["FW_CONSP_BW2_GP2"],
                OU1_FW_CONSP_SW = (decimal)reader["OU1_FW_CONSP_SW"],
                OU1_FW_CONSP_SW_GP2 = (decimal)reader["OU1_FW_CONSP_SW_GP2"],
                OU1_FW_CONSP_FIRE = (decimal)reader["OU1_FW_CONSP_FIRE"],
                OU1_FW_CONSP_FIRE_GP2 = (decimal)reader["OU1_FW_CONSP_FIRE_GP2"],
                OU1_FW_TOTAL_CONSP_GP1 = (decimal)reader["OU1_FW_TOTAL_CONSP_GP1"],
                OU1_FW_TOTAL_CONSP_GP2 = (decimal)reader["OU1_FW_TOTAL_CONSP_GP2"],
                OU1_FW_SUM_TOTAL_CONSP = (decimal)reader["OU1_FW_SUM_TOTAL_CONSP"],
                OU1_APC_PROD = (decimal)reader["OU1_APC_PROD"],
                OU1_UPC_PROD = (decimal)reader["OU1_UPC_PROD"],
                OU1_ATC_PROD = (decimal)reader["OU1_ATC_PROD"],
                OU1_UTC_PROD = (decimal)reader["OU1_UTC_PROD"],
                OU1_CTTC_PROD = (decimal)reader["OU1_CTTC_PROD"],
                OU1_USC_PROD = (decimal)reader["OU1_USC_PROD"],
                OU1_APC_IMPORTF_UNIT2 = (decimal)reader["OU1_APC_IMPORTF_UNIT2"],
                OU1_UPC_IMPORTF_UNIT2 = (decimal)reader["OU1_UPC_IMPORTF_UNIT2"],
                OU1_ATC_IMPORTF_UNIT2 = (decimal)reader["OU1_ATC_IMPORTF_UNIT2"],
                OU1_UTC_IMPORTF_UNIT2 = (decimal)reader["OU1_UTC_IMPORTF_UNIT2"],
                OU1_CTTC_IMPORTF_UNIT2 = (decimal)reader["OU1_CTTC_IMPORTF_UNIT2"],
                OU1_USC_IMPORTF_UNIT2 = (decimal)reader["OU1_USC_IMPORTF_UNIT2"],
                OU1_TOTAL_CONDENSATE = (decimal)reader["OU1_TOTAL_CONDENSATE"],
                OU1_CONDENSATE_DRAINED_GP1 = (decimal)reader["OU1_CONDENSATE_DRAINED_GP1"],
                OU1_NET_CONDENSATE = (decimal)reader["OU1_NET_CONDENSATE"],
                OU1_CONDENSATE_DRAINED_GP2 = (decimal)reader["OU1_CONDENSATE_DRAINED_GP2"],
                DMW_STOCK2 = (decimal)reader["DMW_STOCK2"],
                OU1_DMW_STOCK = (decimal)reader["OU1_DMW_STOCK"],
                FW_CONSP_DMP_GP1 = (decimal)reader["FW_CONSP_DMP_GP1"],
                FW_CONSP_DMP_GP2 = (decimal)reader["FW_CONSP_DMP_GP2"],
                OU1_REGN_LOSS_DMP_GP1 = (decimal)reader["OU1_REGN_LOSS_DMP_GP1"],
                OU1_REGN_LOSS_DMP_GP2 = (decimal)reader["OU1_REGN_LOSS_DMP_GP2"],
                APC_PROD2 = (decimal)reader["APC_PROD2"],
                APC_IMPORTF_UNIT2_2 = (decimal)reader["APC_IMPORTF_UNIT2_2"],
                UPC_PROD2 = (decimal)reader["UPC_PROD2"],
                UPC_IMPORTF_UNIT2_2 = (decimal)reader["UPC_IMPORTF_UNIT2_2"],
                USC_PROD2 = (decimal)reader["USC_PROD2"],
                USC_IMPORTF_UNIT2_2 = (decimal)reader["USC_IMPORTF_UNIT2_2"],
                ATC_PROD2 = (decimal)reader["ATC_PROD2"],
                ATC_IMPORTF_UNIT2_2 = (decimal)reader["ATC_IMPORTF_UNIT2_2"],
                UTC_PROD2 = (decimal)reader["UTC_PROD2"],
                UTC_IMPORTF_UNIT2_2 = (decimal)reader["UTC_IMPORTF_UNIT2_2"],
                CTTC_PROD2 = (decimal)reader["CTTC_PROD2"],
                CTTC_IMPORTF_UNIT2_2 = (decimal)reader["CTTC_IMPORTF_UNIT2_2"],
                CONDENSATE_DRAINED_GP1 = (decimal)reader["CONDENSATE_DRAINED_GP1"],
                CONDENSATE_DRAINED_GP2 = (decimal)reader["CONDENSATE_DRAINED_GP2"],
                OU1_DMW_PROD = (decimal)reader["OU1_DMW_PROD"],
                OU1_DMW_NET_PROD = (decimal)reader["OU1_DMW_NET_PROD"],
                OU1_PW_FEED_MB = (decimal)reader["OU1_PW_FEED_MB"],
                OU1_REGN_LOSS_MB_GP2 = (decimal)reader["OU1_REGN_LOSS_MB_GP2"],
                OU1_REGN_LOSS_MB_GP1 = (decimal)reader["OU1_REGN_LOSS_MB_GP1"],
                OU1_DMW_NET_CONSP = (decimal)reader["OU1_DMW_NET_CONSP"],
                PW_STOCK2 = (decimal)reader["PW_STOCK2"],
                OU1_PW_STOCK = (decimal)reader["OU1_PW_STOCK"],
                PW_FEED_MB2 = (decimal)reader["PW_FEED_MB2"],
                OU1_PW_IMPORTF_UNIT2 = (decimal)reader["OU1_PW_IMPORTF_UNIT2"],
                OU1_PW_NET_PROD = (decimal)reader["OU1_PW_NET_PROD"],
                OU1_PW_CONSP_AMM = (decimal)reader["OU1_PW_CONSP_AMM"],
                OU1_PW_CONSP_UREA = (decimal)reader["OU1_PW_CONSP_UREA"],
                OU1_PW_CONSP_SPG = (decimal)reader["OU1_PW_CONSP_SPG"],
                OU1_PW_EXPORTT_UNIT2 = (decimal)reader["OU1_PW_EXPORTT_UNIT2"],
                OU1_TOTAL_PW_DISTRIBUTION = (decimal)reader["OU1_TOTAL_PW_DISTRIBUTION"]
            };
        }

        public async Task<PGS005Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_WATER_BAL_PGS005", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS005Model response = null;
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
    }
}
