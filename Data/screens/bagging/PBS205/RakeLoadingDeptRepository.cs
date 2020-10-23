using Microsoft.Extensions.Configuration;
using itsppisapi.Dtos;
using itsppisapi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace itsppisapi.Data
{
    public class RakeLoadingDeptRepository
    {
        private readonly string _connectionString;
        public RakeLoadingDeptRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private RakeLoadingDept MapToValue(SqlDataReader reader)
        {
            return new RakeLoadingDept()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString(),
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),

                B_RAKE_NO = reader["B_RAKE_NO"].ToString(),
                B_RAKE_DESTINATION = reader["B_RAKE_DESTINATION"].ToString(),
                B_PLACEMENT_DATE = reader["B_PLACEMENT_DATE"].ToString(),
                B_RAKE_DUE_COMPL_DATE = reader["B_RAKE_DUE_COMPL_DATE"].ToString(),
                B_COMPLETION_DATE = reader["B_COMPLETION_DATE"].ToString(),
                B_ACT_TIME_TAKEN = (decimal)reader["B_ACT_TIME_TAKEN"],
                B_FORFEIT_WGN = (decimal)reader["B_FORFEIT_WGN"],
                B_NO_REJECTED_WAGONS = (dynamic)reader["B_NO_REJECTED_WAGONS"],
                B_TIME_PLACE_TO_PLACE = (decimal)reader["B_TIME_PLACE_TO_PLACE"],
                B_WAGON_TYPE = reader["B_WAGON_TYPE"].ToString(),
                B_RAKE_PLANNING_TIME = reader["B_RAKE_PLANNING_TIME"].ToString(),
                B_TIME_COMP_TO_PLACE = (decimal)reader["B_TIME_COMP_TO_PLACE"],
                B_NO_JUTE_WAGONS_PF1 = (dynamic)reader["B_NO_JUTE_WAGONS_PF1"],
                B_NO_JUTE_WAGONS = (dynamic)reader["B_NO_JUTE_WAGONS"],
                B_JUTE_QTY_PF1 = (dynamic)reader["B_JUTE_QTY_PF1"],
                B_JUTE_QTY = (dynamic)reader["B_JUTE_QTY"],
                B_HDPE_QTY_PF1 = (dynamic)reader["B_HDPE_QTY_PF1"],
                B_HDPE_QTY = (dynamic)reader["B_HDPE_QTY"],
                B_QTY_LOADED_PF1 = (decimal)reader["B_QTY_LOADED_PF1"],
                B_QTY_LOADED = (decimal)reader["B_QTY_LOADED"],
                B_DEMG_HRS_PF1 = (decimal)reader["B_DEMG_HRS_PF1"],
                B_DEMG_HRS = (dynamic)reader["B_DEMG_HRS"],
                B_CFCL_DEMG_HRS_PF1 = (decimal)reader["B_CFCL_DEMG_HRS_PF1"],
                B_CFCL_DEMG_HRS = (decimal)reader["B_CFCL_DEMG_HRS"],
                B_DEMG_AMT_PF1 = (decimal)reader["B_DEMG_AMT_PF1"],
                B_DEMG_AMT = (decimal)reader["B_DEMG_AMT"],
                B_CFCL_DEMG_AMT_PF1 = (decimal)reader["B_CFCL_DEMG_AMT_PF1"],
                B_CFCL_DEMG_AMT = (decimal)reader["B_CFCL_DEMG_AMT"],
                B_WAIVER_PERCENT_PF1 = (decimal)reader["B_WAIVER_PERCENT_PF1"],
                B_WAIVER_PERCENT = (decimal)reader["B_WAIVER_PERCENT"],
                B_DEMG_REMARK = reader["B_DEMG_REMARK"].ToString(),
            };
        }
        public async Task<List<RakeLoadingDept>> putData(threeParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_RAKE_LOADING_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<RakeLoadingDept>();
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

        public async Task saveData(RakeLoadingDeptSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_RAKE_LOADING_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_NO", value.B_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_COMPLETION_DATE", value.B_COMPLETION_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_HDPE_QTY", value.B_HDPE_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_JUTE_QTY", value.B_JUTE_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_JUTE_WAGONS", value.B_NO_JUTE_WAGONS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_HRS", value.B_DEMG_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_PLACEMENT_DATE", value.B_PLACEMENT_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_DESTINATION", value.B_RAKE_DESTINATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_REJECTED_WAGONS", value.B_NO_REJECTED_WAGONS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_AMT", value.B_DEMG_AMT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAIVER_PERCENT", value.B_WAIVER_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CFCL_DEMG_AMT", value.B_CFCL_DEMG_AMT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_QTY_LOADED", value.B_QTY_LOADED));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_REMARK", value.B_DEMG_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CFCL_DEMG_HRS", value.B_CFCL_DEMG_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_FORFEIT_WGN", value.B_FORFEIT_WGN));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_HDPE_QTY_PF1", value.B_HDPE_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_JUTE_QTY_PF1", value.B_JUTE_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_NO_JUTE_WAGONS_PF1", value.B_NO_JUTE_WAGONS_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_HRS_PF1", value.B_DEMG_HRS_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_AMT_PF1", value.B_DEMG_AMT_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAIVER_PERCENT_PF1", value.B_WAIVER_PERCENT_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CFCL_DEMG_AMT_PF1", value.B_CFCL_DEMG_AMT_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_QTY_LOADED_PF1", value.B_QTY_LOADED_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CFCL_DEMG_HRS_PF1", value.B_CFCL_DEMG_HRS_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WAGON_TYPE", value.B_WAGON_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_PLANNING_TIME", value.B_RAKE_PLANNING_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_DUE_COMPL_DATE", value.B_RAKE_DUE_COMPL_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_ACT_TIME_TAKEN", value.B_ACT_TIME_TAKEN));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TIME_COMP_TO_PLACE", value.B_TIME_COMP_TO_PLACE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TIME_PLACE_TO_PLACE", value.B_TIME_PLACE_TO_PLACE));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}