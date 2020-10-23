using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class ListBreakDownRepository
    {
        private readonly string _connectionString;
        public ListBreakDownRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListBreakDownModel MapToValue(SqlDataReader reader)
        {
            return new ListBreakDownModel()
            {
                BRKDWN_ID = (decimal)reader["BRKDWN_ID"],
                BRKDWN_DESC = reader["BRKDWN_DESC"].ToString(),
            };
        }

        public async Task<List<ListBreakDownModel>> putData(BreakDownParamDto value)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Select BRKDWN_DESC, BRKDWN_ID From PPIS.PPM_GL_BREAKDOWN where BRKDWN_ID not in(select EXCLUDE_TYPE_ID from PPIS.PPT_GL_MST_EXCLUDE_TYPE_ID where EXCLUDE_TYPE = 'Cause of Breakdown' and EXCLUDE_UNIT_ID = '" + value.EXCLUDE_UNIT_ID + "')", sql))
                    {
                        var response = new List<ListBreakDownModel>();
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
            catch (Exception ex)
            {
                List<ListBreakDownModel> result = new List<ListBreakDownModel>();
                ListBreakDownModel data = new ListBreakDownModel();
                data.BRKDWN_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
