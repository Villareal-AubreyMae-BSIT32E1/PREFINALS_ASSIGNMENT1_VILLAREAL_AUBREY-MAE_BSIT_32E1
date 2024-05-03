using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProtectedApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("user-info")]
        public IActionResult GetUserInfo()
        {
            // Retrieve user information (name, section, course)
            var userInfo = new
            {
                Name = "Aubrey Mae",
                Section = "32E1",
                Course = "BSIT"
            };

            // Fun facts about the API creator
            var funFacts = new List<string>
            {
            "New to this topics.",
            "Finding joy in exploring coding.",
            "Im more comfy to designing.",
            "Working on improving at this subject.",
            "Wanting to expand my knowledge.",
            "Enjoying the vibes of coding.",
            "Finding joy to relieve my stress.",
            "Seeing opportunities for experience and growth.",
            "Loving my journey in this course.",
            "Excited about more projects to gain more knowledge.",

               
            };

            var data = new
            {
                UserInfo = userInfo,
                FunFacts = funFacts
            };

            return Ok(data);
        }
    }
}
