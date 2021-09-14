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

           var result =  _wordService.Add(word);

            if (!result)
            {
                //ViewBag.IsExist = true;
                return View();
            }

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

        public IActionResult Search()
        {

          
            return View();

        }

        [HttpPost]
        public IActionResult Search(string name)
        {

            var word = _wordService.GetByName(name);

            if(word == null)
            {
                ViewBag.IsNull = false;
            }

            return View(word);

        }


    }
}
