using itsppisapi.Models;
using itsppisapi.SaveDtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PTS008Repository
    {
        private readonly string _connectionString;
        public PTS008Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PTS008Model MapToValue(SqlDataReader reader)
        {
            return new PTS008Model()
            {
                MINMONTH = (decimal)reader["MINMONTH"],
                MAXMONTH = (decimal)reader["MAXMONTH"],
                MINYEAR = (decimal)reader["MINYEAR"],
                MAXYEAR = (decimal)reader["MAXYEAR"],
                T_DAY = (dynamic)reader["T_DAY"],
                T_MONTH = (dynamic)reader["T_MONTH"],
                T_YEAR = (dynamic)reader["T_YEAR"],
                T_UNIT_ID = reader["T_UNIT_ID"].ToString(),
                T_VERSION = (dynamic)reader["T_VERSION"],
                T_USER_ID = (dynamic)reader["T_USER_ID"],
                T_USER_NAME = reader["T_USER_NAME"].ToString(),
                T_DATE_MOD = reader["T_DATE_MOD"].ToString(),
                T_RW_STOCK = (decimal)reader["T_RW_STOCK"],
                T_RW_RECEIPT_KSR = (decimal)reader["T_RW_RECEIPT_KSR"],
                T_RW_IMPORTF_UNIT2 = (decimal)reader["T_RW_IMPORTF_UNIT2"],
                T_RW_TOT_RECPT = (decimal)reader["T_RW_TOT_RECPT"],
                T_RW_CONSP_WPT = (decimal)reader["T_RW_CONSP_WPT"],
                T_RW_CONSP_GB = (decimal)reader["T_RW_CONSP_GB"],
                T_RW_CONSP_DILUTION = (decimal)reader["T_RW_CONSP_DILUTION"],
                T_RW_EXPORTT_UNIT2 = (decimal)reader["T_RW_EXPORTT_UNIT2"],
                T_RW_LOSS = (decimal)reader["T_RW_LOSS"],
                T_RW_TOT_CONSP = (decimal)reader["T_RW_TOT_CONSP"],
                T_FW_STOCK = (decimal)reader["T_FW_STOCK"],
                T_FW_PURCHASED = (decimal)reader["T_FW_PURCHASED"],
                T_FW_IMPORTF_UNIT2 = (decimal)reader["T_FW_IMPORTF_UNIT2"],
                T_FW_TOT_RECPT = (decimal)reader["T_FW_TOT_RECPT"],
                T_FW_CONSP_DMP = (decimal)reader["T_FW_CONSP_DMP"],
                T_FW_CONSP_ACT = (decimal)reader["T_FW_CONSP_ACT"],
                T_FW_CONSP_UCT = (decimal)reader["T_FW_CONSP_UCT"],
                T_FW_CONSP_DW = (decimal)reader["T_FW_CONSP_DW"],
                T_FW_CONSP_SW = (decimal)reader["T_FW_CONSP_SW"],
                T_FW_CONSP_BW = (decimal)reader["T_FW_CONSP_BW"],
                T_FW_CONSP_OFFSITE = (decimal)reader["T_FW_CONSP_OFFSITE"],
                T_FW_CONSP_CPP = (decimal)reader["T_FW_CONSP_CPP"],
                T_FW_CONSP_ETP = (decimal)reader["T_FW_CONSP_ETP"],
                T_FW_CONSP_FIRE = (decimal)reader["T_FW_CONSP_FIRE"],
                T_FW_EXPORTT_UNIT2 = (decimal)reader["T_FW_EXPORTT_UNIT2"],
                T_FW_TOT_CONSP = (decimal)reader["T_FW_TOT_CONSP"],
                T_DMW_STOCK = (decimal)reader["T_DMW_STOCK"],
                T_DMW_PROD = (decimal)reader["T_DMW_PROD"],
                T_REGN_LOSS_DMP = (decimal)reader["T_REGN_LOSS_DMP"],
                T_CTTC_PROD = (decimal)reader["T_CTTC_PROD"],
                T_APC_PROD = (decimal)reader["T_APC_PROD"],
                T_ATC_PROD = (decimal)reader["T_ATC_PROD"],
                T_UPC_PROD = (decimal)reader["T_UPC_PROD"],
                T_UTC_PROD = (decimal)reader["T_UTC_PROD"],
                T_USC_PROD = (decimal)reader["T_USC_PROD"],
                T_APC_IMPORTF_UNIT2 = (decimal)reader["T_APC_IMPORTF_UNIT2"],
                T_ATC_IMPORTF_UNIT2 = (decimal)reader["T_ATC_IMPORTF_UNIT2"],
                T_CTTC_IMPORTF_UNIT2 = (decimal)reader["T_CTTC_IMPORTF_UNIT2"],
                T_UPC_IMPORTF_UNIT2 = (decimal)reader["T_UPC_IMPORTF_UNIT2"],
                T_USC_IMPORTF_UNIT2 = (decimal)reader["T_USC_IMPORTF_UNIT2"],
                T_UTC_IMPORTF_UNIT2 = (decimal)reader["T_UTC_IMPORTF_UNIT2"],
                T_TOT_CONDENSATE = (decimal)reader["T_TOT_CONDENSATE"],
                T_CONDENSATE_DRAINED = (decimal)reader["T_CONDENSATE_DRAINED"],
                T_NET_CONDENSATE = (decimal)reader["T_NET_CONDENSATE"],
                T_DMW_IMPORTF_UNIT2 = (decimal)reader["T_DMW_IMPORTF_UNIT2"],
                T_DMW_NET_RECEIPT = (decimal)reader["T_DMW_NET_RECEIPT"],
                T_PW_FEED_MB = (decimal)reader["T_PW_FEED_MB"],
                T_DMW_EXPORTT_UNIT2 = (decimal)reader["T_DMW_EXPORTT_UNIT2"],
                T_DMW_TOT_CONSP = (decimal)reader["T_DMW_TOT_CONSP"],
                T_REGN_LOSS_MB = (decimal)reader["T_REGN_LOSS_MB"],
                T_PW_STOCK = (decimal)reader["T_PW_STOCK"],
                T_PW_IMPORTF_UNIT2 = (decimal)reader["T_PW_IMPORTF_UNIT2"],
                T_PW_NET_RECEIPT = (decimal)reader["T_PW_NET_RECEIPT"],
                T_PW_CONSP_AMM = (decimal)reader["T_PW_CONSP_AMM"],
                T_PW_CONSP_UREA = (decimal)reader["T_PW_CONSP_UREA"],
                T_PW_CONSP_SPG = (decimal)reader["T_PW_CONSP_SPG"],
                T_PW_EXPORTT_UNIT2 = (decimal)reader["T_PW_EXPORTT_UNIT2"],
                T_PW_CONSP_OTHERS = (decimal)reader["T_PW_CONSP_OTHERS"],
                T_PW_CONSP_CPP = (decimal)reader["T_PW_CONSP_CPP"],
                T_PW_CONSP_OFFSITE = (decimal)reader["T_PW_CONSP_OFFSITE"],
                T_PW_TOT_CONSP = (decimal)reader["T_PW_TOT_CONSP"],
                T_FW_CONSP_DW_UNIT2 = (decimal)reader["T_FW_CONSP_DW_UNIT2"],
                T_FW_CONSP_FIRE_UNIT2 = (decimal)reader["T_FW_CONSP_FIRE_UNIT2"],
                T_FW_CONSP_MISC_UNIT2 = (decimal)reader["T_FW_CONSP_MISC_UNIT2"],
                T_FW_CONSP_TOTL_UNIT2 = (decimal)reader["T_FW_CONSP_TOTL_UNIT2"],
                T_RW_CONSP_UNIT1 = (decimal)reader["T_RW_CONSP_UNIT1"],
                T_RW_CONSP_UNIT2 = (decimal)reader["T_RW_CONSP_UNIT2"],
                T_RW_CONSP_UNIT1_TOP20 = (decimal)reader["T_RW_CONSP_UNIT1_TOP20"],
                T_RW_CONSP_UNIT2_TOP20 = (decimal)reader["T_RW_CONSP_UNIT2_TOP20"],
                T_FW_CONSP_FB_UNIT1 = (decimal)reader["T_FW_CONSP_FB_UNIT1"],
                T_FW_CONSP_FB_UNIT2 = (decimal)reader["T_FW_CONSP_FB_UNIT2"],
                T_FW_CONSP_DMPFEED_UNIT1 = (decimal)reader["T_FW_CONSP_DMPFEED_UNIT1"],
                T_FW_CONSP_DMPFEED_UNIT2 = (decimal)reader["T_FW_CONSP_DMPFEED_UNIT2"],
                T_FW_CONSP_SSP = (decimal)reader["T_FW_CONSP_SSP"],
                T_RW_EXPORTT_UNIT3 = (decimal)reader["T_RW_EXPORTT_UNIT3"],
                T_RW_IMPORTF_UNIT3 = (decimal)reader["T_RW_IMPORTF_UNIT3"],
                T_FW_IMPORTF_FB_UNIT3 = (decimal)reader["T_FW_IMPORTF_FB_UNIT3"],
                T_FW_EXPORTT_UNIT3 = (decimal)reader["T_FW_EXPORTT_UNIT3"],
                T_FW_IMPORTF_UNIT3 = (decimal)reader["T_FW_IMPORTF_UNIT3"],
                T_FW_CONSP_NP_UNIT3 = (decimal)reader["T_FW_CONSP_NP_UNIT3"]
            };
        }

        private PTS008DVModel MapToValueDV(SqlDataReader reader)
        {
            return new PTS008DVModel()
            {
                PRV_CLOSING_STK = (decimal)reader["PRV_CLOSING_STK"]
            };
        }

        public async Task<PTS008Model> putData(decimal IN_T_YEAR, decimal IN_T_MONTH, decimal IN_T_VERSION
            , char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_TS1_GET_PPT_TS_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_T_YEAR", IN_T_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_MONTH", IN_T_MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_VERSION", IN_T_VERSION));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PTS008Model response = null;
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

        public async Task<PTS008DVModel> getDV2(decimal in_water_type, decimal IN_MONTH, decimal IN_YEAR)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CAST(ISNULL(PPIS.PPU_F_TSE_GET_PRV_WATER_CLOSING_STOCK(" + in_water_type + "," + IN_MONTH + "," + IN_YEAR + "),0.0) AS NUMERIC(17,5)) AS PRV_CLOSING_STK", sql))
                {
                    PTS008DVModel response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValueDV(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PTS008SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_TS1_SAVE_PPT_TS_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_T_DAY", value.T_DAY));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_YEAR", value.T_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_MONTH", value.T_MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_VERSION", value.T_VERSION));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_USER_ID", value.T_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_STOCK", value.T_RW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_RECEIPT_KSR", value.T_RW_RECEIPT_KSR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_IMPORTF_UNIT2", value.T_RW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_TOT_RECPT", value.T_RW_TOT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_WPT", value.T_RW_CONSP_WPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_GB", value.T_RW_CONSP_GB));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_DILUTION", value.T_RW_CONSP_DILUTION));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_EXPORTT_UNIT2", value.T_RW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_LOSS", value.T_RW_LOSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_TOT_CONSP", value.T_RW_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_STOCK", value.T_FW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_PURCHASED", value.T_FW_PURCHASED));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_IMPORTF_UNIT2", value.T_FW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_TOT_RECPT", value.T_FW_TOT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_DMP", value.T_FW_CONSP_DMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_ACT", value.T_FW_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_UCT", value.T_FW_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_DW", value.T_FW_CONSP_DW));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_SW", value.T_FW_CONSP_SW));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_BW", value.T_FW_CONSP_BW));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_OFFSITE", value.T_FW_CONSP_OFFSITE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_CPP", value.T_FW_CONSP_CPP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_ETP", value.T_FW_CONSP_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_FIRE", value.T_FW_CONSP_FIRE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_EXPORTT_UNIT2", value.T_FW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_TOT_CONSP", value.T_FW_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_DMW_STOCK", value.T_DMW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_DMW_PROD", value.T_DMW_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_REGN_LOSS_DMP", value.T_REGN_LOSS_DMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_CTTC_PROD", value.T_CTTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_APC_PROD", value.T_APC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_ATC_PROD", value.T_ATC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_UPC_PROD", value.T_UPC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_UTC_PROD", value.T_UTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_USC_PROD", value.T_USC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_APC_IMPORTF_UNIT2", value.T_APC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_ATC_IMPORTF_UNIT2", value.T_ATC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_CTTC_IMPORTF_UNIT2", value.T_CTTC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_UPC_IMPORTF_UNIT2", value.T_UPC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_USC_IMPORTF_UNIT2", value.T_USC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_UTC_IMPORTF_UNIT2", value.T_UTC_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_TOT_CONDENSATE", value.T_TOT_CONDENSATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_CONDENSATE_DRAINED", value.T_CONDENSATE_DRAINED));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_NET_CONDENSATE", value.T_NET_CONDENSATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_DMW_IMPORTF_UNIT2", value.T_DMW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_DMW_NET_RECEIPT", value.T_DMW_NET_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_FEED_MB", value.T_PW_FEED_MB));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_DMW_EXPORTT_UNIT2", value.T_DMW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_DMW_TOT_CONSP", value.T_DMW_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_REGN_LOSS_MB", value.T_REGN_LOSS_MB));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_STOCK", value.T_PW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_IMPORTF_UNIT2", value.T_PW_IMPORTF_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_NET_RECEIPT", value.T_PW_NET_RECEIPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_CONSP_AMM", value.T_PW_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_CONSP_UREA", value.T_PW_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_CONSP_SPG", value.T_PW_CONSP_SPG));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_EXPORTT_UNIT2", value.T_PW_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_CONSP_OTHERS", value.T_PW_CONSP_OTHERS));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_CONSP_CPP", value.T_PW_CONSP_CPP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_CONSP_OFFSITE", value.T_PW_CONSP_OFFSITE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PW_TOT_CONSP", value.T_PW_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_DW_UNIT2", value.T_FW_CONSP_DW_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_FIRE_UNIT2", value.T_FW_CONSP_FIRE_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_MISC_UNIT2", value.T_FW_CONSP_MISC_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_TOTL_UNIT2", value.T_FW_CONSP_TOTL_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_UNIT1", value.T_RW_CONSP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_UNIT2", value.T_RW_CONSP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_UNIT1_TOP20", value.T_RW_CONSP_UNIT1_TOP20));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_CONSP_UNIT2_TOP20", value.T_RW_CONSP_UNIT2_TOP20));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_FB_UNIT1", value.T_FW_CONSP_FB_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_FB_UNIT2", value.T_FW_CONSP_FB_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_DMPFEED_UNIT1", value.T_FW_CONSP_DMPFEED_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_DMPFEED_UNIT2", value.T_FW_CONSP_DMPFEED_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_SSP", value.T_FW_CONSP_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_EXPORTT_UNIT3", value.T_RW_EXPORTT_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_RW_IMPORTF_UNIT3", value.T_RW_IMPORTF_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_IMPORTF_FB_UNIT3", value.T_FW_IMPORTF_FB_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_EXPORTT_UNIT3", value.T_FW_EXPORTT_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_IMPORTF_UNIT3", value.T_FW_IMPORTF_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_FW_CONSP_NP_UNIT3", value.T_FW_CONSP_NP_UNIT3));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
