using EnglishWordsBot.DataAccess;
using EnglishWordsBot.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordsBot.Services
{
    public class WordService
    {


        private readonly IWebDriver _driver;

        public string _url;

        public EnglishWordsBotContext _context { get; set; }

        public WordService(string url, EnglishWordsBotContext context)
        {
            _driver = new ChromeDriver();
            _url = url;
            _context = context;
        }



        public void Handle()
        {

            _driver.Navigate().GoToUrl(_url);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Siteye Gidildi!");


            IWebElement webElement = _driver.FindElement(By.XPath("/html/body/div[2]/div/div/section/div[2]/div/main/div/article/div/div[2]"));


            

            IReadOnlyCollection<IWebElement> tables = webElement.FindElements(By.TagName("table"));

            IReadOnlyCollection<IWebElement> elements = webElement.FindElements(By.TagName("tr"));

            foreach (var item in elements)
            {
                Word word = new Word();
                IReadOnlyCollection<IWebElement> wordInfos = item.FindElements(By.TagName("td"));

                int count = 0;

                foreach (var wordInfo in wordInfos)
                {


                    switch (count)
                    {
                        case 1:
                            string name = wordInfo.Text.ToLower();

                            if (name != "")
                            {
                                word.Name = name;
                                Console.WriteLine("Name : " + word.Name);
                            }

                            break;

                        case 2:
                            string meaning = wordInfo.Text.ToLower();


                            if (meaning != "")
                            {
                                word.Meaning = meaning;
                                Console.WriteLine("Meaning : " + word.Meaning);
                            }

                            break;
                    }

                   
                    count += 1;
                

                



                }
                
                _context.Words.Add(word);
                _context.SaveChanges();

                Console.WriteLine("---------------------------------------------------------------------");


            }


            Console.WriteLine("Table - 1 finished ---------------------------------------------------------------------");

            


            _driver.Close();

        }


    }
}
