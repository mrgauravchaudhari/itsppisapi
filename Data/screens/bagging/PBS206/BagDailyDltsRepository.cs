using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class BagDailyDltsRepository
    {
        private readonly string _connectionString;
        public BagDailyDltsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private BagDailyDlts MapToValue(SqlDataReader reader)
        {
            return new BagDailyDlts()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),

                B_BAGG_QTY_PF1 = (decimal)reader["B_BAGG_QTY_PF1"],
                B_BAGG_QTY_PF2 = (decimal)reader["B_BAGG_QTY_PF2"],
                B_BAGG_QTY = (decimal)reader["B_BAGG_QTY"],
                B_BAG_DESP_RAIL_PF1 = (decimal)reader["B_BAG_DESP_RAIL_PF1"],
                B_BAG_DESP_RAIL_PF2 = (decimal)reader["B_BAG_DESP_RAIL_PF2"],
                B_BAG_DESP_RAIL = (decimal)reader["B_BAG_DESP_RAIL"],
                B_BAG_DESP_ROAD_PF1 = (decimal)reader["B_BAG_DESP_ROAD_PF1"],
                B_BAG_DESP_ROAD_PF2 = (decimal)reader["B_BAG_DESP_ROAD_PF2"],
                B_BAG_DESP_ROAD = (decimal)reader["B_BAG_DESP_ROAD"],
                B_BAGG_STOCK_PF1 = (decimal)reader["B_BAGG_STOCK_PF1"],
                B_BAGG_STOCK_PF2 = (decimal)reader["B_BAGG_STOCK_PF2"],
                B_BAGG_STOCK = (decimal)reader["B_BAGG_STOCK"],
                B_BAG_DAMAGED = (decimal)reader["B_BAG_DAMAGED"],
                B_BAG_RUPTURES = (decimal)reader["B_BAG_RUPTURES"],
                B_EMPTY_BAG_RECD = (decimal)reader["B_EMPTY_BAG_RECD"],
                B_EMPTY_BAG_MARKT = (decimal)reader["B_EMPTY_BAG_MARKT"],
                B_EMPTY_BAG_TESTING = (decimal)reader["B_EMPTY_BAG_TESTING"],
                B_EMPTY_BAG_STND = (decimal)reader["B_EMPTY_BAG_STND"],
                B_EMPTY_BAG_STOCK_ADJ = (decimal)reader["B_EMPTY_BAG_STOCK_ADJ"],
                B_EMPTY_BAG_CONSP = (decimal)reader["B_EMPTY_BAG_CONSP"],
                B_EMPTY_BAG_STOCK = (decimal)reader["B_EMPTY_BAG_STOCK"],

                B_BAG_TYPE_ID = (decimal)reader["B_BAG_TYPE_ID"],
                TXT_BAG_TYPE = reader["TXT_BAG_TYPE"].ToString(),
                TXT_BAG_SIZE = (decimal)reader["TXT_BAG_SIZE"],

                TXT_UREA_PROD = (decimal)reader["TXT_UREA_PROD"],
                parm_empty_bag_stk = (decimal)reader["parm_empty_bag_stk"],
                parm_bag_stock = (decimal)reader["parm_bag_stock"],
                parm_bag_stock_pf1 = (decimal)reader["parm_bag_stock_pf1"],
                parm_bag_stock_pf2 = (decimal)reader["parm_bag_stock_pf2"],
                PF1_STOCK_ADJST_CONST = (decimal)reader["PF1_STOCK_ADJST_CONST"],
                PF2_STOCK_ADJST_CONST = (decimal)reader["PF2_STOCK_ADJST_CONST"],
                STOCK_ADJST_CONST = (decimal)reader["STOCK_ADJST_CONST"]
            };
        }
        public async Task<List<BagDailyDlts>> putData(threeParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_BAG_DAILY_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<BagDailyDlts>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }
                    return response;
                }
            }
        }

        private BagTypeNSize MapToValue2(SqlDataReader reader)
        {
            return new BagTypeNSize()
            {
                B_BAG_SIZE = reader["B_BAG_SIZE"].ToString(),
                B_BAG_TYPE = reader["B_BAG_TYPE"].ToString(),
            };
        }
        public async Task<List<BagTypeNSize>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT B_BAG_TYPE, B_BAG_SIZE FROM PPIS.PPM_BG_BAG_TYPE where B_BAG_ACTIVE_FLAG = 'Y'", sql))
                {
                    var response = new List<BagTypeNSize>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue2(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(BagDailyDltsSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_BAG_DAILY_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_TYPE", value.TXT_BAG_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_SIZE", value.TXT_BAG_SIZE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_QTY", value.B_BAGG_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_STOCK", value.B_BAGG_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DAMAGED", value.B_BAG_DAMAGED));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESP_RAIL", value.B_BAG_DESP_RAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESP_ROAD", value.B_BAG_DESP_ROAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_RUPTURES", value.B_BAG_RUPTURES));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_CONSP", value.B_EMPTY_BAG_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_RECD", value.B_EMPTY_BAG_RECD));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_STOCK", value.B_EMPTY_BAG_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_MARKT", value.B_EMPTY_BAG_MARKT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_STND", value.B_EMPTY_BAG_STND));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_TESTING", value.B_EMPTY_BAG_TESTING));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_QTY_PF1", value.B_BAGG_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_QTY_PF2", value.B_BAGG_QTY_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_STOCK_PF1", value.B_BAGG_STOCK_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_STOCK_PF2", value.B_BAGG_STOCK_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESP_RAIL_PF1", value.B_BAG_DESP_RAIL_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESP_RAIL_PF2", value.B_BAG_DESP_RAIL_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESP_ROAD_PF1", value.B_BAG_DESP_ROAD_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAG_DESP_ROAD_PF2", value.B_BAG_DESP_ROAD_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_EMPTY_BAG_STOCK_ADJ", value.B_EMPTY_BAG_STOCK_ADJ));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
