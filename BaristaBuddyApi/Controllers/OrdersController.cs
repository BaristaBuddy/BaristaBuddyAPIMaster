﻿using BaristaBuddyApi.Models;
using BaristaBuddyApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaristaBuddyApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class OrdersController :ControllerBase
    {
        IOrdersRepository orderRepository;

        public OrdersController(IOrdersRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        // GET: api/ordes made by user
        [HttpGet("{userid}")]
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrders(string userid)
        {
            return Ok(await orderRepository.GetAllOrders(userid));

        }

        // GET: api/ordes
        [HttpGet ("{id}")]

        public async Task<ActionResult<Orders>> GetOneOrder(int id)
        {
            return Ok(await orderRepository.GetOneOrder(id));
        }
    }
}
