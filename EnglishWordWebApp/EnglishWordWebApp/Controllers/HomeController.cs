using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishWordWebApp.Controllers
{
    public class HomeController : Controller
    {

        IWordService _wordService;

        public HomeController(IWordService wordService)
        {
            _wordService = wordService;
        }

        public IActionResult Index()
        {

            var words = _wordService.GetAll();


            return View(words);
        }
    }
}
