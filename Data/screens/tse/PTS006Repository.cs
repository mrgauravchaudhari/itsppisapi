using itsppisapi.Models;
using itsppisapi.SaveDtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PTS006Repository
    {
        private readonly string _connectionString;
        public PTS006Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PTS006Model MapToValue(SqlDataReader reader)
        {
            return new PTS006Model()
            {
                MINMONTH = (dynamic)reader["MINMONTH"],
                MAXMONTH = (dynamic)reader["MAXMONTH"],
                MINYEAR = (dynamic)reader["MINYEAR"],
                MAXYEAR = (dynamic)reader["MAXYEAR"],
                T_DAY = (dynamic)reader["T_DAY"],
                T_MONTH = (dynamic)reader["T_MONTH"],
                T_YEAR = (dynamic)reader["T_YEAR"],
                T_UNIT_ID = reader["T_UNIT_ID"].ToString(),
                T_VERSION = (dynamic)reader["T_VERSION"],
                T_USER_ID = (dynamic)reader["T_USER_ID"],
                T_USER_NAME = reader["T_USER_NAME"].ToString(),
                T_DATE_MOD = reader["T_DATE_MOD"].ToString(),
                T_PWR_CONSP_AB = (decimal)reader["T_PWR_CONSP_AB"],
                T_PWR_CONSP_ACT = (decimal)reader["T_PWR_CONSP_ACT"],
                T_PWR_CONSP_AMM = (decimal)reader["T_PWR_CONSP_AMM"],
                T_PWR_CONSP_AMMSTRG = (decimal)reader["T_PWR_CONSP_AMMSTRG"],
                T_PWR_CONSP_UPHS = (decimal)reader["T_PWR_CONSP_UPHS"],
                T_PWR_CONSP_CPP = (decimal)reader["T_PWR_CONSP_CPP"],
                T_PWR_CONSP_DMP = (decimal)reader["T_PWR_CONSP_DMP"],
                T_PWR_CONSP_EDG = (decimal)reader["T_PWR_CONSP_EDG"],
                T_PWR_CONSP_ETP = (decimal)reader["T_PWR_CONSP_ETP"],
                T_PWR_CONSP_FIRE = (decimal)reader["T_PWR_CONSP_FIRE"],
                T_PWR_CONSP_HOUSING = (decimal)reader["T_PWR_CONSP_HOUSING"],
                T_PWR_CONSP_IAC_SPG = (decimal)reader["T_PWR_CONSP_IAC_SPG"],
                T_PWR_CONSP_KSR = (decimal)reader["T_PWR_CONSP_KSR"],
                T_PWR_CONSP_UCT = (decimal)reader["T_PWR_CONSP_UCT"],
                T_PWR_CONSP_UREA = (decimal)reader["T_PWR_CONSP_UREA"],
                T_PWR_CONSP_WPT = (decimal)reader["T_PWR_CONSP_WPT"],
                T_PWR_TFR_NE = (decimal)reader["T_PWR_TFR_NE"],
                T_PWR_GEN_GT1 = (decimal)reader["T_PWR_GEN_GT1"],
                T_PWR_GEN_GT2 = (decimal)reader["T_PWR_GEN_GT2"],
                T_PWR_PRCHSD = (decimal)reader["T_PWR_PRCHSD"],
                T_PWR_RAW_PUMPS = (decimal)reader["T_PWR_RAW_PUMPS"],
                T_SELF_PWR_CONSP_GP2 = (decimal)reader["T_SELF_PWR_CONSP_GP2"],
                T_PRCHSD_PWR_CONSP_GP2 = (decimal)reader["T_PRCHSD_PWR_CONSP_GP2"],
                T_TOT_PWR_GEN = (decimal)reader["T_TOT_PWR_GEN"],
                T_PWR_SPG_CONSP = (decimal)reader["T_PWR_SPG_CONSP"],
                T_PWR_OFFSITE_CONSP = (decimal)reader["T_PWR_OFFSITE_CONSP"],
                T_LOSS_GEN_PWR = (decimal)reader["T_LOSS_GEN_PWR"],
                T_PWR_CONSP_IAC_OFFSITE = (decimal)reader["T_PWR_CONSP_IAC_OFFSITE"],
                T_PWR_CONSP_U11 = (decimal)reader["T_PWR_CONSP_U11"],
                T_PWR_CONSP_U21 = (decimal)reader["T_PWR_CONSP_U21"],
                T_TOT_PWR_AVAIL = (decimal)reader["T_TOT_PWR_AVAIL"],
                T_TOT_EBUS_CONSP = (decimal)reader["T_TOT_EBUS_CONSP"],
                T_TOT_NEBUS_CONSP = (decimal)reader["T_TOT_NEBUS_CONSP"],
                T_PWR_CONSP_BLDG_STRTS = (decimal)reader["T_PWR_CONSP_BLDG_STRTS"],
                T_PWR_ALLOC_IA_GP2 = (decimal)reader["T_PWR_ALLOC_IA_GP2"],
                T_PWR_CONSP_AMMSTRG_UNIT2 = (decimal)reader["T_PWR_CONSP_AMMSTRG_UNIT2"],
                T_PWR_CONSP_UPHS_UNIT2 = (decimal)reader["T_PWR_CONSP_UPHS_UNIT2"],
                T_PWR_CONSP_ETP_UNIT2 = (decimal)reader["T_PWR_CONSP_ETP_UNIT2"],
                T_PWR_CONSP_FIRE_UNIT2 = (decimal)reader["T_PWR_CONSP_FIRE_UNIT2"],
                T_PWR_CONSP_CONST_UNIT2 = (decimal)reader["T_PWR_CONSP_CONST_UNIT2"],
                T_PWR_CONSP_HOUSING_UNIT2 = (decimal)reader["T_PWR_CONSP_HOUSING_UNIT2"],
                T_PWR_CONSP_KSR_UNIT2 = (decimal)reader["T_PWR_CONSP_KSR_UNIT2"],
                T_PWR_CONSP_BLDG_STRTS_UNIT2 = (decimal)reader["T_PWR_CONSP_BLDG_STRTS_UNIT2"],
                T_PWR_CONSP_RSEB_GPII = (decimal)reader["T_PWR_CONSP_RSEB_GPII"],
                T_PWR_CONSP_NAP_STRG = (decimal)reader["T_PWR_CONSP_NAP_STRG"],
                T_PWR_CONSP_NAP_HANDLG_CPP = (decimal)reader["T_PWR_CONSP_NAP_HANDLG_CPP"],
                T_PWR_CONSP_NAP_HANDLG_AB = (decimal)reader["T_PWR_CONSP_NAP_HANDLG_AB"],
                T_PWR_CONSP_NAP_HANDLG_AMM = (decimal)reader["T_PWR_CONSP_NAP_HANDLG_AMM"],
                T_PWR_CONSP_NAP_STRG_UNIT2 = (decimal)reader["T_PWR_CONSP_NAP_STRG_UNIT2"],
                T_PWR_CONSP_DMP_UNIT2 = (decimal)reader["T_PWR_CONSP_DMP_UNIT2"],
                T_PWR_TFR_EBUS = (decimal)reader["T_PWR_TFR_EBUS"],
                T_PUR_PWR_CONSP_WPT = (decimal)reader["T_PUR_PWR_CONSP_WPT"],
                T_PUR_PWR_CONSP_WPT_UNIT1 = (decimal)reader["T_PUR_PWR_CONSP_WPT_UNIT1"],
                T_PUR_PWR_CONSP_WPT_UNIT2 = (decimal)reader["T_PUR_PWR_CONSP_WPT_UNIT2"],
                T_NEBUS_CONSP_UNIT2 = (decimal)reader["T_NEBUS_CONSP_UNIT2"],
                T_GEN_PWR_CONSP_KSR_UNIT1 = (decimal)reader["T_GEN_PWR_CONSP_KSR_UNIT1"],
                T_GEN_PWR_CONSP_KSR_UNIT2 = (decimal)reader["T_GEN_PWR_CONSP_KSR_UNIT2"],
                T_PUR_PWR_CONSP_BAGG_UNIT1 = (decimal)reader["T_PUR_PWR_CONSP_BAGG_UNIT1"],
                T_PUR_PWR_CONSP_BAGG_UNIT2 = (decimal)reader["T_PUR_PWR_CONSP_BAGG_UNIT2"],
                T_PUR_PWR_CONSP_RW = (decimal)reader["T_PUR_PWR_CONSP_RW"],
                T_PUR_PWR_CONSP_DMP = (decimal)reader["T_PUR_PWR_CONSP_DMP"],
                T_PUR_PWR_CONSP_ETP_UNIT1 = (decimal)reader["T_PUR_PWR_CONSP_ETP_UNIT1"],
                T_PUR_PWR_CONSP_ETP_UNIT2 = (decimal)reader["T_PUR_PWR_CONSP_ETP_UNIT2"],
                T_PUR_PWR_CONSP_ACT = (decimal)reader["T_PUR_PWR_CONSP_ACT"],
                T_PUR_PWR_CONSP_UCT = (decimal)reader["T_PUR_PWR_CONSP_UCT"],
                T_PUR_PWR_CONSP_IAC = (decimal)reader["T_PUR_PWR_CONSP_IAC"],
                T_PUR_PWR_CONSP_DMP_UNIT2 = (decimal)reader["T_PUR_PWR_CONSP_DMP_UNIT2"],
                T_PUR_PWR_CONSP_IA_UNIT2 = (decimal)reader["T_PUR_PWR_CONSP_IA_UNIT2"],
                T_PUR_PWR_CONSP_DMP_UNIT1 = (decimal)reader["T_PUR_PWR_CONSP_DMP_UNIT1"],
                T_PUR_PWR_ALLOC_DMP_UNIT2 = (decimal)reader["T_PUR_PWR_ALLOC_DMP_UNIT2"],
                T_GEN_PWR_CONSP_REVAMP_UNIT1 = (decimal)reader["T_GEN_PWR_CONSP_REVAMP_UNIT1"],
                T_PUR_PWR_CONSP_SSP = (decimal)reader["T_PUR_PWR_CONSP_SSP"],
                T_IEX_PURCHASED = (decimal)reader["T_IEX_PURCHASED"],
                T_PUR_POWER_TOTAL = (decimal)reader["T_PUR_POWER_TOTAL"],
                T_PUR_PWR_CONST_CFG3 = (decimal)reader["T_PUR_PWR_CONST_CFG3"],
                T_GEN_PWR_EXPORTT_GP3 = (decimal)reader["T_GEN_PWR_EXPORTT_GP3"],
                T_PUR_PWR_EXPORTT_GP3 = (decimal)reader["T_PUR_PWR_EXPORTT_GP3"],
                T_PWR_CONSP_HOUSING_UNIT3 = (decimal)reader["T_PWR_CONSP_HOUSING_UNIT3"],
                T_PWR_CONSP_BLDG_STRTS_UNIT3 = (decimal)reader["T_PWR_CONSP_BLDG_STRTS_UNIT3"],
                T_PWR_ALLOC_GP3_GP1 = (decimal)reader["T_PWR_ALLOC_GP3_GP1"],
                T_PWR_IMPORTF_GT3 = (decimal)reader["T_PWR_IMPORTF_GT3"],
                T_PWR_ALLOC_GP3_GP2 = (decimal)reader["T_PWR_ALLOC_GP3_GP2"],
                T_PRCHSD_PWR_CONSP_GP3 = (decimal)reader["T_PRCHSD_PWR_CONSP_GP3"],
                T_PWR_CONSP_UPHS_UNIT3 = (decimal)reader["T_PWR_CONSP_UPHS_UNIT3"]
            };
        }

        private PTSListModel MapToValueList(SqlDataReader reader)
        {
            return new PTSListModel()
            {
                T_IDENTITY_CODE = (dynamic)reader["T_IDENTITY_CODE"],
                T_IDENTITY_NAME = reader["T_IDENTITY_NAME"].ToString()
            };
        }

        public async Task<PTS006Model> putData(decimal IN_T_YEAR, decimal IN_T_MONTH, decimal IN_T_VERSION
            , char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_TS1_GET_PPT_TS_ELECTRICAL_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_T_YEAR", IN_T_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_MONTH", IN_T_MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_VERSION", IN_T_VERSION));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PTS006Model response = null;
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

        public async Task<List<PTSListModel>> getList()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT T_IDENTITY_CODE,T_IDENTITY_NAME FROM PPIS.PPM_TS2_IDENTITY ORDER BY T_REP_SEQ_NO", sql))
                    {
                        var response = new List<PTSListModel>();
                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                response.Add(MapToValueList(reader));
                            }
                        }
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                List<PTSListModel> result = new List<PTSListModel>();

                PTSListModel data = new PTSListModel();
                data.T_IDENTITY_CODE = 1;
                data.T_IDENTITY_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }

        public async Task saveData(PTS006SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_TS1_SAVE_PPT_TS_ELECTRICAL_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_T_DAY", value.T_DAY));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_YEAR", value.T_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_MONTH", value.T_MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_VERSION", value.T_VERSION));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_USER_ID", value.T_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_AB", value.T_PWR_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_ACT", value.T_PWR_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_AMM", value.T_PWR_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_AMMSTRG", value.T_PWR_CONSP_AMMSTRG));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_UPHS", value.T_PWR_CONSP_UPHS));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_CPP", value.T_PWR_CONSP_CPP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_DMP", value.T_PWR_CONSP_DMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_EDG", value.T_PWR_CONSP_EDG));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_ETP", value.T_PWR_CONSP_ETP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_FIRE", value.T_PWR_CONSP_FIRE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_HOUSING", value.T_PWR_CONSP_HOUSING));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_IAC_SPG", value.T_PWR_CONSP_IAC_SPG));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_KSR", value.T_PWR_CONSP_KSR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_UCT", value.T_PWR_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_UREA", value.T_PWR_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_WPT", value.T_PWR_CONSP_WPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_TFR_NE", value.T_PWR_TFR_NE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_GEN_GT1", value.T_PWR_GEN_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_GEN_GT2", value.T_PWR_GEN_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_PRCHSD", value.T_PWR_PRCHSD));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_RAW_PUMPS", value.T_PWR_RAW_PUMPS));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_SELF_PWR_CONSP_GP2", value.T_SELF_PWR_CONSP_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PRCHSD_PWR_CONSP_GP2", value.T_PRCHSD_PWR_CONSP_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_TOT_PWR_GEN", value.T_TOT_PWR_GEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_SPG_CONSP", value.T_PWR_SPG_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_OFFSITE_CONSP", value.T_PWR_OFFSITE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_LOSS_GEN_PWR", value.T_LOSS_GEN_PWR));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_IAC_OFFSITE", value.T_PWR_CONSP_IAC_OFFSITE));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_U11", value.T_PWR_CONSP_U11));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_U21", value.T_PWR_CONSP_U21));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_TOT_PWR_AVAIL", value.T_TOT_PWR_AVAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_TOT_EBUS_CONSP", value.T_TOT_EBUS_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_TOT_NEBUS_CONSP", value.T_TOT_NEBUS_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_BLDG_STRTS", value.T_PWR_CONSP_BLDG_STRTS));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_ALLOC_IA_GP2", value.T_PWR_ALLOC_IA_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_AMMSTRG_UNIT2", value.T_PWR_CONSP_AMMSTRG_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_UPHS_UNIT2", value.T_PWR_CONSP_UPHS_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_ETP_UNIT2", value.T_PWR_CONSP_ETP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_FIRE_UNIT2", value.T_PWR_CONSP_FIRE_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_CONST_UNIT2", value.T_PWR_CONSP_CONST_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_HOUSING_UNIT2", value.T_PWR_CONSP_HOUSING_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_KSR_UNIT2", value.T_PWR_CONSP_KSR_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_BLDG_STRTS_UNIT2", value.T_PWR_CONSP_BLDG_STRTS_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_RSEB_GPII", value.T_PWR_CONSP_RSEB_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_NAP_STRG", value.T_PWR_CONSP_NAP_STRG));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_NAP_HANDLG_CPP", value.T_PWR_CONSP_NAP_HANDLG_CPP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_NAP_HANDLG_AB", value.T_PWR_CONSP_NAP_HANDLG_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_NAP_HANDLG_AMM", value.T_PWR_CONSP_NAP_HANDLG_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_NAP_STRG_UNIT2", value.T_PWR_CONSP_NAP_STRG_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_DMP_UNIT2", value.T_PWR_CONSP_DMP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_TFR_EBUS", value.T_PWR_TFR_EBUS));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_WPT", value.T_PUR_PWR_CONSP_WPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_WPT_UNIT1", value.T_PUR_PWR_CONSP_WPT_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_WPT_UNIT2", value.T_PUR_PWR_CONSP_WPT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_NEBUS_CONSP_UNIT2", value.T_NEBUS_CONSP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_GEN_PWR_CONSP_KSR_UNIT1", value.T_GEN_PWR_CONSP_KSR_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_GEN_PWR_CONSP_KSR_UNIT2", value.T_GEN_PWR_CONSP_KSR_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_BAGG_UNIT1", value.T_PUR_PWR_CONSP_BAGG_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_BAGG_UNIT2", value.T_PUR_PWR_CONSP_BAGG_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_RW", value.T_PUR_PWR_CONSP_RW));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_DMP", value.T_PUR_PWR_CONSP_DMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_ETP_UNIT1", value.T_PUR_PWR_CONSP_ETP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_ETP_UNIT2", value.T_PUR_PWR_CONSP_ETP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_ACT", value.T_PUR_PWR_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_UCT", value.T_PUR_PWR_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_IAC", value.T_PUR_PWR_CONSP_IAC));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_DMP_UNIT2", value.T_PUR_PWR_CONSP_DMP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_IA_UNIT2", value.T_PUR_PWR_CONSP_IA_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_DMP_UNIT1", value.T_PUR_PWR_CONSP_DMP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_ALLOC_DMP_UNIT2", value.T_PUR_PWR_ALLOC_DMP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_GEN_PWR_CONSP_REVAMP_UNIT1", value.T_GEN_PWR_CONSP_REVAMP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONSP_SSP", value.T_PUR_PWR_CONSP_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_IEX_PURCHASED", value.T_IEX_PURCHASED));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_POWER_TOTAL", value.T_PUR_POWER_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_CONST_CFG3", value.T_PUR_PWR_CONST_CFG3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_GEN_PWR_EXPORTT_GP3", value.T_GEN_PWR_EXPORTT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PUR_PWR_EXPORTT_GP3", value.T_PUR_PWR_EXPORTT_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_HOUSING_UNIT3", value.T_PWR_CONSP_HOUSING_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_BLDG_STRTS_UNIT3", value.T_PWR_CONSP_BLDG_STRTS_UNIT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_ALLOC_GP3_GP1", value.T_PWR_ALLOC_GP3_GP1));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_IMPORTF_GT3", value.T_PWR_IMPORTF_GT3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_ALLOC_GP3_GP2", value.T_PWR_ALLOC_GP3_GP2));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PRCHSD_PWR_CONSP_GP3", value.T_PRCHSD_PWR_CONSP_GP3));
                    cmd.Parameters.Add(new SqlParameter("@IN_T_PWR_CONSP_UPHS_UNIT3", value.T_PWR_CONSP_UPHS_UNIT3));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
