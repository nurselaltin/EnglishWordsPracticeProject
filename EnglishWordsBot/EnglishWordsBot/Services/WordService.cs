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

        public WordService(string url)
        {
            _driver = new ChromeDriver();
            _url = url;
        }



        public void Handle()
        {

            _driver.Navigate().GoToUrl(_url);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Siteye Gidildi!");


            //Table - 1

           IWebElement webElement = _driver.FindElement(By.XPath("/html/body/div[2]/div/div/section/div[2]/div/main/div/article/div/div[2]/table[1]"));

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

                            if (name is not null)
                            {
                                word.Name = name;
                                Console.WriteLine("Name : " + word.Name);
                            }

                            break;

                        case 2:
                            string meaning = wordInfo.Text.ToLower();


                            if (meaning is not null)
                            {
                                word.Meaning = meaning;
                                Console.WriteLine("Meaning : " + word.Meaning);
                            }

                            break;
                    }

                
                    count += 1;
                    
                }

               
                
                Console.WriteLine("---------------------------------------------------------------------");


            }


            Console.WriteLine("Table - 1 finished ---------------------------------------------------------------------");

            _driver.Close();

        }


    }
}
