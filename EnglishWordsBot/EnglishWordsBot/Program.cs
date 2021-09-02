using EnglishWordsBot.DataAccess;
using EnglishWordsBot.Services;
using System;

namespace EnglishWordsBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WordService service = new WordService("https://www.english.web.tr/c1-level-word-list/", new  EnglishWordsBotContext());
            service.Handle();
        }
    }
}
