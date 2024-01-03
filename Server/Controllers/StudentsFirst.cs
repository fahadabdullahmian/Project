using Microsoft.AspNetCore.Mvc;
using Web_API.Server.Data;
using Web_API.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Server.Controllers
{
    [Route("api/V1[controller]")]
    [ApiController]
    public class StudentsFirst : ControllerBase
    {
        AppDbContext _appDbContext;

        public StudentsFirst(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: api/<StudentsFirst>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("/Stud")]
        public IEnumerable<Student> GetStudent()
        {
            return _appDbContext.Stude.ToList();
        }
        // GET api/<StudentsFirst>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentsFirst>
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                _appDbContext.Stude.Add(student);
                _appDbContext.SaveChanges();

                return Ok("Save successfuly");
            }
            catch
            {
                return BadRequest();
            }
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        // DELETE api/<StudentsFirst>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
