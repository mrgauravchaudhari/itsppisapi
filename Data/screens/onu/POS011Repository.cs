using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class POS011Repository
    {
        private readonly string _connectionString;
        public POS011Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS011Model MapToValue(SqlDataReader reader)
        {
            return new POS011Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_ACT_CIRC_FLOW = (decimal)reader["OU1_ACT_CIRC_FLOW"],
                OU1_ACT_MAKE_UP = (decimal)reader["OU1_ACT_MAKE_UP"],
                OU1_ACT_SUPP_TEMP = (decimal)reader["OU1_ACT_SUPP_TEMP"],
                OU1_ACT_RETN_TEMP = (decimal)reader["OU1_ACT_RETN_TEMP"],
                OU1_ACT_DRYBULB_TEMP = (decimal)reader["OU1_ACT_DRYBULB_TEMP"],
                OU1_ACT_WETBULB_TEMP = (decimal)reader["OU1_ACT_WETBULB_TEMP"],
                OU1_ACT_APPWACH = (decimal)reader["OU1_ACT_APPWACH"],
                OU1_ACT_RANGE = (decimal)reader["OU1_ACT_RANGE"],
                OU1_ACT_HEAT_DUTY = (decimal)reader["OU1_ACT_HEAT_DUTY"],
                OU1_ACT_THERMAL_EFF = (decimal)reader["OU1_ACT_THERMAL_EFF"],
                OU1_UCT_CIRC_FLOW = (decimal)reader["OU1_UCT_CIRC_FLOW"],
                OU1_UCT_MAKE_UP = (decimal)reader["OU1_UCT_MAKE_UP"],
                OU1_UCT_SUPP_TEMP = (decimal)reader["OU1_UCT_SUPP_TEMP"],
                OU1_UCT_RETN_TEMP = (decimal)reader["OU1_UCT_RETN_TEMP"],
                OU1_UCT_DRYBULB_TEMP = (decimal)reader["OU1_UCT_DRYBULB_TEMP"],
                OU1_UCT_WETBULB_TEMP = (decimal)reader["OU1_UCT_WETBULB_TEMP"],
                OU1_UCT_APPWACH = (decimal)reader["OU1_UCT_APPWACH"],
                OU1_UCT_RANGE = (decimal)reader["OU1_UCT_RANGE"],
                OU1_UCT_HEAT_DUTY = (decimal)reader["OU1_UCT_HEAT_DUTY"],
                OU1_UCT_THERMAL_EFF = (decimal)reader["OU1_UCT_THERMAL_EFF"],

                // ------------------PRV-----------------------------
                PRV_OU_TRANS_DATE = reader["PRV_OU_TRANS_DATE"].ToString(),
                PRV_OU_ACT_CIRC_FLOW = (decimal)reader["PRV_OU_ACT_CIRC_FLOW"],
                PRV_OU_ACT_MAKE_UP = (decimal)reader["PRV_OU_ACT_MAKE_UP"],
                PRV_OU_ACT_SUPP_TEMP = (decimal)reader["PRV_OU_ACT_SUPP_TEMP"],
                PRV_OU_ACT_RETN_TEMP = (decimal)reader["PRV_OU_ACT_RETN_TEMP"],
                PRV_OU_ACT_DRYBULB_TEMP = (decimal)reader["PRV_OU_ACT_DRYBULB_TEMP"],
                PRV_OU_ACT_WETBULB_TEMP = (decimal)reader["PRV_OU_ACT_WETBULB_TEMP"],
                PRV_OU_UCT_CIRC_FLOW = (decimal)reader["PRV_OU_UCT_CIRC_FLOW"],
                PRV_OU_UCT_MAKE_UP = (decimal)reader["PRV_OU_UCT_MAKE_UP"],
                PRV_OU_UCT_SUPP_TEMP = (decimal)reader["PRV_OU_UCT_SUPP_TEMP"],
                PRV_OU_UCT_RETN_TEMP = (decimal)reader["PRV_OU_UCT_RETN_TEMP"],
                PRV_OU_UCT_DRYBULB_TEMP = (decimal)reader["PRV_OU_UCT_DRYBULB_TEMP"],
                PRV_OU_UCT_WETBULB_TEMP = (decimal)reader["PRV_OU_UCT_WETBULB_TEMP"],
            };
        }

        public async Task<POS011Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_CT_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS011Model response = null;
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

        public async Task saveData(POS011SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_CT_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_CIRC_FLOW", value.OU1_ACT_CIRC_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_MAKE_UP", value.OU1_ACT_MAKE_UP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_SUPP_TEMP", value.OU1_ACT_SUPP_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_RETN_TEMP", value.OU1_ACT_RETN_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_DRYBULB_TEMP", value.OU1_ACT_DRYBULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_WETBULB_TEMP", value.OU1_ACT_WETBULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_APPWACH", value.OU1_ACT_APPWACH));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_RANGE", value.OU1_ACT_RANGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_HEAT_DUTY", value.OU1_ACT_HEAT_DUTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_THERMAL_EFF", value.OU1_ACT_THERMAL_EFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_CIRC_FLOW", value.OU1_UCT_CIRC_FLOW));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_MAKE_UP", value.OU1_UCT_MAKE_UP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_SUPP_TEMP", value.OU1_UCT_SUPP_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_RETN_TEMP", value.OU1_UCT_RETN_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_DRYBULB_TEMP", value.OU1_UCT_DRYBULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_WETBULB_TEMP", value.OU1_UCT_WETBULB_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_APPWACH", value.OU1_UCT_APPWACH));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_RANGE", value.OU1_UCT_RANGE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_HEAT_DUTY", value.OU1_UCT_HEAT_DUTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UCT_THERMAL_EFF", value.OU1_UCT_THERMAL_EFF));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
