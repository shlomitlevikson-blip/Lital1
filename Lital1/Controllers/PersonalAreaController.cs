using Lital1.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Lital1.Controllers
{
    [ApiController]
    [Route("api/personalarea")]
    //[Authorize]
    public class PersonalAreaController : Controller
    {
        //AppDbContext _context;
        private readonly ILogger<PersonalAreaController> _logger;

        public PersonalAreaController(/*AppDbContext context,*/ ILogger<PersonalAreaController> logger)
        {
            /*_context = context;*/
            _logger = logger;
        }

        /*[HttpGet("showAllSpareParts")]
        public IActionResult ShowAllSpareParts()
        {
            try
            {
                var allProducts = _context.SpareParts.ToList();
                return Ok(allProducts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/

        [HttpGet("showAllSpareParts")]
        public IActionResult ShowAllSpareParts()
        {
            var json = System.IO.File.ReadAllText("spareparts.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = System.Text.Json.JsonSerializer
                .Deserialize<List<SparePart>>(json, options);

            return Ok(data);
        }

        /*[HttpGet("export")]
        public IActionResult Export()
        {
            var data = _context.SpareParts.ToList();
            return Ok(data);
        }*/
    }
}
