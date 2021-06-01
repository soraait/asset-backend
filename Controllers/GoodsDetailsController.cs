using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsDetailsController : ControllerBase
    {
        private readonly GoodsDetailContext _context;

        public GoodsDetailsController(GoodsDetailContext context)
        {
            _context = context;
        }

        // GET: api/GoodsDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoodsDetail>>> GetGoodsDetail()
        {
            return await _context.GoodsDetail.ToListAsync();
        }

        // GET: api/GoodsDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GoodsDetail>> GetGoodsDetail(int id)
        {
            var goodsDetail = await _context.GoodsDetail.FindAsync(id);

            if (goodsDetail == null)
            {
                return NotFound();
            }

            return goodsDetail;
        }

        // PUT: api/GoodsDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoodsDetail(int id, GoodsDetail goodsDetail)
        {
            if (id != goodsDetail.GoodsID)
            {
                return BadRequest();
            }

            _context.Entry(goodsDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoodsDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GoodsDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GoodsDetail>> PostGoodsDetail(GoodsDetail goodsDetail)
        {
            _context.GoodsDetail.Add(goodsDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGoodsDetail", new { id = goodsDetail.GoodsID }, goodsDetail);
        }

        // DELETE: api/GoodsDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoodsDetail(int id)
        {
            var goodsDetail = await _context.GoodsDetail.FindAsync(id);
            if (goodsDetail == null)
            {
                return NotFound();
            }

            _context.GoodsDetail.Remove(goodsDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GoodsDetailExists(int id)
        {
            return _context.GoodsDetail.Any(e => e.GoodsID == id);
        }
    }
}
