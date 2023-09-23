using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.Service;
using Movie.Service.Interfaces;
using System.Diagnostics;

namespace Movie.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CountryModel model)
        {
            await _unitOfWork.Country.AddCountry(model);
            return RedirectToAction("Countries");
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await _unitOfWork.Country.GetCountry(id);
            return View(model);
        }


        public async Task<IActionResult> Countries()
        {
            List<CountryModel> allCountries = await _unitOfWork.Country.GetAllCountries();
            return View(allCountries);
        }
    }
}