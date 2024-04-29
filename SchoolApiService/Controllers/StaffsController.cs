using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.DAL.SchoolContext;
using SchoolApp.Models.DataModels;

namespace SchoolApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public StaffsController(SchoolDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staff>>> GetdbsStaff()
        {
            return await _context.dbsStaff
                .Include(m => m.Department)
                .Include(m => m.StaffSalary)
                .Include(m => m.StaffExperiences)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> GetStaff(int id)
        {
            var staff = await _context.dbsStaff
                .Include(m => m.Department)
                .Include(m => m.StaffSalary)
                .Include(m => m.StaffExperiences)
                .FirstOrDefaultAsync(m => m.StaffId == id);

            if (staff == null)
            {
                //return NotFound();
                return NotFound("Sorry! No Staff is found. Try next time. Good luck.");
            }

            return staff;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.StaffId)
            {
                return BadRequest();
            }

            _context.Entry(staff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            _context.dbsStaff.Add(staff);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaff", new { id = staff.StaffId }, staff);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var staff = await _context.dbsStaff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }

            _context.dbsStaff.Remove(staff);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StaffExists(int id)
        {
            return _context.dbsStaff.Any(e => e.StaffId == id);
        }
    }
}
