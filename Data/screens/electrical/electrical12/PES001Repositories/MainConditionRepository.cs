using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Models;
using System.Collections.Generic;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
  public class MainConditionRepository
  {
    private readonly string _connectionString;
    public MainConditionRepository(IConfiguration configuration)
    {
      _connectionString = configuration.GetConnectionString("DBConnection");
    }

    private MainConditionModel MapToValue(SqlDataReader reader)
    {
      return new MainConditionModel()
      {
        //MINDT = reader["MINDT"].ToString(),
        //MAXDT = reader["MAXDT"].ToString(),
        E_COND_ID = (decimal)reader["E_COND_ID"],
        E_COND_TYPE = reader["E_COND_TYPE"].ToString(),
        E_COND = reader["E_COND"].ToString(),
        E_DATE_MOD = reader["E_DATE_MOD"].ToString(),
        E_USER_ID = reader["E_USER_ID"].ToString()
      };
    }

    public async Task<List<MainConditionModel>> getData()
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_MAIN_CONDITION", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //cmd.Parameters.Add(new SqlParameter("@L_REPORT_ID", L_REPORT_ID));
          var response = new List<MainConditionModel>();
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

    public async Task saveData(MainConditionDto value)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_SAVE_PPM_EL_MAIN_CONDITION", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_E_COND_ID", value.E_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E_COND_TYPE", value.E_COND_TYPE));
          cmd.Parameters.Add(new SqlParameter("@IN_E_COND", value.E_COND));
          cmd.Parameters.Add(new SqlParameter("@IN_E_USER_ID", value.E_USER_ID));
          await sql.OpenAsync();
          await cmd.ExecuteNonQueryAsync();
          return;
        }
      }
    }

  }
}
