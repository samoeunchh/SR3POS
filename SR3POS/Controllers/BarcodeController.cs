using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SR3POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SR3POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BarcodeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // 
        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            var product = await (from p in _context.Product
                                 join pp in _context.ProductPrice on p.UnitId equals pp.UnitId
                                 where p.Barcode.Equals(code)
                                 select new
                                 {
                                     p.ProductId,
                                     p.ProductName,
                                     p.Cost,
                                     p.OnHand,
                                     p.Barcode,
                                     pp.Price,
                                     p.UnitId
                                 }).FirstOrDefaultAsync();
            return Ok(product);
        }
    }
}
