using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Threading;
using WordsPracticeConsole.Services;

namespace WordsPracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          

            bool isKeeping = true;

            while (isKeeping)
            {

                Console.WriteLine("Hello World!");
                Console.WriteLine("#####################################################################################");
                Console.WriteLine("You can see operations which you can do  below.Please choose one of them.");
                Console.WriteLine("#####################################################################################");
                Console.WriteLine("Add new Word (Add) or Update word (Update) or Get List Word (GetAll) or Get word by name (GetByName) or  Get word by level (GetByLevel)  ");
                Console.WriteLine("#####################################################################################");
                var result = Console.ReadLine();


                IWordDal wordDal = new EfWordDal();

                IWordService wordService = new WordManager(wordDal);

                WordService wordManager = new WordService(wordService);


                switch (result.ToString())
                {
                    case "add":

                        Word word = new Word();

                        Console.WriteLine("Name");
                        word.Name = Console.ReadLine().ToLower();

                        
                        Console.WriteLine("Meaning");

                        word.Meaning = Console.ReadLine().ToLower();

                        Console.WriteLine("Level");
                        word.Level = Console.ReadLine().ToLower();

                        bool AddResult = wordManager.Add(word);

                        if (!AddResult)
                        {
                            Console.WriteLine("Error!");

                        }
                        else
                        {
                            Console.WriteLine("Success!");
                            var listWord = wordManager.GetAll();

                            foreach (var item in listWord)
                            {

                                Console.WriteLine("Name : " + item.Name + "  - Meaning : " + item.Meaning + " - Level : " + item.Level);
                                Console.WriteLine("-----------------------");


                            }

                            Console.WriteLine("Do you want to keep to operations? (true / false)");
                            isKeeping = Convert.ToBoolean(Console.ReadLine());



                        }
                        break;

                    case "update":



                        break;

                    case "getall":

                        var list = wordManager.GetAll();

                        foreach (var item in list)
                        {

                            Console.WriteLine(item.Name + " : " + item.Meaning + "  : " + item.Level);
                            Console.WriteLine("-----------------------");

                        }

                        break;

                    case "getbyname":



                        break;

                    case "getbylevel":



                        break;
                    case "":

                        Console.WriteLine("Program shut down...");
                        Thread.Sleep(100);
                        Console.Clear();

                        break;






                }

            }


           




           
            





        }
    }
}
