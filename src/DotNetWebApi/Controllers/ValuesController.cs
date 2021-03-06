﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
		/// <summary>
		/// GET api/values
		/// </summary>
		/// <returns>string</returns>
		[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Value 1", "Value 2" };
        }

		/// <summary>
		/// GET api/values/5
		/// </summary>
		/// <param name="id">id number</param>
		/// <returns>string result</returns>
		[HttpGet("{id}")]
        public string Get(int id)
        {
	        return "value(" + id + ")";
        }

		/// <summary>
		/// POST api/values
		/// </summary>
		/// <param name="value"></param>
		[HttpPost]
        public void Post([FromBody]string value)
        {
        }

		/// <summary>
		/// PUT api/values/5
		/// </summary>
		/// <param name="id"></param>
		/// <param name="value"></param>
		[HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

		/// <summary>
		/// DELETE api/values/5
		/// </summary>
		/// <param name="id"></param>
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
