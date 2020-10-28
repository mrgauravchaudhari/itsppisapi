using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS015Repository
    {
        private readonly string _connectionString;
        public POS015Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS015Model MapToValue(SqlDataReader reader)
        {
            return new POS015Model()
            {
                OU1_CHEM_ITEM_CODE = reader["OU1_CHEM_ITEM_CODE"].ToString(),
                OU1_CHEM_ITEM_FIELD_REF = reader["OU1_CHEM_ITEM_FIELD_REF"].ToString(),
                OU1_CHEM_ITEM_DESC = reader["OU1_CHEM_ITEM_DESC"].ToString(),
                OU1_CHEM_CONS_TYPE = reader["OU1_CHEM_CONS_TYPE"].ToString(),
                OU1_CHEM_UNIT = reader["OU1_CHEM_UNIT"].ToString(),
                OU1_CHEM_AMMO_RATIO = (decimal)reader["OU1_CHEM_AMMO_RATIO"],
                OU1_CHEM_UREA_RATIO = (decimal)reader["OU1_CHEM_UREA_RATIO"],
                OU1_CHEM_CC = (decimal)reader["OU1_CHEM_CC"],
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<POS015Model>> putData(string IN_UNIT)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_GET_PPM_OU_CHEMICAL_CLASSIFY", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT", IN_UNIT));
                    var response = new List<POS015Model>();
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

        public async Task saveData(POS015SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_SAVE_PPM_OU_CHEMICAL_CLASSIFY", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_ITEM_CODE", value.OU1_CHEM_ITEM_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_ITEM_FIELD_REF", value.OU1_CHEM_ITEM_FIELD_REF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_ITEM_DESC", value.OU1_CHEM_ITEM_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_CONS_TYPE", value.OU1_CHEM_CONS_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_UNIT", value.OU1_CHEM_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_AMMO_RATIO", value.OU1_CHEM_AMMO_RATIO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_UREA_RATIO", value.OU1_CHEM_UREA_RATIO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_CC", value.OU1_CHEM_CC));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_USER_ID", value.OU1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_STOCK", value.OU1_CHEM_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_RECPT", value.OU1_CHEM_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_CONSP", value.OU1_CHEM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEM_OPSTOCK", value.OU1_CHEM_OPSTOCK));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
