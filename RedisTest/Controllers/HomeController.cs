using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedisTest.Models;
using StackExchange.Redis;

namespace RedisTest.Controllers
{
    public class HomeController : Controller
    {
        public IDatabase Redis => RedisConnection.RedixDatabase;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete(string key)
        {
            if (!Redis.KeyExists(key))
                return Json(new EasyResult("Key does not exist"));

            Redis.KeyDelete(key);
            
            return Json(new EasyResult("Key has been deleted"));
        }
        
        public IActionResult Set(string key, string value)
        {
            if (Redis.KeyExists(key))
                return Json(new EasyResult("Key already exists"));
            
            Redis.StringSet(key, value);
            
            return Json(new EasyResult("Value has been set"));
        }
        
        public IActionResult Get(string key)
        {
            if (!Redis.KeyExists(key))
                return Json(new EasyResult("Key does not exist"));

            var data = Redis.StringGet(key);
            
            return Json(new EasyResult("Key found", data.ToString()));
        }
    }
}
