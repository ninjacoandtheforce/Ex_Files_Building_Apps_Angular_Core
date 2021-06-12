﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quiz_backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Questions")]
    public class QuestionsController : Controller
    {
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return new Models.Question[] {
                new Models.Question() { Text = "hello"},
                new Models.Question() { Text = "hi"}
            };
        }

        [HttpPost]
        public void Post([FromBody]Models.Question question)
        {

        }
    }
}