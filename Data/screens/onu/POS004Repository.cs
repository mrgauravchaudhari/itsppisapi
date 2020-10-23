using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System;

namespace itsppisapi.Data
{
    public class POS004Repository
    {
        private readonly string _connectionString;
        public POS004Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS004Model MapToValue(SqlDataReader reader)
        {
            return new POS004Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A1_TRANS_DATE = reader["A1_TRANS_DATE"].ToString(),
                A1_NG_RECPT = (decimal)reader["A1_NG_RECPT"],
                A1_AVG_PRS_NG_GT = (decimal)reader["A1_AVG_PRS_NG_GT"],
                A1_AVG_TEMP_NG_GT = (decimal)reader["A1_AVG_TEMP_NG_GT"],
                A1_AVG_PRS_NG_HRSG = (decimal)reader["A1_AVG_PRS_NG_HRSG"],
                A1_AVG_TEMP_NG_HRSG = (decimal)reader["A1_AVG_TEMP_NG_HRSG"],
                A1_MOL_WT_NG = (decimal)reader["A1_MOL_WT_NG"],
                A1_NG_AB1_INT = (decimal)reader["A1_NG_AB1_INT"],
                A1_NG_AB1_INT_DIFF = (decimal)reader["A1_NG_AB1_INT_DIFF"],
                A1_NG_CONSP_AB1 = (decimal)reader["A1_NG_CONSP_AB1"],
                A1_NG_AB2_INT = (decimal)reader["A1_NG_AB2_INT"],
                A1_NG_AB2_INT_DIFF = (decimal)reader["A1_NG_AB2_INT_DIFF"],
                A1_NG_CONSP_AB2 = (decimal)reader["A1_NG_CONSP_AB2"],
                A1_NG_GT1_INT = (decimal)reader["A1_NG_GT1_INT"],
                A1_NG_GT1_INT_DIFF = (decimal)reader["A1_NG_GT1_INT_DIFF"],
                A1_NG_CONSP_GT1 = (decimal)reader["A1_NG_CONSP_GT1"],
                A1_NG_GT2_INT = (decimal)reader["A1_NG_GT2_INT"],
                A1_NG_GT2_INT_DIFF = (decimal)reader["A1_NG_GT2_INT_DIFF"],
                A1_NG_CONSP_GT2 = (decimal)reader["A1_NG_CONSP_GT2"],
                A1_NG_HRSG1_INT = (decimal)reader["A1_NG_HRSG1_INT"],
                A1_NG_HRSG1_INT_DIFF = (decimal)reader["A1_NG_HRSG1_INT_DIFF"],
                A1_NG_CONSP_HRSG1 = (decimal)reader["A1_NG_CONSP_HRSG1"],
                A1_NG_HRSG2_INT = (decimal)reader["A1_NG_HRSG2_INT"],
                A1_NG_HRSG2_INT_DIFF = (decimal)reader["A1_NG_HRSG2_INT_DIFF"],
                A1_NG_CONSP_HRSG2 = (decimal)reader["A1_NG_CONSP_HRSG2"],
                A1_NG_CONSP_SPG = (decimal)reader["A1_NG_CONSP_SPG"],
                A1_NG_CONSP_AMM = (decimal)reader["A1_NG_CONSP_AMM"],
                A1_DATE_MOD = reader["A1_DATE_MOD"].ToString(),
                A1_USER_ID = (decimal)reader["A1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                //PRV
                PRV_A1_TRANS_DATE = reader["PRV_A1_TRANS_DATE"].ToString(),
                PRV_A1_NG_RECPT = (decimal)reader["PRV_A1_NG_RECPT"],
                PRV_A1_AVG_PRS_NG_GT = (decimal)reader["PRV_A1_AVG_PRS_NG_GT"],
                PRV_A1_AVG_TEMP_NG_GT = (decimal)reader["PRV_A1_AVG_TEMP_NG_GT"],
                PRV_A1_AVG_PRS_NG_HRSG = (decimal)reader["PRV_A1_AVG_PRS_NG_HRSG"],
                PRV_A1_AVG_TEMP_NG_HRSG = (decimal)reader["PRV_A1_AVG_TEMP_NG_HRSG"],
                PRV_A1_MOL_WT_NG = (decimal)reader["PRV_A1_MOL_WT_NG"],
                PRV_A1_NG_AB1_INT = (decimal)reader["PRV_A1_NG_AB1_INT"],
                PRV_A1_NG_AB1_INT_DIFF = (decimal)reader["PRV_A1_NG_AB1_INT_DIFF"],
                PRV_A1_NG_CONSP_AB1 = (decimal)reader["PRV_A1_NG_CONSP_AB1"],
                PRV_A1_NG_AB2_INT = (decimal)reader["PRV_A1_NG_AB2_INT"],
                PRV_A1_NG_AB2_INT_DIFF = (decimal)reader["PRV_A1_NG_AB2_INT_DIFF"],
                PRV_A1_NG_CONSP_AB2 = (decimal)reader["PRV_A1_NG_CONSP_AB2"],
                PRV_A1_NG_GT1_INT = (decimal)reader["PRV_A1_NG_GT1_INT"],
                PRV_A1_NG_GT1_INT_DIFF = (decimal)reader["PRV_A1_NG_GT1_INT_DIFF"],
                PRV_A1_NG_CONSP_GT1 = (decimal)reader["PRV_A1_NG_CONSP_GT1"],
                PRV_A1_NG_GT2_INT = (decimal)reader["PRV_A1_NG_GT2_INT"],
                PRV_A1_NG_GT2_INT_DIFF = (decimal)reader["PRV_A1_NG_GT2_INT_DIFF"],
                PRV_A1_NG_CONSP_GT2 = (decimal)reader["PRV_A1_NG_CONSP_GT2"],
                PRV_A1_NG_HRSG1_INT = (decimal)reader["PRV_A1_NG_HRSG1_INT"],
                PRV_A1_NG_HRSG1_INT_DIFF = (decimal)reader["PRV_A1_NG_HRSG1_INT_DIFF"],
                PRV_A1_NG_CONSP_HRSG1 = (decimal)reader["PRV_A1_NG_CONSP_HRSG1"],
                PRV_A1_NG_HRSG2_INT = (decimal)reader["PRV_A1_NG_HRSG2_INT"],
                PRV_A1_NG_HRSG2_INT_DIFF = (decimal)reader["PRV_A1_NG_HRSG2_INT_DIFF"],
                PRV_A1_NG_CONSP_HRSG2 = (decimal)reader["PRV_A1_NG_CONSP_HRSG2"],
                PRV_A1_NG_CONSP_SPG = (decimal)reader["PRV_A1_NG_CONSP_SPG"],
                PRV_A1_NG_CONSP_AMM = (decimal)reader["PRV_A1_NG_CONSP_AMM"],

                // DV
                parm_cf_nm3_sm3 = (decimal)reader["parm_cf_nm3_sm3"],
                parm_ng_dsg_comp_fact_ab = (decimal)reader["parm_ng_dsg_comp_fact_ab"],
                parm_dsg_mol_wt = (decimal)reader["parm_dsg_mol_wt"],
                parm_ng_act_comp_fact_ab = (decimal)reader["parm_ng_act_comp_fact_ab"],
                parm_ng_dsg_comp_fact_gt = (decimal)reader["parm_ng_dsg_comp_fact_gt"],
                parm_dsg_prs_gt = (decimal)reader["parm_dsg_prs_gt"],
                parm_dsg_temp_gt = (decimal)reader["parm_dsg_temp_gt"],
                parm_kelvin_temp = (decimal)reader["parm_kelvin_temp"],
                parm_ng_act_comp_fact_gt = (decimal)reader["parm_ng_act_comp_fact_gt"],
                parm_dsg_temp_hrsg = (decimal)reader["parm_dsg_temp_hrsg"],
                parm_dsg_prs_hrsg = (decimal)reader["parm_dsg_prs_hrsg"]
            };
        }

        public async Task<POS004Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_AM_NG_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    POS004Model response = null;
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

        public async Task saveData(POS004SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_AM_NG_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TRANS_DATE", value.A1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UNIT_ID", value.A1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_DMY_FLG", value.A1_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_USER_ID", value.A1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MOL_WT_NG", value.A1_MOL_WT_NG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB1_INT", value.A1_NG_AB1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB1_INT_DIFF", value.A1_NG_AB1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB2_INT", value.A1_NG_AB2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_AB2_INT_DIFF", value.A1_NG_AB2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT1_INT", value.A1_NG_GT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT1_INT_DIFF", value.A1_NG_GT1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT2_INT", value.A1_NG_GT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_GT2_INT_DIFF", value.A1_NG_GT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG1_INT", value.A1_NG_HRSG1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG1_INT_DIFF", value.A1_NG_HRSG1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG2_INT", value.A1_NG_HRSG2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_HRSG2_INT_DIFF", value.A1_NG_HRSG2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ACTL_COMS_FACTOR_NG_AB", value.A1_ACTL_COMS_FACTOR_NG_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_ACTL_COMS_FACTOR_NG_GT", value.A1_ACTL_COMS_FACTOR_NG_GT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_PRS_NG_GT", value.A1_AVG_PRS_NG_GT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_TEMP_NG_GT", value.A1_AVG_TEMP_NG_GT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_PRS_NG_HRSG", value.A1_AVG_PRS_NG_HRSG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_AVG_TEMP_NG_HRSG", value.A1_AVG_TEMP_NG_HRSG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_AB", value.A1_CF_NG_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_GT", value.A1_CF_NG_GT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_CF_NG_HRSG", value.A1_CF_NG_HRSG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AB1", value.A1_NG_CONSP_AB1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AB2", value.A1_NG_CONSP_AB2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_AB", value.A1_NG_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_GT1", value.A1_NG_CONSP_GT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_GT2", value.A1_NG_CONSP_GT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_GT", value.A1_NG_CONSP_GT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_HRSG1", value.A1_NG_CONSP_HRSG1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_HRSG2", value.A1_NG_CONSP_HRSG2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_HRSG", value.A1_NG_CONSP_HRSG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NG_CONSP_SPG", value.A1_NG_CONSP_SPG));
                    // cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS", value.A1_REMARKS));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
