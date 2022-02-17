using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SOMIService.Data;
using SOMIService.Extensions;
using SOMIService.Models;
using SOMIService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.Controllers
{
    public class FailureController : Controller
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public FailureController(MyContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [Authorize]
        public IActionResult GetFailureLogging()
        {
            var UserId = HttpContext.GetUserId();      
           
                var data = _context.FailureLoggings
              .OrderByDescending(x => x.CreatedDate)
              .ToList()
              .Select(x => _mapper.Map<FailureViewModel>(x))
              .ToList();

                return View(data);          
            //catch (Exception)
            //{
            //    TempData["Model"] = new ErrorViewModel()
            //    {
            //        Text = $"Bir hata oluştu {ex.Message}",
            //        ActionName = "Index",
            //        ControllerName = "Home",
            //        ErrorCode = 500
            //    };
            //    return RedirectToAction("Error", "Home");
            //}



        }

        [HttpGet]
        public IActionResult AddFailureLogging()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFailureLogging(FailureViewModel failureViewModel)
        {

            //var data
            return View();
        }


    }
}
