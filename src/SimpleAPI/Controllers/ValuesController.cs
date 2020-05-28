using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "dotnet", "playbook" };
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "something else";
        }
    }
}