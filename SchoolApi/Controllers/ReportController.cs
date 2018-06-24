using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.DataAccess.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/report")]
    public class ReportController : ControllerBase
    {
        // GET api/values
        [HttpGet("/getoverallresults")]
        [Produces("application/json")]
        public ActionResult<OverallResults> GetOverallResults()
        {
            return new OverallResults();
        }
    }
}
