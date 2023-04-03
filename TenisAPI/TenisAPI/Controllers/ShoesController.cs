using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TenisAPI.Context;

namespace TenisAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoesController : Controller
    {

        private readonly AppContextData _db;
        public ShoesController(AppContextData db)
        {
            _db = db;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var Shoes = await _db.Shoes.ToListAsync();

                return Ok(Shoes);   

            }catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpGet("{modelo}/GetModelo")]
        public async Task<IActionResult> GetByModelo(string modelo)
        {
            try
            {
                var Shoes =  await _db.Shoes.Where(x => x.Modelo.ToUpper() == modelo).ToListAsync();

                return Ok(Shoes);

            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        

        [HttpGet("{marca}/GetMarca")]
        public async Task<IActionResult> GetByMarca(string marca)
        {
            try
            {
                var Shoes = await _db.Shoes.Where(x => x.Marca.ToUpper() == marca).ToListAsync();

                return Ok(Shoes);

            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
    }
}