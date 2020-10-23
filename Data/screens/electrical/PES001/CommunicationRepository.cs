using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
  public class CommunicationRepository
  {
    private readonly string _connectionString;
    public CommunicationRepository(IConfiguration configuration)
    {
      _connectionString = configuration.GetConnectionString("DBConnection");
    }

    private CommunicationModel MapToValue(SqlDataReader reader)
    {
      return new CommunicationModel()
      {
        E_COMM_ID = (decimal)reader["E_COMM_ID"],
        E_COMM_NAME = reader["E_COMM_NAME"].ToString(),
        E_COMM_REMARK = reader["E_COMM_REMARK"].ToString(),
        E_STATUS = reader["E_STATUS"].ToString(),
        E_DATE_MOD = reader["E_DATE_MOD"].ToString(),
        E_USER_ID = reader["E_USER_ID"].ToString()
      };
    }

    public async Task<List<CommunicationModel>> getData()
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_COMMUNICATION", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
          var response = new List<CommunicationModel > ();
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

    public async Task saveData(CommunicationDto value)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_SAVE_PPM_EL_COMMUNICATION", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_E_COMM_ID", value.E_COMM_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E_COMM_NAME", value.E_COMM_NAME));
          cmd.Parameters.Add(new SqlParameter("@IN_E_USER_ID", value.E_USER_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E_COMM_REMARK", value.E_COMM_REMARK));
          cmd.Parameters.Add(new SqlParameter("@IN_E_STATUS", value.E_STATUS));  
          await sql.OpenAsync();
          await cmd.ExecuteNonQueryAsync();
          return;
        }
      }
    }

  }
}
