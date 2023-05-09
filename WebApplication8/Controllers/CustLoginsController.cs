using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustLoginsController : ControllerBase
    {
        private readonly CustDbContext _context;

        public CustLoginsController(CustDbContext context)
        {
            _context = context;
        }

        // GET: api/CustLogins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustLogin>>> GetCustLogin()
        {
          if (_context.CustLogin == null)
          {
              return NotFound();
          }
            return await _context.CustLogin.ToListAsync();
        }

        // GET: api/CustLogins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustLogin>> GetCustLogin(int id)
        {
          if (_context.CustLogin == null)
          {
              return NotFound();
          }
            var custLogin = await _context.CustLogin.FindAsync(id);

            if (custLogin == null)
            {
                return NotFound();
            }

            return custLogin;
        }

        // PUT: api/CustLogins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustLogin(int id, CustLogin custLogin)
        {
            if (id != custLogin.LoginId)
            {
                return BadRequest();
            }

            _context.Entry(custLogin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustLoginExists(id))
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

        // POST: api/CustLogins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustLogin>> PostCustLogin(CustLogin custLogin)
        {
          if (_context.CustLogin == null)
          {
              return Problem("Entity set 'CustDbContext.CustLogin'  is null.");
          }
            _context.CustLogin.Add(custLogin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustLogin", new { id = custLogin.LoginId }, custLogin);
        }

        // DELETE: api/CustLogins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustLogin(int id)
        {
            if (_context.CustLogin == null)
            {
                return NotFound();
            }
            var custLogin = await _context.CustLogin.FindAsync(id);
            if (custLogin == null)
            {
                return NotFound();
            }

            _context.CustLogin.Remove(custLogin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustLoginExists(int id)
        {
            return (_context.CustLogin?.Any(e => e.LoginId == id)).GetValueOrDefault();
        }
    }
}
