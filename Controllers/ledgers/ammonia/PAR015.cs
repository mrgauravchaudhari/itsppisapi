﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;

namespace cfclapi.Controllers.ledgers.electrical
{
    // [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PAR015Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PAR015Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{month}")]
        public async Task<DataSet> get(string month)
        {
            try
            {
                string strqry = "[PPIS].PPU_P_AM1_YL_ALLOC_NG_NAP_UTILITY_PAR015";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_MNTH", month));
                        await sql.OpenAsync();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                DataSet ds = new DataSet(ex.Message.ToString());
                ds.AcceptChanges();
                return ds;
            }
        }
    }

}