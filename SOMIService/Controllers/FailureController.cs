using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SOMIService.Data;
using SOMIService.Extensions;
using SOMIService.Models;
using SOMIService.Models.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly MyContext _dbContext;

        public FailureController(MyContext context, IMapper mapper, UserManager<ApplicationUser> userManager,MyContext dbContext)
        {
            _mapper = mapper;
            _context = context;
            _userManager=userManager;
            _dbContext = dbContext;
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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddFailureLogging()
        {
            var user = await _userManager.FindByIdAsync(HttpContext.GetUserId());
            if (user == null) return BadRequest(string.Empty);
            ViewBag.UserName = user.UserName;
            ViewBag.Email = user.Email;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFailureLogging(FailureViewModel model)
        {
            //var data = _mapper.Map<FailureLogging>(model);
            var data = new FailureLogging()
            {
                
                UserId = HttpContext.GetUserId(),
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                Description = model.Description,
                CreatedDate = model.CreatedDate


            };

            _dbContext.FailureLoggings.Add(data);
            _dbContext.SaveChanges();

            return RedirectToAction("Index","Home");
        }


    }
}
