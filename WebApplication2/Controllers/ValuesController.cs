using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public TXWDBContext db; private IConfiguration configuration;
        public ValuesController(TXWDBContext db,
            IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            try
            {
                var query = from o in db.FellowActivity
                            where o.Id == id
                            select o.Title;
                var title = query.SingleOrDefault();
                return new string[] { "value1", title };
            }
            catch (Exception ex)
            {
                return new string[] { ex.Message };
            }
        }

        [HttpGet]
        [Route("Redis")]
        public ActionResult Redis()
        {
            try
            {
                ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(configuration.GetSection("RedisAddress").Value);
                // 日常应用的核心类库是IDatabase
                IDatabase db = redis.GetDatabase();
                return Ok(db.StringGet("LWTCHToken:L0d568d8fe0914b63ba1c9698eb678225"));
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
