using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicVilla_VillaAPI.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            return Ok(VillaStore.villaList.FirstOrDefault(u=>u.Id==id));
        }
    }
}

