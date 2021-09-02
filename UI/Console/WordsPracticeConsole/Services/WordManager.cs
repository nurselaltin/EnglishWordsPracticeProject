using EnglishWordsBot.DataAccess;
using EnglishWordsBot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsPracticeConsole.Services
{
    public class WordManager
    {
        public EnglishWordsBotContext _context { get; set; }

        public WordManager(EnglishWordsBotContext context)
        {
            _context = context;
        }


        public bool Add(Word newWord)
        {

            var isExistWord = _context.Words.SingleOrDefault(x => x.Name == newWord.Name.ToString());

            if(isExistWord is null)
            {

                Word word = new Word();
                word.Name = newWord.Name.ToString();
                word.Meaning = newWord.Meaning.ToString();
                word.Level = newWord.Level.ToString();

                _context.Words.Add(word);
                _context.SaveChanges();

                return true;


            }
            else
            {


                return false;

            }


        }

        public bool Update(Word updateWord)
        {

            var word = _context.Words.SingleOrDefault(x => x.Name == updateWord.Name.ToString());

            if (word is null)
            {
                return false;
            }
            else
            {

                word.Name = updateWord.Name.ToString();
                word.Meaning = updateWord.Meaning.ToString();
                word.Level = updateWord.Level.ToString();

                _context.Words.Update(word);
                _context.SaveChanges();

                return true;


            }




        }


        public List<Word>  GetAll()
        {

            List<Word> words = _context.Words.ToList();

            return words;

        }


        public List<Word> GetByLevel(string level)
        {

            List<Word> words = _context.Words.Where(x => x.Level == level.ToLower()).ToList();

            return words;


        }


        public Word GetByName(string name)
        {

            Word words = _context.Words.SingleOrDefault(x => x.Name == name.ToString());

            return words;


        }


     








    }
}
