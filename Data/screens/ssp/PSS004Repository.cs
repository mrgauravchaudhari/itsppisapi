using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PSS004Repository
    {
        private readonly string _connectionString;
        public PSS004Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PSS004Model MapToValue(SqlDataReader reader)
        {
            return new PSS004Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                S_TRANS_DATE = reader["S_TRANS_DATE"].ToString(),
                S_DMY_FLG = reader["S_DMY_FLG"].ToString(),
                S_USER_ID = reader["S_USER_ID"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),
                S_DATE_MOD = reader["S_DATE_MOD"].ToString(),
                S_FREEZE_FLG = reader["S_FREEZE_FLG"].ToString(),
                S_BAG_STOCK_PF1_PSSP = (decimal)reader["S_BAG_STOCK_PF1_PSSP"],
                S_BAG_STOCK_PF2_PSSP = (decimal)reader["S_BAG_STOCK_PF2_PSSP"],
                S_BAG_QTY_PSSP = (decimal)reader["S_BAG_QTY_PSSP"],
                S_BAG_DESP_RAIL_PF1_PSSP = (decimal)reader["S_BAG_DESP_RAIL_PF1_PSSP"],
                S_BAG_DESP_RAIL_PF2_PSSP = (decimal)reader["S_BAG_DESP_RAIL_PF2_PSSP"],
                S_BAG_DESP_RAIL_PSSP = (decimal)reader["S_BAG_DESP_RAIL_PSSP"],
                S_BAG_DESP_SSP_ROAD_PSSP = (decimal)reader["S_BAG_DESP_SSP_ROAD_PSSP"],
                S_BAG_DESP_PSSP = (decimal)reader["S_BAG_DESP_PSSP"],
                S_BAG_RET_SSP_PF1_PSSP = (decimal)reader["S_BAG_RET_SSP_PF1_PSSP"],
                S_BAG_RET_SSP_PF2_PSSP = (decimal)reader["S_BAG_RET_SSP_PF2_PSSP"],
                S_BAG_RET_SSP_PSSP = (decimal)reader["S_BAG_RET_SSP_PSSP"],
                S_BAG_CLG_STOCK_PF1_PSSP = (decimal)reader["S_BAG_CLG_STOCK_PF1_PSSP"],
                S_BAG_CLG_STOCK_PF2_PSSP = (decimal)reader["S_BAG_CLG_STOCK_PF2_PSSP"],
                S_BAG_CLG_STOCK_PSSP = (decimal)reader["S_BAG_CLG_STOCK_PSSP"],
                S_BAG_CLG_STOCK_SSP_PSSP = (decimal)reader["S_BAG_CLG_STOCK_SSP_PSSP"],
                S_BAG_GRAND_CLG_STOCK_PSSP = (decimal)reader["S_BAG_GRAND_CLG_STOCK_PSSP"],
                S_BAG_STOCK_PF1_GSSP = (decimal)reader["S_BAG_STOCK_PF1_GSSP"],
                S_BAG_STOCK_PF2_GSSP = (decimal)reader["S_BAG_STOCK_PF2_GSSP"],
                S_BAG_QTY_GSSP = (decimal)reader["S_BAG_QTY_GSSP"],
                S_BAG_DESP_RAIL_PF1_GSSP = (decimal)reader["S_BAG_DESP_RAIL_PF1_GSSP"],
                S_BAG_DESP_RAIL_PF2_GSSP = (decimal)reader["S_BAG_DESP_RAIL_PF2_GSSP"],
                S_BAG_DESP_RAIL_GSSP = (decimal)reader["S_BAG_DESP_RAIL_GSSP"],
                S_BAG_DESP_SSP_ROAD_GSSP = (decimal)reader["S_BAG_DESP_SSP_ROAD_GSSP"],
                S_BAG_DESP_GSSP = (decimal)reader["S_BAG_DESP_GSSP"],
                S_BAG_RET_SSP_PF1_GSSP = (decimal)reader["S_BAG_RET_SSP_PF1_GSSP"],
                S_BAG_RET_SSP_PF2_GSSP = (decimal)reader["S_BAG_RET_SSP_PF2_GSSP"],
                S_BAG_RET_SSP_GSSP = (decimal)reader["S_BAG_RET_SSP_GSSP"],
                S_BAG_CLG_STOCK_PF1_GSSP = (decimal)reader["S_BAG_CLG_STOCK_PF1_GSSP"],
                S_BAG_CLG_STOCK_PF2_GSSP = (decimal)reader["S_BAG_CLG_STOCK_PF2_GSSP"],
                S_BAG_CLG_STOCK_GSSP = (decimal)reader["S_BAG_CLG_STOCK_GSSP"],
                S_BAG_CLG_STOCK_SSP_GSSP = (decimal)reader["S_BAG_CLG_STOCK_SSP_GSSP"],
                S_BAG_GRAND_CLG_STOCK_GSSP = (decimal)reader["S_BAG_GRAND_CLG_STOCK_GSSP"],
                S_BAG_RET_FRM_MKTG_PSSP = (decimal)reader["S_BAG_RET_FRM_MKTG_PSSP"],
                S_BAG_DIRECT_LOAD_RAIL_PSSP = (decimal)reader["S_BAG_DIRECT_LOAD_RAIL_PSSP"],
                S_BAG_STACK_LOAD_RAIL_PSSP = (decimal)reader["S_BAG_STACK_LOAD_RAIL_PSSP"],
                S_BAG_STACK_LOAD_ROAD_PSSP = (decimal)reader["S_BAG_STACK_LOAD_ROAD_PSSP"],
                S_BAG_WAGON_LOAD_PSSP = (decimal)reader["S_BAG_WAGON_LOAD_PSSP"],
                S_BAG_TRUCK_LOAD_PSSP = (decimal)reader["S_BAG_TRUCK_LOAD_PSSP"],
                S_BAG_RET_FRM_MKTG_GSSP = (decimal)reader["S_BAG_RET_FRM_MKTG_GSSP"],
                S_BAG_DIRECT_LOAD_RAIL_GSSP = (decimal)reader["S_BAG_DIRECT_LOAD_RAIL_GSSP"],
                S_BAG_STACK_LOAD_RAIL_GSSP = (decimal)reader["S_BAG_STACK_LOAD_RAIL_GSSP"],
                S_BAG_STACK_LOAD_ROAD_GSSP = (decimal)reader["S_BAG_STACK_LOAD_ROAD_GSSP"],
                S_BAG_WAGON_LOAD_GSSP = (decimal)reader["S_BAG_WAGON_LOAD_GSSP"],
                S_BAG_TRUCK_LOAD_GSSP = (decimal)reader["S_BAG_TRUCK_LOAD_GSSP"],
                S_REMARKS = reader["S_REMARKS"].ToString(),
                S_BAG_DESP_ROAD_PF1_PSSP = (decimal)reader["S_BAG_DESP_ROAD_PF1_PSSP"],
                S_BAG_DESP_ROAD_PF2_PSSP = (decimal)reader["S_BAG_DESP_ROAD_PF2_PSSP"],
                S_BAG_DESP_ROAD_PF1_GSSP = (decimal)reader["S_BAG_DESP_ROAD_PF1_GSSP"],
                S_BAG_DESP_ROAD_PF2_GSSP = (decimal)reader["S_BAG_DESP_ROAD_PF2_GSSP"],
                S_BAG_DESP_ROAD_PSSP = (decimal)reader["S_BAG_DESP_ROAD_PSSP"],
                S_BAG_DESP_ROAD_GSSP = (decimal)reader["S_BAG_DESP_ROAD_GSSP"],
                // DV
                PSSP_PRODUCTION = (decimal)reader["PSSP_PRODUCTION"],
                GSSP_PRODUCTION = (decimal)reader["GSSP_PRODUCTION"],
                S_OPENING_BAL_PSSP_PF1 = (decimal)reader["S_OPENING_BAL_PSSP_PF1"],
                S_OPENING_BAL_PSSP_PF2 = (decimal)reader["S_OPENING_BAL_PSSP_PF2"],
                S_OPENING_BAL_GSSP_PF1 = (decimal)reader["S_OPENING_BAL_GSSP_PF1"],
                S_OPENING_BAL_GSSP_PF2 = (decimal)reader["S_OPENING_BAL_GSSP_PF2"]
            };
        }

        public async Task<PSS004Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_SSP_GET_PPT_SSP_BAGGING", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PSS004Model response = null;
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
