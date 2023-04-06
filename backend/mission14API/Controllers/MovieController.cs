using Microsoft.AspNetCore.Mvc;
using mission14API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission14API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDBContext context;
        public MovieController(MovieDBContext temp)
        {
            context = temp;
        }
        public IEnumerable<MovieCollection> Get()
        {
            
            return context.Movies.ToArray();
        }
    }
}
