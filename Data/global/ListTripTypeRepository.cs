using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ListTripTypeRepository
    {
        private readonly string _connectionString;
        public ListTripTypeRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ListTripTypeModel MapToValue(SqlDataReader reader)
        {
            return new ListTripTypeModel()
            {
                TRIP_TYPE_ID = (decimal)reader["TRIP_TYPE_ID"],
                TRIP_TYPE_DESC = reader["TRIP_TYPE_DESC"].ToString(),
            };
        }

        public async Task<List<ListTripTypeModel>> putData(TripTypeParamDto value)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TRIP_TYPE_DESC, TRIP_TYPE_ID FROM PPIS.PPM_GL_TRIP_TYPE WHERE TRIP_TYPE_ID NOT IN (SELECT EXCLUDE_TYPE_ID FROM PPIS.PPT_GL_MST_EXCLUDE_TYPE_ID WHERE EXCLUDE_TYPE = 'Cause of Tripping' AND EXCLUDE_UNIT_ID = '" + value.EXCLUDE_UNIT_ID + "')", sql))
                    {
                        var response = new List<ListTripTypeModel>();
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
                List<ListTripTypeModel> result = new List<ListTripTypeModel>();
                ListTripTypeModel data = new ListTripTypeModel();
                data.TRIP_TYPE_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }
    }
}
