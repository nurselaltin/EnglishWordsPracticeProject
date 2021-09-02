using EnglishWordsBot.DataAccess;
using EnglishWordsBot.Entities;
using System;
using System.Threading;
using WordsPracticeConsole.Services;

namespace WordsPracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("#####################################################################################");
            Console.WriteLine("You can see operations which you can do  below.Please choose one of them.");
            Console.WriteLine("#####################################################################################");
            Console.WriteLine("Add new Word (Add) or Update word (Update) or Get List Word (GetAll) or Get word by name (GetByName) or  Get word by level (GetByLevel)  ");
            Console.WriteLine("#####################################################################################");
            var result = Console.ReadLine();




            
            WordManager wordManager = new WordManager(new EnglishWordsBotContext());



            switch (result.ToString())
            {
                case "add":

                    Word word = new Word();

                    Console.WriteLine("Name");
                    word.Name = Console.ReadLine();

                    Console.WriteLine("Meaning");
                    word.Meaning = Console.ReadLine();

                    Console.WriteLine("Level");
                    word.Level = Console.ReadLine();

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

                            Console.WriteLine("Name : " + item.Name + "  - Meaning : " + item.Meaning + " - Level : " + item.Level );
                            Console.WriteLine("-----------------------");


                        }
                    }
                    break;

                case "update":



                    break;

                case "getall":

                    var list = wordManager.GetAll();

                    foreach (var item in list)
                    {

                        Console.WriteLine("Name : " + item.Name + "  - Meaning : " + item.Meaning + " - Level : " + item.Level );
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
