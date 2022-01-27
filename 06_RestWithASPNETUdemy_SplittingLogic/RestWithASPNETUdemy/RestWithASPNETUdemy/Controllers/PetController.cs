using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PetController : ControllerBase
    {

        private readonly ILogger<PetController> _logger;
        private IPetBusiness _petBusiness;

        public PetController(ILogger<PetController> logger, IPetBusiness petBusiness)
        {
            _logger = logger;
            _petBusiness = petBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_petBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(_petBusiness.FindById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
           _petBusiness.Delete(id);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create([FromBody]Pet pet)
        {
            return Ok(_petBusiness.Create(pet));
        }


        [HttpPut]
        public IActionResult Update([FromBody] Pet pet)
        {
            if (pet == null) return BadRequest();
            return Ok(_petBusiness.Update(pet));
        }

    }
}