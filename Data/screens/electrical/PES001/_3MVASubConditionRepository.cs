using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class _3MVASubConditionRepository
    {
        private readonly string _connectionString;
        public _3MVASubConditionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private _3MVASubConditionModel MapToValue(SqlDataReader reader)
        {
            return new _3MVASubConditionModel()
            {
                E_COND_ID = (decimal)reader["E_COND_ID"],
                E_SUB_COND_ID = (decimal)reader["E_SUB_COND_ID"],
                E_SUB_COND_DESC = reader["E_SUB_COND_DESC"].ToString(),
                E_ACT_PERCENT = (decimal)reader["E_ACT_PERCENT"],
                E_UCT_PERCENT = (decimal)reader["E_UCT_PERCENT"],
                E_WPT_PERCENT = (decimal)reader["E_WPT_PERCENT"],
                E_DM_PERCENT = (decimal)reader["E_DM_PERCENT"],
                E_IAC_PERCENT = (decimal)reader["E_IAC_PERCENT"],
                E_ETP_PERCENT = (decimal)reader["E_ETP_PERCENT"],
                E_DATE_MOD = reader["E_DATE_MOD"].ToString(),
                E_USER_ID = reader["E_USER_ID"].ToString()
            };
        }
        private _3MVASubConditionModel MapToValueCondList(SqlDataReader reader) => new _3MVASubConditionModel()
        {
            E_COND_ID = (decimal)reader["E_COND_ID"],
            E_COND = reader["E_COND"].ToString()
        };

        private _3MVASubConditionModel MapToValueSubCondList(SqlDataReader reader) => new _3MVASubConditionModel()
        {
            E_COND_ID = (decimal)reader["E_COND_ID"],
            E_SUB_COND_ID = (decimal)reader["E_SUB_COND_ID"],
            E_SUB_COND_DESC = reader["E_SUB_COND_DESC"].ToString()
        };

        public async Task<List<_3MVASubConditionModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_3MVA_CONDITION", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<_3MVASubConditionModel>();
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

        public async Task<List<_3MVASubConditionModel>> getCondList()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_3MVA_CONDITION_DSP_E_COND_3MVA", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<_3MVASubConditionModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueCondList(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(_3MVASubConditionDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_SAVE_PPM_EL_3MVA_CONDITION", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_E_COND_ID", value.E_COND_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_SUB_COND_ID", value.E_SUB_COND_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_FS_PERCENT", value.E_FS_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_SUB_COND_DESC", value.E_SUB_COND_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_ACT_PERCENT", value.E_ACT_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_UCT_PERCENT", value.E_UCT_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_WPT_PERCENT", value.E_WPT_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_DM_PERCENT", value.E_DM_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_ETP_PERCENT", value.E_ETP_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_IAC_PERCENT", value.E_IAC_PERCENT));
                    cmd.Parameters.Add(new SqlParameter("@IN_E_USER_ID", value.E_USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        public async Task<List<_3MVASubConditionModel>> getSubCondList()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_3MVA_CONDITION_DSP_E_SUB_COND_3MVA", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<_3MVASubConditionModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueSubCondList(reader));
                        }
                    }
                    return response;
                }
            }
        }
    }
}
