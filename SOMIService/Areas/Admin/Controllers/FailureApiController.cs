using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOMIService.Data;
using SOMIService.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize(Roles ="Admin")]
    public class FailureApiController : Controller
    {
        private readonly MyContext _dbContext;

        public FailureApiController(MyContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            var data = _dbContext.FailureLoggings
                .Include(x => x.ApplicationUser)
                .OrderByDescending(x => x.CreatedDate)
                .ToList();
            return Ok(DataSourceLoader.Load(data, loadOptions));
        }

    }
}
