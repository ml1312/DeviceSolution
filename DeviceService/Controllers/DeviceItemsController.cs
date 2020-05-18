using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Interfaces;

namespace DeviceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceItemsController : ControllerBase
    {
        private readonly DeviceDbContext _context;

        public DeviceItemsController(DeviceDbContext context)
        {
            _context = context;
        }

        // GET: api/DeviceItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceItem>>> GetDeviceItems()
        {
            return await _context.DeviceItems.ToListAsync();
        }

        // GET: api/DeviceItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceItem>> GetDeviceItem(string id)
        {
            var deviceItem = await _context.DeviceItems.FindAsync(id);

            if (deviceItem == null)
            {
                return NotFound();
            }

            return deviceItem;
        }

        // PUT: api/DeviceItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeviceItem(string id, DeviceItem deviceItem)
        {
            if (id != deviceItem.DeviceId)
            {
                return BadRequest();
            }

            _context.Entry(deviceItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceItemExists(id))
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

        // POST: api/DeviceItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DeviceItem>> PostDeviceItem(DeviceItem deviceItem)
        {
            _context.DeviceItems.Add(deviceItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeviceItemExists(deviceItem.DeviceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDeviceItem", new { id = deviceItem.DeviceId }, deviceItem);
        }

        // DELETE: api/DeviceItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeviceItem>> DeleteDeviceItem(string id)
        {
            var deviceItem = await _context.DeviceItems.FindAsync(id);
            if (deviceItem == null)
            {
                return NotFound();
            }

            _context.DeviceItems.Remove(deviceItem);
            await _context.SaveChangesAsync();

            return deviceItem;
        }

        private bool DeviceItemExists(string id)
        {
            return _context.DeviceItems.Any(e => e.DeviceId == id);
        }
    }
}
