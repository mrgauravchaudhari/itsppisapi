using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class POS012Repository
    {
        private readonly string _connectionString;
        public POS012Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS012Model MapToValue(SqlDataReader reader)
        {
            return new POS012Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU_DEPT_CODE = reader["OU_DEPT_CODE"].ToString(),
                OU1_PUMP_UNIT_FLG = reader["OU1_PUMP_UNIT_FLG"].ToString(),
                OU1_CATG_NAME = reader["OU1_CATG_NAME"].ToString(),
                OU1_MACH_NAME = reader["OU1_MACH_NAME"].ToString(),
                OU1_MACH_RUNHRS = (decimal)reader["OU1_MACH_RUNHRS"]
            };
        }

        public async Task<List<POS012Model>> putData(string IN_MNTH)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_GET_PPT_OU_MACHINE_DETAILS_12", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MNTH", IN_MNTH));
                    //cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    //POS012Model response = null;
                    var response = new List<POS012Model>();
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

        //public async Task saveData(POS012SaveDto value)
        //{
        //    using (SqlConnection sql = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_AM_NG_CONSP_DETAILS", sql))
        //        {
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_TRANS_DATE", value.A1_TRANS_DATE));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_UNIT_ID", value.A1_UNIT_ID));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_DMY_FLG", value.A1_DMY_FLG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_USER_ID", value.A1_USER_ID));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_MOL_WT_NG", value.A1_MOL_WT_NG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB1_INT", value.A1_NG_AB1_INT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB1_INT_DIFF", value.A1_NG_AB1_INT_DIFF));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB2_INT", value.A1_NG_AB2_INT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB2_INT_DIFF", value.A1_NG_AB2_INT_DIFF));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT1_INT", value.A1_NG_GT1_INT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT1_INT_DIFF", value.A1_NG_GT1_INT_DIFF));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT2_INT", value.A1_NG_GT2_INT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT2_INT_DIFF", value.A1_NG_GT2_INT_DIFF));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG1_INT", value.A1_NG_HRSG1_INT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG1_INT_DIFF", value.A1_NG_HRSG1_INT_DIFF));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG2_INT", value.A1_NG_HRSG2_INT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG2_INT_DIFF", value.A1_NG_HRSG2_INT_DIFF));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_ACTL_COMS_FACTOR_NG_AB", value.A1_ACTL_COMS_FACTOR_NG_AB));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_ACTL_COMS_FACTOR_NG_GT", value.A1_ACTL_COMS_FACTOR_NG_GT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_PRS_NG_GT", value.A1_AVG_PRS_NG_GT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_TEMP_NG_GT", value.A1_AVG_TEMP_NG_GT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_PRS_NG_HRSG", value.A1_AVG_PRS_NG_HRSG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_TEMP_NG_HRSG", value.A1_AVG_TEMP_NG_HRSG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_AB", value.A1_CF_NG_AB));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_GT", value.A1_CF_NG_GT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_HRSG", value.A1_CF_NG_HRSG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AB1", value.A1_NG_CONSP_AB1));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AB2", value.A1_NG_CONSP_AB2));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AB", value.A1_NG_CONSP_AB));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_GT1", value.A1_NG_CONSP_GT1));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_GT2", value.A1_NG_CONSP_GT2));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_GT", value.A1_NG_CONSP_GT));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_HRSG1", value.A1_NG_CONSP_HRSG1));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_HRSG2", value.A1_NG_CONSP_HRSG2));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_HRSG", value.A1_NG_CONSP_HRSG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_SPG", value.A1_NG_CONSP_SPG));
        //            cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS", value.A1_REMARKS));

        //            await sql.OpenAsync();
        //            await cmd.ExecuteNonQueryAsync();
        //            return;
        //        }
        //    }
        //}
    }
}
