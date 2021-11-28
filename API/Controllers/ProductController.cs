﻿using API.Entites;
using core.Entites;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task< ActionResult<List<Product>>> GetProducts()
        {

            return Ok(await _context.Products.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task <ActionResult <Product>> GetProduct( int id)
        {
            return Ok(await _context.Products.FindAsync(id));
        }
    }
}
