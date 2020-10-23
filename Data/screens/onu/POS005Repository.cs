using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class POS005Repository
    {
        private readonly string _connectionString;
        public POS005Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS005Model MapToValue(SqlDataReader reader)
        {
            return new POS005Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_NAP_RECPT_DATE = reader["OU1_NAP_RECPT_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (dynamic)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_RAKE_WAGON_FLG = reader["OU1_RAKE_WAGON_FLG"].ToString(),
                OU1_NAP_TFR_TANK = reader["OU1_NAP_TFR_TANK"].ToString(),
                OU1_RAKE_NO = reader["OU1_RAKE_NO"].ToString(),
                OU1_NO_WAGONS = (dynamic)reader["OU1_NO_WAGONS"],
                OU1_QTY_NAP_RECD = (dynamic)reader["OU1_QTY_NAP_RECD"],
                OU1_NAP_CV_NET = (dynamic)reader["OU1_NAP_CV_NET"],
                OU1_NAP_CV_IOCL = (dynamic)reader["OU1_NAP_CV_IOCL"],
                OU1_RAKE_LOAD_FROM = reader["OU1_RAKE_LOAD_FROM"].ToString(),
                OU1_RAKE_LOAD_DATE1 = reader["OU1_RAKE_LOAD_DATE1"].ToString(),
                OU1_UNLOAD_TRACK = reader["OU1_UNLOAD_TRACK"].ToString(),
                OU1_NAP_AR3A_QTY_MT = (dynamic)reader["OU1_NAP_AR3A_QTY_MT"],
                OU1_NAP_LEVEL_INITIAL = (dynamic)reader["OU1_NAP_LEVEL_INITIAL"],
                OU1_WTR_LEVEL_INITIAL = (dynamic)reader["OU1_WTR_LEVEL_INITIAL"],
                OU1_NAP_LEVEL_FINAL_ACTL = (dynamic)reader["OU1_NAP_LEVEL_FINAL_ACTL"],
                OU1_WTR_LEVEL_FINAL_ACTL = (dynamic)reader["OU1_WTR_LEVEL_FINAL_ACTL"],
                OU1_NAP_AR3A_QTY = (dynamic)reader["OU1_NAP_AR3A_QTY"],
                OU1_TANK_REMK = reader["OU1_TANK_REMK"].ToString(),
                TXT_RAKE_NO = reader["TXT_RAKE_NO"].ToString(),

                // ---------------------PRV-----------------------------
                PRV_OU1_NAP_RECPT_DATE = reader["PRV_OU1_NAP_RECPT_DATE"].ToString(),
                PRV_OU1_RAKE_WAGON_FLG = reader["PRV_OU1_RAKE_WAGON_FLG"].ToString(),
                PRV_OU1_NAP_TFR_TANK = reader["PRV_OU1_NAP_TFR_TANK"].ToString(),
                PRV_OU1_RAKE_NO = (dynamic)reader["PRV_OU1_RAKE_NO"],
                PRV_OU1_NO_WAGONS = (dynamic)reader["PRV_OU1_NO_WAGONS"],
                PRV_OU1_QTY_NAP_RECD = (dynamic)reader["PRV_OU1_QTY_NAP_RECD"],
                PRV_OU1_NAP_CV_NET = (dynamic)reader["PRV_OU1_NAP_CV_NET"],
                PRV_OU1_NAP_CV_IOCL = (dynamic)reader["PRV_OU1_NAP_CV_IOCL"],
                PRV_OU1_RAKE_LOAD_FROM = reader["PRV_OU1_RAKE_LOAD_FROM"].ToString(),
                PRV_OU1_RAKE_LOAD_DATE1 = reader["PRV_OU1_RAKE_LOAD_DATE1"].ToString(),
                PRV_OU1_UNLOAD_TRACK = reader["PRV_OU1_UNLOAD_TRACK"].ToString(),
                PRV_OU1_NAP_AR3A_QTY_MT = (dynamic)reader["PRV_OU1_NAP_AR3A_QTY_MT"],
                PRV_OU1_NAP_LEVEL_INITIAL = (dynamic)reader["PRV_OU1_NAP_LEVEL_INITIAL"],
                PRV_OU1_WTR_LEVEL_INITIAL = (dynamic)reader["PRV_OU1_WTR_LEVEL_INITIAL"],
                PRV_OU1_NAP_LEVEL_FINAL_ACTL = (dynamic)reader["PRV_OU1_NAP_LEVEL_FINAL_ACTL"],
                PRV_OU1_WTR_LEVEL_FINAL_ACTL = (dynamic)reader["PRV_OU1_WTR_LEVEL_FINAL_ACTL"],
                PRV_OU1_NAP_AR3A_QTY = reader["PRV_OU1_NAP_AR3A_QTY"].ToString(),
                PRV_OU1_TANK_REMK = reader["PRV_OU1_TANK_REMK"].ToString(),
            };
        }

        public async Task<List<POS005Model>> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_NAP_RECPT_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<POS005Model>();
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
        public async Task saveData(POS005SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_NAP_RECPT_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_RECPT_DATE", value.OU1_NAP_RECPT_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAKE_WAGON_FLG", value.OU1_RAKE_WAGON_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAKE_NO", value.OU1_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NO_WAGONS", value.OU1_NO_WAGONS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_QTY_NAP_RECD", value.OU1_QTY_NAP_RECD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_TFR_TANK", value.OU1_NAP_TFR_TANK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CV_NET", value.OU1_NAP_CV_NET));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CV_GROSS", value.OU1_NAP_CV_GROSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RECPT_UNIT", value.OU1_RECPT_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_LDG_STN", value.OU1_NAP_LDG_STN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_LDG_DATE", value.OU1_NAP_LDG_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAKE_LOAD_FROM", value.OU1_RAKE_LOAD_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAKE_LOAD_DATE", value.OU1_RAKE_LOAD_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAKE_LOAD_DATE1", value.OU1_RAKE_LOAD_DATE1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNLOAD_TRACK", value.OU1_UNLOAD_TRACK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_LEVEL_INITIAL", value.OU1_NAP_LEVEL_INITIAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WTR_LEVEL_INITIAL", value.OU1_WTR_LEVEL_INITIAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_LEVEL_FINAL_ACTL", value.OU1_NAP_LEVEL_FINAL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WTR_LEVEL_FINAL_ACTL", value.OU1_WTR_LEVEL_FINAL_ACTL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_AR3A_QTY", value.OU1_NAP_AR3A_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TANK_REMK", value.OU1_TANK_REMK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_AR3A_QTY_MT", value.OU1_NAP_AR3A_QTY_MT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_CV_IOCL", value.OU1_NAP_CV_IOCL));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
