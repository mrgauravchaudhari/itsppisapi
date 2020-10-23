using System.Collections.Generic;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace itsppisapi.Data {
    public class PGS007Repository {
        private readonly string _connectionString;
        public PGS007Repository (IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString ("DBConnection");
        }

        private PGS007Model MapToValueMM (SqlDataReader reader) {
            return new PGS007Model () {
                DEPT_CODE = reader["DEPT_CODE"].ToString (),
                    DEPT_NAME = reader["DEPT_NAME"].ToString (),
                    DATE_MOD = reader["DATE_MOD"].ToString (),
                    USER_ID = (decimal) reader["USER_ID"],
                    DEPT_EMAIL1 = reader["DEPT_EMAIL1"].ToString (),
                    DEPT_EMAIL2 = reader["DEPT_EMAIL2"].ToString (),
                    DEPT_MAILS = reader["DEPT_MAILS"].ToString (),
                    DEPT_FMAILS = reader["DEPT_FMAILS"].ToString (),
                    USER_NAME = reader["USER_NAME"].ToString ()
            };
        }

        public async Task<List<PGS007Model>> putData () {
            using (SqlConnection sql = new SqlConnection (_connectionString)) {
                using (SqlCommand cmd = new SqlCommand ("PPIS.PPU_P_GET_PPM_GL_DEPARTMENT", sql)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<PGS007Model> ();
                    await sql.OpenAsync ();
                    using (var reader = await cmd.ExecuteReaderAsync ()) {
                        while (await reader.ReadAsync ()) {
                            response.Add (MapToValueMM (reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData (PGS007SaveDto value) {
            using (SqlConnection sql = new SqlConnection (_connectionString)) {
                using (SqlCommand cmd = new SqlCommand ("PPIS.PPU_P_SAVE_PPM_GL_DEPARTMENT", sql)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add (new SqlParameter ("@IN_DEPT_CODE", value.DEPT_CODE));
                    cmd.Parameters.Add (new SqlParameter ("@IN_DEPT_NAME", value.DEPT_NAME));
                    cmd.Parameters.Add (new SqlParameter ("@IN_USER_ID", value.USER_ID));
                    cmd.Parameters.Add (new SqlParameter ("@IN_DEPT_EMAIL1", value.DEPT_EMAIL1));
                    cmd.Parameters.Add (new SqlParameter ("@IN_DEPT_EMAIL2", value.DEPT_EMAIL2));
                    cmd.Parameters.Add (new SqlParameter ("@IN_DEPT_MAILS", value.DEPT_MAILS));
                    cmd.Parameters.Add (new SqlParameter ("@IN_DEPT_FMAILS", value.DEPT_FMAILS));

                    await sql.OpenAsync ();
                    await cmd.ExecuteNonQueryAsync ();
                    return;
                }
            }
        }
    }
}