using itsppisapi.Models;
using itsppisapi.SaveDtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PMS212Repository
    {
        private readonly string _connectionString;
        public PMS212Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PMS212Model MapToValue(SqlDataReader reader)
        {
            return new PMS212Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                M_TRANS_DATE = reader["M_TRANS_DATE"].ToString(),
                M_UNIT_ID = reader["M_UNIT_ID"].ToString(),
                M_DATE_MOD = reader["M_DATE_MOD"].ToString(),
                M_USER_ID = (dynamic)reader["M_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                AM_PROD = (dynamic)reader["AM_PROD"],
                DIS_TM_AM_PROD = (dynamic)reader["DIS_TM_AM_PROD"],
                DIS_TY_AM_PROD = (dynamic)reader["DIS_TY_AM_PROD"],
                AM2_PROD = (dynamic)reader["AM2_PROD"],
                DIS_TM_AM2_PROD = (dynamic)reader["DIS_TM_AM2_PROD"],
                DIS_TY_AM2_PROD = (dynamic)reader["DIS_TY_AM2_PROD"],
                DIS_DAY_TOT_AMM_PROD = (dynamic)reader["DIS_DAY_TOT_AMM_PROD"],
                DIS_TM_TOT_AMM_PROD = (dynamic)reader["DIS_TM_TOT_AMM_PROD"],
                DIS_TY_TOT_AMM_PROD = (dynamic)reader["DIS_TY_TOT_AMM_PROD"],
                UR_TOTAL_UREA_PROD = (dynamic)reader["UR_TOTAL_UREA_PROD"],
                DIS_TM_UR_PROD = (dynamic)reader["DIS_TM_UR_PROD"],
                DIS_TY_UR_PROD = (dynamic)reader["DIS_TY_UR_PROD"],
                UR2_TOTAL_UREA_PROD = (dynamic)reader["UR2_TOTAL_UREA_PROD"],
                DIS_TM_UR2_PROD = (dynamic)reader["DIS_TM_UR2_PROD"],
                DIS_TY_UR2_PROD = (dynamic)reader["DIS_TY_UR2_PROD"],
                DIS_DAY_TOT_UR_PROD = (dynamic)reader["DIS_DAY_TOT_UR_PROD"],
                DIS_TM_TOT_UR_PROD = (dynamic)reader["DIS_TM_TOT_UR_PROD"],
                DIS_TY_TOT_UR_PROD = (dynamic)reader["DIS_TY_TOT_UR_PROD"],
                NG_CONSP_SPG = (dynamic)reader["NG_CONSP_SPG"],
                DIS_TM_NG_CONSP_SPG = (dynamic)reader["DIS_TM_NG_CONSP_SPG"],
                DIS_TY_NG_CONSP_SPG = (dynamic)reader["DIS_TY_NG_CONSP_SPG"],
                NG2_CONSP_SPG = (dynamic)reader["NG2_CONSP_SPG"],
                DIS_TM_NG2_CONSP_SPG = (dynamic)reader["DIS_TM_NG2_CONSP_SPG"],
                DIS_TY_NG2_CONSP_SPG = (dynamic)reader["DIS_TY_NG2_CONSP_SPG"],
                DIS_DAY_TOT_NG_CONSP_SPG = (dynamic)reader["DIS_DAY_TOT_NG_CONSP_SPG"],
                DIS_TM_TOT_NG_CONSP_SPG = (dynamic)reader["DIS_TM_TOT_NG_CONSP_SPG"],
                DIS_TY_TOT_NG_CONSP_SPG = (dynamic)reader["DIS_TY_TOT_NG_CONSP_SPG"],
                NG_BAL_CONSP_AMM = (dynamic)reader["NG_BAL_CONSP_AMM"],
                DIS_TM_NG_CONSP_AMM = (dynamic)reader["DIS_TM_NG_CONSP_AMM"],
                DIS_TY_NG_CONSP_AMM = (dynamic)reader["DIS_TY_NG_CONSP_AMM"],
                NG2_CONSP_AMM = (dynamic)reader["NG2_CONSP_AMM"],
                DIS_TM_NG2_CONSP_AMM = (dynamic)reader["DIS_TM_NG2_CONSP_AMM"],
                DIS_TY_NG2_CONSP_AMM = (dynamic)reader["DIS_TY_NG2_CONSP_AMM"],
                DIS_DAY_TOT_NG_CONSP_AMM = (dynamic)reader["DIS_DAY_TOT_NG_CONSP_AMM"],
                DIS_TM_TOT_NG_CONSP_AMM = (dynamic)reader["DIS_TM_TOT_NG_CONSP_AMM"],
                DIS_TY_TOT_NG_CONSP_AMM = (dynamic)reader["DIS_TY_TOT_NG_CONSP_AMM"],
                NAP_CONSP_TOTAL = (dynamic)reader["NAP_CONSP_TOTAL"],
                DIS_TM_NAP_CONSP_TOTAL = (dynamic)reader["DIS_TM_NAP_CONSP_TOTAL"],
                DIS_TY_NAP_CONSP_TOTAL = (dynamic)reader["DIS_TY_NAP_CONSP_TOTAL"],
                NAP2_CONSP_TOTAL = (dynamic)reader["NAP2_CONSP_TOTAL"],
                DIS_TM_NAP2_CONSP_TOTAL = (dynamic)reader["DIS_TM_NAP2_CONSP_TOTAL"],
                DIS_TY_NAP2_CONSP_TOTAL = (dynamic)reader["DIS_TY_NAP2_CONSP_TOTAL"],
                DIS_DAY_TOT_NAP_CONSP_TOTAL = (dynamic)reader["DIS_DAY_TOT_NAP_CONSP_TOTAL"],
                DIS_TM_TOT_NAP_CONSP_TOTAL = (dynamic)reader["DIS_TM_TOT_NAP_CONSP_TOTAL"],
                DIS_TY_TOT_NAP_CONSP_TOTAL = (dynamic)reader["DIS_TY_TOT_NAP_CONSP_TOTAL"],
                AM_SUPP_UREA = (dynamic)reader["AM_SUPP_UREA"],
                DIS_TM_AM_SUPP_UREA = (dynamic)reader["DIS_TM_AM_SUPP_UREA"],
                DIS_TY_AM_SUPP_UREA = (dynamic)reader["DIS_TY_AM_SUPP_UREA"],
                UR2_TOT_AMM_CONSP = (dynamic)reader["UR2_TOT_AMM_CONSP"],
                DIS_TM_UR2_AMM_CONSP = (dynamic)reader["DIS_TM_UR2_AMM_CONSP"],
                DIS_TY_UR2_AMM_CONSP = (dynamic)reader["DIS_TY_UR2_AMM_CONSP"],
                DIS_DAY_TOT_UR_AMM_CONSP = (dynamic)reader["DIS_DAY_TOT_UR_AMM_CONSP"],
                DIS_TM_TOT_UR_AMM_CONSP = (dynamic)reader["DIS_TM_TOT_UR_AMM_CONSP"],
                DIS_TY_TOT_UR_AMM_CONSP = (dynamic)reader["DIS_TY_TOT_UR_AMM_CONSP"],
                BG_DESP_RAIL = (dynamic)reader["BG_DESP_RAIL"],
                DIS_TM_BG_DESP_RAIL = (dynamic)reader["DIS_TM_BG_DESP_RAIL"],
                DIS_TY_BG_DESP_RAIL = (dynamic)reader["DIS_TY_BG_DESP_RAIL"],
                BG2_DESP_RAIL = (dynamic)reader["BG2_DESP_RAIL"],
                DIS_TM_BG2_DESP_RAIL = (dynamic)reader["DIS_TM_BG2_DESP_RAIL"],
                DIS_TY_BG2_DESP_RAIL = (dynamic)reader["DIS_TY_BG2_DESP_RAIL"],
                DIS_DAY_TOT_BG_DESP_RAIL = (dynamic)reader["DIS_DAY_TOT_BG_DESP_RAIL"],
                DIS_TM_TOT_BG_DESP_RAIL = (dynamic)reader["DIS_TM_TOT_BG_DESP_RAIL"],
                DIS_TY_TOT_BG_DESP_RAIL = (dynamic)reader["DIS_TY_TOT_BG_DESP_RAIL"],
                BG_DESP_ROAD = (dynamic)reader["BG_DESP_ROAD"],
                DIS_TM_BG_DESP_ROAD = (dynamic)reader["DIS_TM_BG_DESP_ROAD"],
                DIS_TY_BG_DESP_ROAD = (dynamic)reader["DIS_TY_BG_DESP_ROAD"],
                BG2_DESP_ROAD = (dynamic)reader["BG2_DESP_ROAD"],
                AM_PLANT_LOAD = (dynamic)reader["AM_PLANT_LOAD"],
                AM_SALE = (dynamic)reader["AM_SALE"],
                AM_STOCK = (dynamic)reader["AM_STOCK"],
                NG_ALLOC = (dynamic)reader["NG_ALLOC"],
                NG_RECPT_CFCL = (dynamic)reader["NG_RECPT_CFCL"],
                NG_RECPT_GAIL = (dynamic)reader["NG_RECPT_GAIL"],
                BG_BULK_STOCK = (dynamic)reader["BG_BULK_STOCK"],
                BG_DESP_TOTAL = (dynamic)reader["BG_DESP_TOTAL"],
                BG_TOTAL_BAGG_QTY = (dynamic)reader["BG_TOTAL_BAGG_QTY"],
                NAP_STOCK = (dynamic)reader["NAP_STOCK"],
                UR_UREA_PLANT_LOAD = (dynamic)reader["UR_UREA_PLANT_LOAD"],
                AM2_PLANT_LOAD = (dynamic)reader["AM2_PLANT_LOAD"],
                AM2_SALE = (dynamic)reader["AM2_SALE"],
                AM2_STOCK = (dynamic)reader["AM2_STOCK"],
                UR2_UREA_PLANT_LOAD = (dynamic)reader["UR2_UREA_PLANT_LOAD"],
                NG2_GAIL_RECPT = (dynamic)reader["NG2_GAIL_RECPT"],
                NG2_ALLOC = (dynamic)reader["NG2_ALLOC"],
                NAP2_STOCK = (dynamic)reader["NAP2_STOCK"],
                BG2_BULK_STOCK = (dynamic)reader["BG2_BULK_STOCK"],
                DIS_TM_BG2_DESP_ROAD = (dynamic)reader["DIS_TM_BG2_DESP_ROAD"],
                DIS_TY_BG2_DESP_ROAD = (dynamic)reader["DIS_TY_BG2_DESP_ROAD"],
                DIS_DAY_TOT_BG_DESP_ROAD = (dynamic)reader["DIS_DAY_TOT_BG_DESP_ROAD"],
                DIS_TM_TOT_BG_DESP_ROAD = (dynamic)reader["DIS_TM_TOT_BG_DESP_ROAD"],
                DIS_TY_TOT_BG_DESP_ROAD = (dynamic)reader["DIS_TY_TOT_BG_DESP_ROAD"],
                DIS_TM_BG_DESP_TOTAL = (dynamic)reader["DIS_TM_BG_DESP_TOTAL"],
                DIS_TY_BG_DESP_TOTAL = (dynamic)reader["DIS_TY_BG_DESP_TOTAL"],
                DIS_TM_BG2_DESP_TOTAL = (dynamic)reader["DIS_TM_BG2_DESP_TOTAL"],
                DIS_TY_BG2_DESP_TOTAL = (dynamic)reader["DIS_TY_BG2_DESP_TOTAL"],
                DIS_DAY_TOT_BG_DESP_TOTAL = (dynamic)reader["DIS_DAY_TOT_BG_DESP_TOTAL"],
                DIS_TM_TOT_BG_DESP_TOTAL = (dynamic)reader["DIS_TM_TOT_BG_DESP_TOTAL"],
                DIS_TY_TOT_BG_DESP_TOTAL = (dynamic)reader["DIS_TY_TOT_BG_DESP_TOTAL"],
                DIS_TM_BG_BAGG_QTY = (dynamic)reader["DIS_TM_BG_BAGG_QTY"],
                DIS_TY_BG_BAGG_QTY = (dynamic)reader["DIS_TY_BG_BAGG_QTY"],
                DIS_TM_BG2_BAGG_QTY = (dynamic)reader["DIS_TM_BG2_BAGG_QTY"],
                DIS_TY_BG2_BAGG_QTY = (dynamic)reader["DIS_TY_BG2_BAGG_QTY"],
                DIS_DAY_TOT_BG_BAGG_QTY = (dynamic)reader["DIS_DAY_TOT_BG_BAGG_QTY"],
                DIS_TM_TOT_BG_BAGG_QTY = (dynamic)reader["DIS_TM_TOT_BG_BAGG_QTY"],
                DIS_TY_TOT_BG_BAGG_QTY = (dynamic)reader["DIS_TY_TOT_BG_BAGG_QTY"],
                DIS_TM_AM_SALE = (dynamic)reader["DIS_TM_AM_SALE"],
                DIS_TY_AM_SALE = (dynamic)reader["DIS_TY_AM_SALE"],
                DIS_TM_AM2_SALE = (dynamic)reader["DIS_TM_AM2_SALE"],
                DIS_TY_AM2_SALE = (dynamic)reader["DIS_TY_AM2_SALE"],
                DIS_DAY_TOT_AM_SALE = (dynamic)reader["DIS_DAY_TOT_AM_SALE"],
                DIS_TM_TOT_AM_SALE = (dynamic)reader["DIS_TM_TOT_AM_SALE"],
                DIS_TY_TOT_AM_SALE = (dynamic)reader["DIS_TY_TOT_AM_SALE"],
                DIS_TM_AM_PLANT_LOAD = (dynamic)reader["DIS_TM_AM_PLANT_LOAD"],
                DIS_TY_AM_PLANT_LOAD = (dynamic)reader["DIS_TY_AM_PLANT_LOAD"],
                DIS_TM_AM2_PLANT_LOAD = (dynamic)reader["DIS_TM_AM2_PLANT_LOAD"],
                DIS_TY_AM2_PLANT_LOAD = (dynamic)reader["DIS_TY_AM2_PLANT_LOAD"],
                DIS_DAY_AVE_AM_PLANT_LOAD = (dynamic)reader["DIS_DAY_AVE_AM_PLANT_LOAD"],
                DIS_TM_AVE_AM_PLANT_LOAD = (dynamic)reader["DIS_TM_AVE_AM_PLANT_LOAD"],
                DIS_TY_AVE_AM_PLANT_LOAD = (dynamic)reader["DIS_TY_AVE_AM_PLANT_LOAD"],
                DIS_TM_UR_PLANT_LOAD = (dynamic)reader["DIS_TM_UR_PLANT_LOAD"],
                DIS_TY_UR_PLANT_LOAD = (dynamic)reader["DIS_TY_UR_PLANT_LOAD"],
                DIS_TM_UR2_PLANT_LOAD = (dynamic)reader["DIS_TM_UR2_PLANT_LOAD"],
                DIS_TY_UR2_PLANT_LOAD = (dynamic)reader["DIS_TY_UR2_PLANT_LOAD"],
                DIS_DAY_AVE_UR_PLANT_LOAD = (dynamic)reader["DIS_DAY_AVE_UR_PLANT_LOAD"],
                DIS_TM_AVE_UR_PLANT_LOAD = (dynamic)reader["DIS_TM_AVE_UR_PLANT_LOAD"],
                DIS_TY_AVE_UR_PLANT_LOAD = (dynamic)reader["DIS_TY_AVE_UR_PLANT_LOAD"],
                DIS_TOT_AM_STOCK = (dynamic)reader["DIS_TOT_AM_STOCK"],
                DIS_TOT_BG_BULK_STOCK = (dynamic)reader["DIS_TOT_BG_BULK_STOCK"],
                DIS_TOT_NAP_STOCK = (dynamic)reader["DIS_TOT_NAP_STOCK"],
                BG2_DESP_TOTAL = (dynamic)reader["BG2_DESP_TOTAL"],
                BG2_TOTAL_BAGG_QTY = (dynamic)reader["BG2_TOTAL_BAGG_QTY"],
                M_REMARK = reader["M_REMARK"].ToString(),
                M_REMARK_UNIT2 = reader["M_REMARK_UNIT2"].ToString(),
                M_REMARK_SSP = reader["M_REMARK_SSP"].ToString(),
                M_C_REMARKS = reader["M_C_REMARKS"].ToString(),
                M_C_REMARKS_UNIT2 = reader["M_C_REMARKS_UNIT2"].ToString(),

            };
        }

        public async Task<PMS212Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_MG_GET_PPT_MG_GMMVPO_REMARKS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PMS212Model response = null;
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

        public async Task saveData(PMS212SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_MG_SAVE_PPT_MG_GMMVPO_REMARKS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_M_TRANS_DATE", value.M_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_UNIT_ID", value.M_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_USER_ID", value.M_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_REMARK", value.M_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_REMARK_UNIT2", value.M_REMARK_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_REMARK_SSP", value.M_REMARK_SSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_C_REMARKS", value.M_C_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_M_C_REMARKS_UNIT2", value.M_C_REMARKS_UNIT2));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}