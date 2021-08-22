﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSD_Project_CC2004V_Team02.Models;

namespace WSD_Project_CC2004V_Team02.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Member,Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public IEnumerable<Orders> GetOrders()
        {
            if (User.FindFirstValue(ClaimTypes.Role) == "Admin")
            {
                return _context.Orders;
            } else
            {
                var orders = _context.Orders.Where(Orders => Orders.Customer_ID.Contains(User.FindFirstValue(ClaimTypes.NameIdentifier)));
                return orders;
            }
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrders([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _context.Orders.FindAsync(id);

            if (orders == null)
            {
                return NotFound();
            }

            if (User.FindFirstValue(ClaimTypes.Role) != "Admin")
            {
                if (orders.Customer_ID != User.FindFirstValue(ClaimTypes.NameIdentifier))
                {
                    return Forbid();
                }
            }

            return Ok(orders);
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrders([FromRoute] int id, [FromBody] Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orders.Id)
            {
                return BadRequest();
            }

            var order = await _context.Orders.FindAsync(id);

            if (User.FindFirstValue(ClaimTypes.Role) != "Admin")
            {
                if (orders.Customer_ID != User.FindFirstValue(ClaimTypes.NameIdentifier))
                {
                    return Forbid();
                }
            }

            orders.Customer_ID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.Entry(orders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(id))
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

        // POST: api/Orders
        [HttpPost]
        public async Task<IActionResult> PostOrders([FromBody] Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            orders.Customer_ID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            _context.Orders.Add(orders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrders", new { id = orders.Id }, orders);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrders([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }

            if (User.FindFirstValue(ClaimTypes.Role) != "Admin")
            {
                if (orders.Customer_ID != User.FindFirstValue(ClaimTypes.NameIdentifier))
                {
                    return Forbid();
                }
            }

            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();

            return Ok(orders);
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}