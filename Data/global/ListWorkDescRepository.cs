using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ListWorkDescRepository
    {
        private readonly string _connectionString;
        public ListWorkDescRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListWorkDescModel MapToValue(SqlDataReader reader)
        {
            return new ListWorkDescModel()
            {
                B_WORK_DESC = reader["B_WORK_DESC"].ToString(),
            };
        }

        public async Task<List<ListWorkDescModel>> putData(ListWorkDescDto value)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select DISTINCT B_WORK_DESC, B_WORK_CODE, B_UOM, B_PRINT_SEQ from PPIS.PPM_BG_WORK where B_CONTR_CODE = '" + value.B_CONTR_CODE + "' and B_UNIT_ID = '" + value.B_UNIT_ID + "' and B_LOADING_TYPE = 'G' and B_ACTIVE_FLG = 'A' order by B_PRINT_SEQ", sql))
                    {
                        var response = new List<ListWorkDescModel>();
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
                List<ListWorkDescModel> result = new List<ListWorkDescModel>();
                ListWorkDescModel data = new ListWorkDescModel();
                data.B_WORK_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
