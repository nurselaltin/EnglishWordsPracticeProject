using Business.Abstract;
using Entities.Concrete;
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

        [HttpGet]
        public IActionResult Add()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Add(Word word)
        {

            _wordService.Add(word);

            return RedirectToAction("Index");

        }

        
        public IActionResult UpdateView(int id)
        {

            var word = _wordService.Get(id);

            return View(word);

        }

        public IActionResult Update(Word word)
        {

            _wordService.Update(word);

            return RedirectToAction("Index");

        }

        public IActionResult Search(string name)
        {

            var word = _wordService.GetByName(name);

            return View(word);

        }


    }
}
