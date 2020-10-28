using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class TripMasterRepository
    {
        private readonly string _connectionString;
        public TripMasterRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private TripMasterModel MapToValue(SqlDataReader reader)
        {
            return new TripMasterModel()
            {
                TRIP_TYPE_ID = (decimal)reader["TRIP_TYPE_ID"],
                TRIP_TYPE_NAME = reader["TRIP_TYPE_NAME"].ToString(),
                TRIP_TYPE_DESC = reader["TRIP_TYPE_DESC"].ToString(),
                DATE_MOD = reader["DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<TripMasterModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPM_GL_TRIP_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<TripMasterModel>();
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

        public async Task saveData(TripMasterDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPM_GL_TRIP_TYPE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_TRIP_TYPE_ID", value.TRIP_TYPE_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_TRIP_TYPE_NAME", value.TRIP_TYPE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_TRIP_TYPE_DESC", value.TRIP_TYPE_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
