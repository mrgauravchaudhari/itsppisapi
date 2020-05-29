using Microsoft.Extensions.Configuration;
using itsppisapi.Dtos;
using itsppisapi.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
  public class SPGSubConditionRepository
  {
    private readonly string _connectionString;
    public SPGSubConditionRepository(IConfiguration configuration)
    {
      _connectionString = configuration.GetConnectionString("DBConnection");
    }

    private SPGSubConditionModel MapToValue(SqlDataReader reader)
    {
      return new SPGSubConditionModel()
      {
        E_COND_ID = (decimal)reader["E_COND_ID"],
        E_SUB_COND_ID = (decimal)reader["E_SUB_COND_ID"],
        E_SUB_COND_DESC = reader["E_SUB_COND_DESC"].ToString(),
        E_CPP_PERCENT = (decimal)reader["E_CPP_PERCENT"],
        E_IAC_PERCENT = (decimal)reader["E_IAC_PERCENT"],
        E_AB_PERCENT = (decimal)reader["E_AB_PERCENT"],
        E_DATE_MOD = reader["E_DATE_MOD"].ToString(),
        E_USER_ID = reader["E_USER_ID"].ToString()
      };
    }

    private SPGSubConditionModel MapToValueCondList(SqlDataReader reader) => new SPGSubConditionModel()
    {
      E_COND_ID = (decimal)reader["E_COND_ID"],
      E_COND = reader["E_COND"].ToString()
    };

    private SPGSubConditionModel MapToValueSubCondList(SqlDataReader reader) => new SPGSubConditionModel()
    {
      E_COND_ID = (decimal)reader["E_COND_ID"],
      E_SUB_COND_ID = (decimal)reader["E_SUB_COND_ID"],
      E_SUB_COND_DESC = reader["E_SUB_COND_DESC"].ToString()
    };

    public async Task<List<SPGSubConditionModel>> getData()
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_SPG_CONDITION", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
          var response = new List<SPGSubConditionModel > ();
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

    public async Task<List<SPGSubConditionModel>> getCondList()
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_SPG_CONDITION_DSP_E_COND", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
          var response = new List<SPGSubConditionModel>();
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

    public async Task saveData(SPGSubConditionDto value)
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_SAVE_PPM_EL_SPG_CONDITION", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          cmd.Parameters.Add(new SqlParameter("@IN_E_COND_ID", value.E_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E_SUB_COND_ID", value.E_SUB_COND_ID));
          cmd.Parameters.Add(new SqlParameter("@IN_E_SUB_COND_DESC", value.E_SUB_COND_DESC));
          cmd.Parameters.Add(new SqlParameter("@IN_E_AB_PERCENT", value.E_AB_PERCENT));
          cmd.Parameters.Add(new SqlParameter("@IN_E_CPP_PERCENT", value.E_CPP_PERCENT));
          cmd.Parameters.Add(new SqlParameter("@IN_E_IAC_PERCENT", value.E_IAC_PERCENT));
          cmd.Parameters.Add(new SqlParameter("@IN_E_USER_ID", value.E_USER_ID));
          await sql.OpenAsync();
          await cmd.ExecuteNonQueryAsync();
          return;
        }
      }
    }
      public async Task<List<SPGSubConditionModel>> getSubCondList()
    {
      using (SqlConnection sql = new SqlConnection(_connectionString))
      {
        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_EL1_GET_PPM_EL_SPG_CONDITION_DSP_E_SUB_COND", sql))
        {
          cmd.CommandType = System.Data.CommandType.StoredProcedure;
          //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
          var response = new List<SPGSubConditionModel>();
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
