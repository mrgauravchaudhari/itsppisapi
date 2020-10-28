using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class BagDltsRepository
    {
        private readonly string _connectionString;
        public BagDltsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private BagDlts MapToValue(SqlDataReader reader)
        {
            return new BagDlts()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_USER_NAME = reader["B_USER_NAME"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),

                B_NC_DESP_RAIL = (decimal)reader["B_NC_DESP_RAIL"],
                B_DESP_RAIL = (decimal)reader["B_DESP_RAIL"],
                B_NC_DESP_ROAD = (decimal)reader["B_NC_DESP_ROAD"],
                B_DESP_ROAD = (decimal)reader["B_DESP_ROAD"],
                B_NC_DESP_TOTAL = (decimal)reader["B_NC_DESP_TOTAL"],
                B_DESP_TOTAL = (decimal)reader["B_DESP_TOTAL"],
                B_NC_BAGG_QTY = (decimal)reader["B_NC_BAGG_QTY"],
                B_TOTAL_BAGG_QTY = (decimal)reader["B_TOTAL_BAGG_QTY"],
                B_TOTAL_BAGG_STOCK = (decimal)reader["B_TOTAL_BAGG_STOCK"],
                B_NC_TRUCK_LOAD = (decimal)reader["B_NC_TRUCK_LOAD"],
                B_NO_TRUCK_LOAD = (decimal)reader["B_NO_TRUCK_LOAD"],
                B_DIRECT_LDG_QTY_PF1 = (decimal)reader["B_DIRECT_LDG_QTY_PF1"],
                B_DIRECT_LDG_QTY = (decimal)reader["B_DIRECT_LDG_QTY"],
                B_STACK_LDG_QTY_PF1 = (decimal)reader["B_STACK_LDG_QTY_PF1"],
                B_STACK_LDG_QTY = (decimal)reader["B_STACK_LDG_QTY"],

                B_RET_FRM_DISPATCH = (decimal)reader["B_RET_FRM_DISPATCH"],
                B_UREA_RECD_MKTG = (decimal)reader["B_UREA_RECD_MKTG"],
                B_TOTAL_STOCK = (decimal)reader["B_TOTAL_STOCK"],
                B_NO_OPEN_RAKES = (decimal)reader["B_NO_OPEN_RAKES"],
                B_NO_CLOSE_RAKES = (decimal)reader["B_NO_CLOSE_RAKES"],
                B_NO_TOTAL_RAKES = (decimal)reader["B_NO_TOTAL_RAKES"],
                B_ECA_QTY = (decimal)reader["B_ECA_QTY"],
                B_NC_ECA_QTY = (decimal)reader["B_NC_ECA_QTY"],
                B_NONECA_QTY = (decimal)reader["B_NONECA_QTY"],
                B_NC_NONECA_QTY = (decimal)reader["B_NC_NONECA_QTY"],
                B_BULK_STOCK = (decimal)reader["B_BULK_STOCK"],
                B_NC_BAGG_STOCK = (decimal)reader["B_NC_BAGG_STOCK"],
                B_NC_INPROCESS_QTY = (decimal)reader["B_NC_INPROCESS_QTY"],

                B_DESP_RAIL_PF2 = (decimal)reader["B_DESP_RAIL_PF2"],
                B_DESP_RAIL_PF1 = (decimal)reader["B_DESP_RAIL_PF1"],
                B_DESP_ROAD_PF1 = (decimal)reader["B_DESP_ROAD_PF1"],
                B_DESP_ROAD_PF2 = (decimal)reader["B_DESP_ROAD_PF2"],
                B_DESP_TOTAL_PF1 = (decimal)reader["B_DESP_TOTAL_PF1"],
                B_DESP_TOTAL_PF2 = (decimal)reader["B_DESP_TOTAL_PF2"],
                B_TOTAL_BAGG_QTY_PF1 = (decimal)reader["B_TOTAL_BAGG_QTY_PF1"],
                B_TOTAL_BAGG_QTY_PF2 = (decimal)reader["B_TOTAL_BAGG_QTY_PF2"],
                B_TOTAL_BAGG_STOCK_PF1 = (decimal)reader["B_TOTAL_BAGG_STOCK_PF1"],
                B_TOTAL_BAGG_STOCK_PF2 = (decimal)reader["B_TOTAL_BAGG_STOCK_PF2"],
                B_NO_TRUCK_LOAD_PF1 = (decimal)reader["B_NO_TRUCK_LOAD_PF1"],
                B_NO_TRUCK_LOAD_PF2 = (decimal)reader["B_NO_TRUCK_LOAD_PF2"],

                B_REMARKS_D = reader["B_REMARKS_D"].ToString(),
                B_REMARKS_M = reader["B_REMARKS_M"].ToString(),
                parm_b_bulk_stock = (decimal)reader["parm_b_bulk_stock"],
                parm_b_nc_bagg_stock = (decimal)reader["parm_b_nc_bagg_stock"],
                parm_b_nc_inprocess_qty = (decimal)reader["parm_b_nc_inprocess_qty"],
            };
        }
        public async Task<BagDlts> putData(threeParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_BAGG_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    BagDlts response = null;
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

        public async Task saveData(BagDltsSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_BAGG_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_DESP_RAIL", value.B_NC_DESP_RAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_RAIL", value.B_DESP_RAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_DESP_ROAD", value.B_NC_DESP_ROAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_ROAD", value.B_DESP_ROAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_DESP_TOTAL", value.B_NC_DESP_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_TOTAL", value.B_DESP_TOTAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_BAGG_QTY", value.B_NC_BAGG_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_BAGG_QTY", value.B_TOTAL_BAGG_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_BAGG_STOCK", value.B_NC_BAGG_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_BAGG_STOCK", value.B_TOTAL_BAGG_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_TRUCK_LOAD", value.B_NC_TRUCK_LOAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_TRUCK_LOAD", value.B_NO_TRUCK_LOAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DIRECT_LDG_QTY_PF1", value.B_DIRECT_LDG_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DIRECT_LDG_QTY", value.B_DIRECT_LDG_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_STACK_LDG_QTY_PF1", value.B_STACK_LDG_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_STACK_LDG_QTY", value.B_STACK_LDG_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RET_FRM_DISPATCH", value.B_RET_FRM_DISPATCH));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UREA_RECD_MKTG", value.B_UREA_RECD_MKTG));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BULK_STOCK", value.B_BULK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_STOCK", value.B_TOTAL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_INPROCESS_QTY", value.B_NC_INPROCESS_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_OPEN_RAKES", value.B_NO_OPEN_RAKES));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_CLOSE_RAKES", value.B_NO_CLOSE_RAKES));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_TOTAL_RAKES", value.B_NO_TOTAL_RAKES));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_ECA_QTY", value.B_ECA_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_ECA_QTY", value.B_NC_ECA_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NONECA_QTY", value.B_NONECA_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NC_NONECA_QTY", value.B_NC_NONECA_QTY));

                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_RAIL_PF2", value.B_DESP_RAIL_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_RAIL_PF1", value.B_DESP_RAIL_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_ROAD_PF1", value.B_DESP_ROAD_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_ROAD_PF2", value.B_DESP_ROAD_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_TOTAL_PF1", value.B_DESP_TOTAL_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DESP_TOTAL_PF2", value.B_DESP_TOTAL_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_BAGG_QTY_PF1", value.B_TOTAL_BAGG_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_BAGG_QTY_PF2", value.B_TOTAL_BAGG_QTY_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_BAGG_STOCK_PF1", value.B_TOTAL_BAGG_STOCK_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TOTAL_BAGG_STOCK_PF2", value.B_TOTAL_BAGG_STOCK_PF2));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_TRUCK_LOAD_PF1", value.B_NO_TRUCK_LOAD_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_TRUCK_LOAD_PF2", value.B_NO_TRUCK_LOAD_PF2));

                    cmd.Parameters.Add(new SqlParameter("@IN_B_REMARKS_D", value.B_REMARKS_D));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_REMARKS_M", value.B_REMARKS_M));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}