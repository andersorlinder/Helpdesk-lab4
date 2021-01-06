using IT_Helpdesk.DbContexts;
using IT_Helpdesk.Models;
using IT_Helpdesk.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IT_Helpdesk.Controllers
{
    [Controller]
    [Route("[Controller]")]
    public class IT_HelpdeskController : Controller
    {
        private IT_HelpdeskDbContext context;

        public IT_HelpdeskController(IT_HelpdeskDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {

            return Ok("Get Works");
        }

        [HttpPost]
        [Route("submit")]
        public async Task<IActionResult> Submit([FromBody] SubmitRequest request)
        {
            var submittedReq = new IT_HelpdeskModel
            {
                Title = request.Title,
                Type = request.Type,
                Date = request.Date
            };          
            context.IT_Helpdesk.Add(submittedReq);
            var savedToDb = await context.SaveChangesAsync();

            if (savedToDb == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}