﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;

namespace cfclapi.Controllers.ledgers.electrical
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]

    public class PTR2TP0017Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PTR2TP0017Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{month}/{vers}")]
        public async Task<DataSet> get(string month, int vers)
        {
            try
            {
                string strqry = "[PPIS].PPU_P_TSE2_YR_RAW_WATER_BAL_PTR2TOP0017";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_YEAR", month));
                        cmd.Parameters.Add(new SqlParameter("@IN_VERSION", vers));
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