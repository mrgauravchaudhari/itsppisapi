using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers.ledgers.electrical
{
     [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]

    public class POR016Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public POR016Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }



        [HttpGet("{month}")]
        public async Task<DataSet> get(string month)
        {
            try
            {
                string strqry = "[PPIS].[PPU_P_OU1_ML_KS_LS_STEAM_DTL_POR016]";

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

    // public class POR016Controller : ApiController, Syncfusion.EJ.ReportViewer.IReportController
    // {
    //     // Report viewer requires a memory cache to store the information of consecutive client request and
    //     // have the rendered report viewer information in server.
    //     private Microsoft.Extensions.Caching.Memory.IMemoryCache _cache;

    //     // IHostingEnvironment used with sample to get the application data from wwwroot.
    //     private Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

    //     // Post action to process the report from server based json parameters and send the result back to the client.
    //     public HomeController(Microsoft.Extensions.Caching.Memory.IMemoryCache memoryCache,
    //         Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
    //     {
    //         _cache = memoryCache;
    //         _hostingEnvironment = hostingEnvironment;
    //     }

    //     public IActionResult Index()
    //     {
    //         return View();
    //     }

    //     ...
    //     ...
    //     ...

    //     // Post action to process the report from server based json parameters and send the result back to the client.
    //     public object PostReportAction([FromBody] Dictionary<string, object> jsonArray)
    //     {
    //         return Syncfusion.EJ.ReportViewer.ReportHelper.ProcessReport(jsonArray, this, this._cache);
    //     }

    //     // Method will be called to initialize the report information to load the report with ReportHelper for processing.
    //     public void OnInitReportOptions(Syncfusion.EJ.ReportViewer.ReportViewerOptions reportOption)
    //     {
    //         string basePath = _hostingEnvironment.WebRootPath;
    //         // Here, we have loaded the sample report report from application the folder wwwroot. Sample.rdl should be there in wwwroot application folder.
    //         FileStream reportStream = new FileStream(basePath + @"\invoice.rdl", FileMode.Open, FileAccess.Read);
    //         reportOption.ReportModel.Stream = reportStream;
    //     }

    //     // Method will be called when reported is loaded with internally to start to layout process with ReportHelper.
    //     public void OnReportLoaded(Syncfusion.EJ.ReportViewer.ReportViewerOptions reportOption)
    //     {
    //     }

    //     //Get action for getting resources from the report
    //     [ActionName("GetResource")]
    //     [AcceptVerbs("GET")]
    //     // Method will be called from Report Viewer client to get the image src for Image report item.
    //     public object GetResource(Syncfusion.EJ.ReportViewer.ReportResource resource)
    //     {
    //         return Syncfusion.EJ.ReportViewer.ReportHelper.GetResource(resource, this, _cache);
    //     }
    // }
}