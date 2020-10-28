using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS208Repository
    {
        private readonly string _connectionString;
        public PAS208Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS208Model MapToValue(SqlDataReader reader)
        {
            return new PAS208Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_RG_SH_PROD_INT = (dynamic)reader["A2_RG_SH_PROD_INT"],
                A2_RG_SH_PROD = (dynamic)reader["A2_RG_SH_PROD"],
                A2_DESUP_WATER_INT = (dynamic)reader["A2_DESUP_WATER_INT"],
                A2_DESUP_WATER_INT_DIFF = (dynamic)reader["A2_DESUP_WATER_INT_DIFF"],
                A2_AB_SH_PROD_INT = (dynamic)reader["A2_AB_SH_PROD_INT"],
                A2_AB_SH_PROD = (dynamic)reader["A2_AB_SH_PROD"],
                A2_LB_SH_PROD_INT = (dynamic)reader["A2_LB_SH_PROD_INT"],
                A2_LB_SH_PROD = (dynamic)reader["A2_LB_SH_PROD"],
                A2_TOTAL_SH_PROD = (dynamic)reader["A2_TOTAL_SH_PROD"],
                A2_SH_CONSP_SYNGAS_INT = (dynamic)reader["A2_SH_CONSP_SYNGAS_INT"],
                A2_SH_CONSP_SYNGAS = (dynamic)reader["A2_SH_CONSP_SYNGAS"],
                A2_SH_CONSP_AIRCOMP_INT = (dynamic)reader["A2_SH_CONSP_AIRCOMP_INT"],
                A2_SH_CONSP_AIRCOMP = (dynamic)reader["A2_SH_CONSP_AIRCOMP"],
                A2_SH_CONSP_UREA2 = (dynamic)reader["A2_SH_CONSP_UREA2"],
                A2_SH_LETDOWN_SM = (dynamic)reader["A2_SH_LETDOWN_SM"],
                A2_SH_EXPORTT_GPI = (dynamic)reader["A2_SH_EXPORTT_GPI"],
                A2_SH_TOTAL_CONSP = (dynamic)reader["A2_SH_TOTAL_CONSP"],
                A2_IMPORT_SH_CONSP_UREA = (dynamic)reader["A2_IMPORT_SH_CONSP_UREA"],
                A2_IMPORT_SH_CONSP_AMM = (dynamic)reader["A2_IMPORT_SH_CONSP_AMM"],
                A2_SYNGAS_SM_PROD_INT = (dynamic)reader["A2_SYNGAS_SM_PROD_INT"],
                A2_SYNGAS_SM_PROD_INT_DIFF = (dynamic)reader["A2_SYNGAS_SM_PROD_INT_DIFF"],
                A2_SYNGAS_EXTRACT_SM_PROD = (dynamic)reader["A2_SYNGAS_EXTRACT_SM_PROD"],
                A2_AIRCOMP_SM_PROD_INT = (dynamic)reader["A2_AIRCOMP_SM_PROD_INT"],
                A2_AIRCOMP_SM_PROD_INT_DIFF = (dynamic)reader["A2_AIRCOMP_SM_PROD_INT_DIFF"],
                A2_AIRCOMP_EXTRCT_SM_PROD = (dynamic)reader["A2_AIRCOMP_EXTRCT_SM_PROD"],
                A2_TOTAL_SM_PROD = (dynamic)reader["A2_TOTAL_SM_PROD"],
                A2_SM_CONSP_PSTEAM_INT = (dynamic)reader["A2_SM_CONSP_PSTEAM_INT"],
                A2_SM_CONSP_PSTEAM = (decimal)reader["A2_SM_CONSP_PSTEAM"],
                A2_SM_CONSP_REFCOMP_INT = (dynamic)reader["A2_SM_CONSP_REFCOMP_INT"],
                A2_SM_CONSP_REFCOMP = (dynamic)reader["A2_SM_CONSP_REFCOMP"],
                A2_SM_CONSP_NGCOMP_INT = (dynamic)reader["A2_SM_CONSP_NGCOMP_INT"],
                A2_SM_CONSP_NGCOMP = (dynamic)reader["A2_SM_CONSP_NGCOMP"],
                A2_SM_CONSP_BFW_PUMPA_INT = (dynamic)reader["A2_SM_CONSP_BFW_PUMPA_INT"],
                A2_SM_CONSP_BFW_PUMPA = (dynamic)reader["A2_SM_CONSP_BFW_PUMPA"],
                A2_SM_CONSP_BFW_PUMPB_INT = (dynamic)reader["A2_SM_CONSP_BFW_PUMPB_INT"],
                A2_SM_CONSP_BFW_PUMPB = (dynamic)reader["A2_SM_CONSP_BFW_PUMPB"],
                A2_SM_CONSP_SLPUMPA_INT = (dynamic)reader["A2_SM_CONSP_SLPUMPA_INT"],
                A2_SM_CONSP_SLPUMPA = (dynamic)reader["A2_SM_CONSP_SLPUMPA"],
                A2_SM_CONSP_SLPUMPB_INT = (dynamic)reader["A2_SM_CONSP_SLPUMPB_INT"],
                A2_SM_CONSP_SLPUMPB = (dynamic)reader["A2_SM_CONSP_SLPUMPB"],
                A2_SM_CONSP_LPUMP_INT = (dynamic)reader["A2_SM_CONSP_LPUMP_INT"],
                A2_SM_CONSP_LPUMP = (dynamic)reader["A2_SM_CONSP_LPUMP"],
                A2_SM_CONSP_IDFAN_INT = (dynamic)reader["A2_SM_CONSP_IDFAN_INT"],
                A2_SM_CONSP_IDFAN = (dynamic)reader["A2_SM_CONSP_IDFAN"],
                A2_SM_CONSP_FDFAN_INT = (dynamic)reader["A2_SM_CONSP_FDFAN_INT"],
                A2_SM_CONSP_FDFAN = (dynamic)reader["A2_SM_CONSP_FDFAN"],
                A2_SM_CONSP_PACOIL_INT = (dynamic)reader["A2_SM_CONSP_PACOIL_INT"],
                A2_SM_CONSP_PACOIL = (dynamic)reader["A2_SM_CONSP_PACOIL"],
                A2_SM_CONSP_H2SSTRIP_INT = (dynamic)reader["A2_SM_CONSP_H2SSTRIP_INT"],
                A2_SM_CONSP_H2SSTRIP = (dynamic)reader["A2_SM_CONSP_H2SSTRIP"],
                A2_SM_CONSP_DISTCOL_INT = (dynamic)reader["A2_SM_CONSP_DISTCOL_INT"],
                A2_SM_CONSP_DISTCOL = (dynamic)reader["A2_SM_CONSP_DISTCOL"],
                A2_SM_CONSP_ATOMIZING_INT = (dynamic)reader["A2_SM_CONSP_ATOMIZING_INT"],
                A2_SM_CONSP_ATOMIZING = (dynamic)reader["A2_SM_CONSP_ATOMIZING"],
                A2_SM_LETDOWN_SL = (dynamic)reader["A2_SM_LETDOWN_SL"],
                A2_SM_TOTAL_CONSP_AMM2 = (dynamic)reader["A2_SM_TOTAL_CONSP_AMM2"],
                A2_SM_CONSP_AB_INT = (dynamic)reader["A2_SM_CONSP_AB_INT"],
                A2_SM_CONSP_AB = (dynamic)reader["A2_SM_CONSP_AB"],
                A2_SM_CONSP_ABFDFAN_INT = (dynamic)reader["A2_SM_CONSP_ABFDFAN_INT"],
                A2_SM_CONSP_ABFDFAN = (dynamic)reader["A2_SM_CONSP_ABFDFAN"],
                A2_ABSM_LETDOWN_ATOMIZING = (dynamic)reader["A2_ABSM_LETDOWN_ATOMIZING"],
                A2_SM_CONSP_ACWPUMPA_INT = (dynamic)reader["A2_SM_CONSP_ACWPUMPA_INT"],
                A2_SM_CONSP_ACWPUMPA = (dynamic)reader["A2_SM_CONSP_ACWPUMPA"],
                A2_SM_CONSP_ACWPUMPB_INT = (dynamic)reader["A2_SM_CONSP_ACWPUMPB_INT"],
                A2_SM_CONSP_ACWPUMPB = (dynamic)reader["A2_SM_CONSP_ACWPUMPB"],
                A2_SM_CONSP_ACWPUMPC_INT = (dynamic)reader["A2_SM_CONSP_ACWPUMPC_INT"],
                A2_SM_CONSP_ACWPUMPC = (dynamic)reader["A2_SM_CONSP_ACWPUMPC"],
                A2_SM_CONSP_UCWPUMPA_INT = (dynamic)reader["A2_SM_CONSP_UCWPUMPA_INT"],
                A2_SM_CONSP_UCWPUMPA = (dynamic)reader["A2_SM_CONSP_UCWPUMPA"],
                A2_SM_CONSP_UCWPUMPB_INT = (dynamic)reader["A2_SM_CONSP_UCWPUMPB_INT"],
                A2_SM_CONSP_UCWPUMPB = (dynamic)reader["A2_SM_CONSP_UCWPUMPB"],
                A2_SM_CONSP_UCWPUMPC_INT = (dynamic)reader["A2_SM_CONSP_UCWPUMPC_INT"],
                A2_SM_CONSP_UCWPUMPC = (dynamic)reader["A2_SM_CONSP_UCWPUMPC"],
                A2_SM_CONSP_CTTCPUMP_INT = (dynamic)reader["A2_SM_CONSP_CTTCPUMP_INT"],
                A2_SM_CONSP_CTTCPUMP = (dynamic)reader["A2_SM_CONSP_CTTCPUMP"],
                A2_SM_TOTAL_CONSP_UTIL = (dynamic)reader["A2_SM_TOTAL_CONSP_UTIL"],
                A2_SM_TOTAL_CONSP_GPII = (dynamic)reader["A2_SM_TOTAL_CONSP_GPII"],
                A2_SL_INTERNAL_PROD = (dynamic)reader["A2_SL_INTERNAL_PROD"],
                A2_TOTAL_SL_PROD = (dynamic)reader["A2_TOTAL_SL_PROD"],
                A2_SL_CONSP_AMMREF_INT = (dynamic)reader["A2_SL_CONSP_AMMREF_INT"],
                A2_SL_CONSP_AMMREF = (dynamic)reader["A2_SL_CONSP_AMMREF"],
                A2_SL_CONSP_NAPPREHEAT_INT = (dynamic)reader["A2_SL_CONSP_NAPPREHEAT_INT"],
                A2_SL_CONSP_NAPPREHEAT = (dynamic)reader["A2_SL_CONSP_NAPPREHEAT"],
                A2_SL_CONSP_RNAPPREHEAT_INT = (dynamic)reader["A2_SL_CONSP_RNAPPREHEAT_INT"],
                A2_SL_CONSP_RNAPPREHEAT = (dynamic)reader["A2_SL_CONSP_RNAPPREHEAT"],
                A2_SL_CONSP_EJECTOR_INT = (dynamic)reader["A2_SL_CONSP_EJECTOR_INT"],
                A2_SL_CONSP_EJECTOR = (dynamic)reader["A2_SL_CONSP_EJECTOR"],
                A2_SL_CONSP_DEAERATOR = (dynamic)reader["A2_SL_CONSP_DEAERATOR"],
                A2_SL_CONSP_MISC = (dynamic)reader["A2_SL_CONSP_MISC"],
                A2_SL_TOTAL_CONSP = (dynamic)reader["A2_SL_TOTAL_CONSP"],
                TXT_IMP_KS_GP1 = (dynamic)reader["TXT_IMP_KS_GP1"],
                TXT_LET_DWN_SH = (dynamic)reader["TXT_LET_DWN_SH"],
                TXT_LET_DWN_SM = (dynamic)reader["TXT_LET_DWN_SM"],
                TXT_IMP_LS_GP1 = (dynamic)reader["TXT_IMP_LS_GP1"],
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_A2_TRANS_DATE = reader["PRV_A2_TRANS_DATE"].ToString(),
                PRV_A2_RG_SH_PROD_INT = (dynamic)reader["PRV_A2_RG_SH_PROD_INT"],
                PRV_A2_RG_SH_PROD = (dynamic)reader["PRV_A2_RG_SH_PROD"],
                PRV_A2_DESUP_WATER_INT = (dynamic)reader["PRV_A2_DESUP_WATER_INT"],
                PRV_A2_DESUP_WATER_INT_DIFF = (dynamic)reader["PRV_A2_DESUP_WATER_INT_DIFF"],
                PRV_A2_AB_SH_PROD_INT = (dynamic)reader["PRV_A2_AB_SH_PROD_INT"],
                PRV_A2_AB_SH_PROD = (dynamic)reader["PRV_A2_AB_SH_PROD"],
                PRV_A2_LB_SH_PROD_INT = (dynamic)reader["PRV_A2_LB_SH_PROD_INT"],
                PRV_A2_LB_SH_PROD = (dynamic)reader["PRV_A2_LB_SH_PROD"],
                PRV_A2_TOTAL_SH_PROD = (dynamic)reader["PRV_A2_TOTAL_SH_PROD"],
                PRV_A2_SH_CONSP_SYNGAS_INT = (dynamic)reader["PRV_A2_SH_CONSP_SYNGAS_INT"],
                PRV_A2_SH_CONSP_SYNGAS = (dynamic)reader["PRV_A2_SH_CONSP_SYNGAS"],
                PRV_A2_SH_CONSP_AIRCOMP_INT = (dynamic)reader["PRV_A2_SH_CONSP_AIRCOMP_INT"],
                PRV_A2_SH_CONSP_AIRCOMP = (dynamic)reader["PRV_A2_SH_CONSP_AIRCOMP"],
                PRV_A2_SH_CONSP_UREA2 = (dynamic)reader["PRV_A2_SH_CONSP_UREA2"],
                PRV_A2_SH_LETDOWN_SM = (dynamic)reader["PRV_A2_SH_LETDOWN_SM"],
                PRV_A2_SH_EXPORTT_GPI = (dynamic)reader["PRV_A2_SH_EXPORTT_GPI"],
                PRV_A2_SH_TOTAL_CONSP = (dynamic)reader["PRV_A2_SH_TOTAL_CONSP"],
                PRV_A2_IMPORT_SH_CONSP_UREA = (dynamic)reader["PRV_A2_IMPORT_SH_CONSP_UREA"],
                PRV_A2_IMPORT_SH_CONSP_AMM = (dynamic)reader["PRV_A2_IMPORT_SH_CONSP_AMM"],
                PRV_A2_SYNGAS_SM_PROD_INT = (dynamic)reader["PRV_A2_SYNGAS_SM_PROD_INT"],
                PRV_A2_SYNGAS_SM_PROD_INT_DIFF = (dynamic)reader["PRV_A2_SYNGAS_SM_PROD_INT_DIFF"],
                PRV_A2_SYNGAS_EXTRACT_SM_PROD = (dynamic)reader["PRV_A2_SYNGAS_EXTRACT_SM_PROD"],
                PRV_A2_AIRCOMP_SM_PROD_INT = (dynamic)reader["PRV_A2_AIRCOMP_SM_PROD_INT"],
                PRV_A2_AIRCOMP_SM_PROD_INT_DIFF = (dynamic)reader["PRV_A2_AIRCOMP_SM_PROD_INT_DIFF"],
                PRV_A2_AIRCOMP_EXTRCT_SM_PROD = (dynamic)reader["PRV_A2_AIRCOMP_EXTRCT_SM_PROD"],
                PRV_A2_TOTAL_SM_PROD = (dynamic)reader["PRV_A2_TOTAL_SM_PROD"],
                PRV_A2_SM_CONSP_PSTEAM_INT = (dynamic)reader["PRV_A2_SM_CONSP_PSTEAM_INT"],
                PRV_A2_SM_CONSP_PSTEAM = (dynamic)reader["PRV_A2_SM_CONSP_PSTEAM"],
                PRV_A2_SM_CONSP_REFCOMP_INT = (dynamic)reader["PRV_A2_SM_CONSP_REFCOMP_INT"],
                PRV_A2_SM_CONSP_REFCOMP = (dynamic)reader["PRV_A2_SM_CONSP_REFCOMP"],
                PRV_A2_SM_CONSP_NGCOMP_INT = (dynamic)reader["PRV_A2_SM_CONSP_NGCOMP_INT"],
                PRV_A2_SM_CONSP_NGCOMP = (dynamic)reader["PRV_A2_SM_CONSP_NGCOMP"],
                PRV_A2_SM_CONSP_BFW_PUMPA_INT = (dynamic)reader["PRV_A2_SM_CONSP_BFW_PUMPA_INT"],
                PRV_A2_SM_CONSP_BFW_PUMPA = (dynamic)reader["PRV_A2_SM_CONSP_BFW_PUMPA"],
                PRV_A2_SM_CONSP_BFW_PUMPB_INT = (dynamic)reader["PRV_A2_SM_CONSP_BFW_PUMPB_INT"],
                PRV_A2_SM_CONSP_BFW_PUMPB = (dynamic)reader["PRV_A2_SM_CONSP_BFW_PUMPB"],
                PRV_A2_SM_CONSP_SLPUMPA_INT = (dynamic)reader["PRV_A2_SM_CONSP_SLPUMPA_INT"],
                PRV_A2_SM_CONSP_SLPUMPA = (dynamic)reader["PRV_A2_SM_CONSP_SLPUMPA"],
                PRV_A2_SM_CONSP_SLPUMPB_INT = (dynamic)reader["PRV_A2_SM_CONSP_SLPUMPB_INT"],
                PRV_A2_SM_CONSP_SLPUMPB = (dynamic)reader["PRV_A2_SM_CONSP_SLPUMPB"],
                PRV_A2_SM_CONSP_LPUMP_INT = (dynamic)reader["PRV_A2_SM_CONSP_LPUMP_INT"],
                PRV_A2_SM_CONSP_LPUMP = (dynamic)reader["PRV_A2_SM_CONSP_LPUMP"],
                PRV_A2_SM_CONSP_IDFAN_INT = (dynamic)reader["PRV_A2_SM_CONSP_IDFAN_INT"],
                PRV_A2_SM_CONSP_IDFAN = (dynamic)reader["PRV_A2_SM_CONSP_IDFAN"],
                PRV_A2_SM_CONSP_FDFAN_INT = (dynamic)reader["PRV_A2_SM_CONSP_FDFAN_INT"],
                PRV_A2_SM_CONSP_FDFAN = (dynamic)reader["PRV_A2_SM_CONSP_FDFAN"],
                PRV_A2_SM_CONSP_PACOIL_INT = (dynamic)reader["PRV_A2_SM_CONSP_PACOIL_INT"],
                PRV_A2_SM_CONSP_PACOIL = (dynamic)reader["PRV_A2_SM_CONSP_PACOIL"],
                PRV_A2_SM_CONSP_H2SSTRIP_INT = (dynamic)reader["PRV_A2_SM_CONSP_H2SSTRIP_INT"],
                PRV_A2_SM_CONSP_H2SSTRIP = (dynamic)reader["PRV_A2_SM_CONSP_H2SSTRIP"],
                PRV_A2_SM_CONSP_DISTCOL_INT = (dynamic)reader["PRV_A2_SM_CONSP_DISTCOL_INT"],
                PRV_A2_SM_CONSP_DISTCOL = (dynamic)reader["PRV_A2_SM_CONSP_DISTCOL"],
                PRV_A2_SM_CONSP_ATOMIZING_INT = (dynamic)reader["PRV_A2_SM_CONSP_ATOMIZING_INT"],
                PRV_A2_SM_CONSP_ATOMIZING = (dynamic)reader["PRV_A2_SM_CONSP_ATOMIZING"],
                PRV_A2_SM_LETDOWN_SL = (dynamic)reader["PRV_A2_SM_LETDOWN_SL"],
                PRV_A2_SM_TOTAL_CONSP_AMM2 = (dynamic)reader["PRV_A2_SM_TOTAL_CONSP_AMM2"],
                PRV_A2_SM_CONSP_AB_INT = (dynamic)reader["PRV_A2_SM_CONSP_AB_INT"],
                PRV_A2_SM_CONSP_AB = (dynamic)reader["PRV_A2_SM_CONSP_AB"],
                PRV_A2_SM_CONSP_ABFDFAN_INT = (dynamic)reader["PRV_A2_SM_CONSP_ABFDFAN_INT"],
                PRV_A2_SM_CONSP_ABFDFAN = (dynamic)reader["PRV_A2_SM_CONSP_ABFDFAN"],
                PRV_A2_ABSM_LETDOWN_ATOMIZING = (dynamic)reader["PRV_A2_ABSM_LETDOWN_ATOMIZING"],
                PRV_A2_SM_CONSP_ACWPUMPA_INT = (dynamic)reader["PRV_A2_SM_CONSP_ACWPUMPA_INT"],
                PRV_A2_SM_CONSP_ACWPUMPA = (dynamic)reader["PRV_A2_SM_CONSP_ACWPUMPA"],
                PRV_A2_SM_CONSP_ACWPUMPB_INT = (dynamic)reader["PRV_A2_SM_CONSP_ACWPUMPB_INT"],
                PRV_A2_SM_CONSP_ACWPUMPB = (dynamic)reader["PRV_A2_SM_CONSP_ACWPUMPB"],
                PRV_A2_SM_CONSP_ACWPUMPC_INT = (dynamic)reader["PRV_A2_SM_CONSP_ACWPUMPC_INT"],
                PRV_A2_SM_CONSP_ACWPUMPC = (dynamic)reader["PRV_A2_SM_CONSP_ACWPUMPC"],
                PRV_A2_SM_CONSP_UCWPUMPA_INT = (dynamic)reader["PRV_A2_SM_CONSP_UCWPUMPA_INT"],
                PRV_A2_SM_CONSP_UCWPUMPA = (dynamic)reader["PRV_A2_SM_CONSP_UCWPUMPA"],
                PRV_A2_SM_CONSP_UCWPUMPB_INT = (dynamic)reader["PRV_A2_SM_CONSP_UCWPUMPB_INT"],
                PRV_A2_SM_CONSP_UCWPUMPB = (dynamic)reader["PRV_A2_SM_CONSP_UCWPUMPB"],
                PRV_A2_SM_CONSP_UCWPUMPC_INT = (dynamic)reader["PRV_A2_SM_CONSP_UCWPUMPC_INT"],
                PRV_A2_SM_CONSP_UCWPUMPC = (dynamic)reader["PRV_A2_SM_CONSP_UCWPUMPC"],
                PRV_A2_SM_CONSP_CTTCPUMP_INT = (dynamic)reader["PRV_A2_SM_CONSP_CTTCPUMP_INT"],
                PRV_A2_SM_CONSP_CTTCPUMP = (dynamic)reader["PRV_A2_SM_CONSP_CTTCPUMP"],
                PRV_A2_SM_TOTAL_CONSP_UTIL = (dynamic)reader["PRV_A2_SM_TOTAL_CONSP_UTIL"],
                PRV_A2_SM_TOTAL_CONSP_GPII = (dynamic)reader["PRV_A2_SM_TOTAL_CONSP_GPII"],
                PRV_A2_SL_INTERNAL_PROD = (dynamic)reader["PRV_A2_SL_INTERNAL_PROD"],
                PRV_A2_TOTAL_SL_PROD = (dynamic)reader["PRV_A2_TOTAL_SL_PROD"],
                PRV_A2_SL_CONSP_AMMREF_INT = (dynamic)reader["PRV_A2_SL_CONSP_AMMREF_INT"],
                PRV_A2_SL_CONSP_AMMREF = (dynamic)reader["PRV_A2_SL_CONSP_AMMREF"],
                PRV_A2_SL_CONSP_NAPPREHEAT_INT = (dynamic)reader["PRV_A2_SL_CONSP_NAPPREHEAT_INT"],
                PRV_A2_SL_CONSP_NAPPREHEAT = (dynamic)reader["PRV_A2_SL_CONSP_NAPPREHEAT"],
                PRV_A2_SL_CONSP_RNAPPREHEAT_INT = (dynamic)reader["PRV_A2_SL_CONSP_RNAPPREHEAT_INT"],
                PRV_A2_SL_CONSP_RNAPPREHEAT = (dynamic)reader["PRV_A2_SL_CONSP_RNAPPREHEAT"],
                PRV_A2_SL_CONSP_EJECTOR_INT = (dynamic)reader["PRV_A2_SL_CONSP_EJECTOR_INT"],
                PRV_A2_SL_CONSP_EJECTOR = (dynamic)reader["PRV_A2_SL_CONSP_EJECTOR"],
                PRV_A2_SL_CONSP_DEAERATOR = (dynamic)reader["PRV_A2_SL_CONSP_DEAERATOR"],
                PRV_A2_SL_CONSP_MISC = (dynamic)reader["PRV_A2_SL_CONSP_MISC"],
                PRV_A2_SL_TOTAL_CONSP = (dynamic)reader["PRV_A2_SL_TOTAL_CONSP"],
                PRV_TXT_IMP_KS_GP1 = (dynamic)reader["PRV_TXT_IMP_KS_GP1"],
                PRV_TXT_LET_DWN_SH = (dynamic)reader["PRV_TXT_LET_DWN_SH"],
                PRV_TXT_LET_DWN_SM = (dynamic)reader["PRV_TXT_LET_DWN_SM"],
                PRV_TXT_IMP_LS_GP1 = (dynamic)reader["PRV_TXT_IMP_LS_GP1"]
            };
        }

        public async Task<PAS208Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_STEAM_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS208Model response = null;
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

        public async Task saveData(PAS208SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_STEAM_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RG_SH_PROD_INT", value.A2_RG_SH_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RG_SH_PROD", value.A2_RG_SH_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_SH_PROD_INT", value.A2_AB_SH_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AB_SH_PROD", value.A2_AB_SH_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOTAL_SH_PROD", value.A2_TOTAL_SH_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_CONSP_SYNGAS_INT", value.A2_SH_CONSP_SYNGAS_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_CONSP_SYNGAS", value.A2_SH_CONSP_SYNGAS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_CONSP_AIRCOMP_INT", value.A2_SH_CONSP_AIRCOMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_CONSP_AIRCOMP", value.A2_SH_CONSP_AIRCOMP));
                    // cmd.Parameters.Add(new SqlParameter("@A2_SH_CONSP_UREA2_INT", value.A2_SH_CONSP_UREA2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_CONSP_UREA2", value.A2_SH_CONSP_UREA2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_LETDOWN_SM", value.A2_SH_LETDOWN_SM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_TOTAL_CONSP", value.A2_SH_TOTAL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_EXPORTT_GPI", value.A2_SH_EXPORTT_GPI));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNGAS_SM_PROD_INT", value.A2_SYNGAS_SM_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNGAS_SM_PROD_INT_DIFF", value.A2_SYNGAS_SM_PROD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SYNGAS_EXTRACT_SM_PROD", value.A2_SYNGAS_EXTRACT_SM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AIRCOMP_SM_PROD_INT", value.A2_AIRCOMP_SM_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AIRCOMP_SM_PROD_INT_DIFF", value.A2_AIRCOMP_SM_PROD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_AIRCOMP_EXTRCT_SM_PROD", value.A2_AIRCOMP_EXTRCT_SM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOTAL_SM_PROD", value.A2_TOTAL_SM_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_PSTEAM_INT", value.A2_SM_CONSP_PSTEAM_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_PSTEAM", value.A2_SM_CONSP_PSTEAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_REFCOMP_INT", value.A2_SM_CONSP_REFCOMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_REFCOMP", value.A2_SM_CONSP_REFCOMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_NGCOMP_INT", value.A2_SM_CONSP_NGCOMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_NGCOMP", value.A2_SM_CONSP_NGCOMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_BFW_PUMPA_INT", value.A2_SM_CONSP_BFW_PUMPA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_BFW_PUMPA", value.A2_SM_CONSP_BFW_PUMPA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_BFW_PUMPB_INT", value.A2_SM_CONSP_BFW_PUMPB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_BFW_PUMPB", value.A2_SM_CONSP_BFW_PUMPB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_SLPUMPA_INT", value.A2_SM_CONSP_SLPUMPA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_SLPUMPA", value.A2_SM_CONSP_SLPUMPA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_SLPUMPB_INT", value.A2_SM_CONSP_SLPUMPB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_SLPUMPB", value.A2_SM_CONSP_SLPUMPB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_LPUMP_INT", value.A2_SM_CONSP_LPUMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_LPUMP", value.A2_SM_CONSP_LPUMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_IDFAN_INT", value.A2_SM_CONSP_IDFAN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_IDFAN", value.A2_SM_CONSP_IDFAN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_FDFAN_INT", value.A2_SM_CONSP_FDFAN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_FDFAN", value.A2_SM_CONSP_FDFAN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_PACOIL_INT", value.A2_SM_CONSP_PACOIL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_PACOIL", value.A2_SM_CONSP_PACOIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_H2SSTRIP_INT", value.A2_SM_CONSP_H2SSTRIP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_H2SSTRIP", value.A2_SM_CONSP_H2SSTRIP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_DISTCOL_INT", value.A2_SM_CONSP_DISTCOL_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_DISTCOL", value.A2_SM_CONSP_DISTCOL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ATOMIZING_INT", value.A2_SM_CONSP_ATOMIZING_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ATOMIZING", value.A2_SM_CONSP_ATOMIZING));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_LETDOWN_SL", value.A2_SM_LETDOWN_SL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_TOTAL_CONSP_AMM2", value.A2_SM_TOTAL_CONSP_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_AB_INT", value.A2_SM_CONSP_AB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_AB", value.A2_SM_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ABFDFAN_INT", value.A2_SM_CONSP_ABFDFAN_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ABFDFAN", value.A2_SM_CONSP_ABFDFAN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ABSM_LETDOWN_ATOMIZING", value.A2_ABSM_LETDOWN_ATOMIZING));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ACWPUMPA_INT", value.A2_SM_CONSP_ACWPUMPA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ACWPUMPA", value.A2_SM_CONSP_ACWPUMPA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ACWPUMPB_INT", value.A2_SM_CONSP_ACWPUMPB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ACWPUMPB", value.A2_SM_CONSP_ACWPUMPB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ACWPUMPC_INT", value.A2_SM_CONSP_ACWPUMPC_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_ACWPUMPC", value.A2_SM_CONSP_ACWPUMPC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_UCWPUMPA_INT", value.A2_SM_CONSP_UCWPUMPA_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_UCWPUMPA", value.A2_SM_CONSP_UCWPUMPA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_UCWPUMPB_INT", value.A2_SM_CONSP_UCWPUMPB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_UCWPUMPB", value.A2_SM_CONSP_UCWPUMPB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_UCWPUMPC_INT", value.A2_SM_CONSP_UCWPUMPC_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_UCWPUMPC", value.A2_SM_CONSP_UCWPUMPC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_CTTCPUMP_INT", value.A2_SM_CONSP_CTTCPUMP_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_CTTCPUMP", value.A2_SM_CONSP_CTTCPUMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_TOTAL_CONSP_UTIL", value.A2_SM_TOTAL_CONSP_UTIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_TOTAL_CONSP_GPII", value.A2_SM_TOTAL_CONSP_GPII));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_INTERNAL_PROD", value.A2_SL_INTERNAL_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOTAL_SL_PROD", value.A2_TOTAL_SL_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_AMMREF_INT", value.A2_SL_CONSP_AMMREF_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_AMMREF", value.A2_SL_CONSP_AMMREF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_NAPPREHEAT_INT", value.A2_SL_CONSP_NAPPREHEAT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_NAPPREHEAT", value.A2_SL_CONSP_NAPPREHEAT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_RNAPPREHEAT_INT", value.A2_SL_CONSP_RNAPPREHEAT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_RNAPPREHEAT", value.A2_SL_CONSP_RNAPPREHEAT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_EJECTOR_INT", value.A2_SL_CONSP_EJECTOR_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_EJECTOR", value.A2_SL_CONSP_EJECTOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_MISC", value.A2_SL_CONSP_MISC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_CONSP_DEAERATOR", value.A2_SL_CONSP_DEAERATOR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SL_TOTAL_CONSP", value.A2_SL_TOTAL_CONSP));
                    // cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DESUP_WATER_INT", value.A2_DESUP_WATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DESUP_WATER_INT_DIFF", value.A2_DESUP_WATER_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IMPORT_SH_CONSP_AMM", value.A2_IMPORT_SH_CONSP_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_IMPORT_SH_CONSP_UREA", value.A2_IMPORT_SH_CONSP_UREA));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_LB_SH_PROD_INT", value.A2_LB_SH_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_LB_SH_PROD", value.A2_LB_SH_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SH_CONSP_REVAMP_UNIT2", value.A2_SH_CONSP_REVAMP_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SM_CONSP_REVAMP_UNIT2", value.A2_SM_CONSP_REVAMP_UNIT2));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
