using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsPracticeConsole.Services
{
    public class WordService
    {
        IWordService _wordService;

        public WordService(IWordService wordService)
        {
            _wordService = wordService;
        }


        public bool Add(Word newWord)
        {


            var isExistWord = _wordService.GetByName(newWord.Name);


            if (isExistWord is null)
            {

                Word word = new Word();
                word.Name = newWord.Name.ToString();
                word.Meaning = newWord.Meaning.ToString();
                word.Level = newWord.Level.ToString();

                _wordService.Add(word);

                return true;


            }
            else
            {


                return false;

            }


        }

        public bool Update(Word updateWord)
        {

            var word = _wordService.GetByName(updateWord.Name);

            if (word is null)
            {
                return false;
            }
            else
            {

                word.Name = updateWord.Name.ToString();
                word.Meaning = updateWord.Meaning.ToString();
                word.Level = updateWord.Level.ToString();

                _wordService.Update(word);

                return true;


            }




        }


        public List<Word>  GetAll()
        {
           


            return _wordService.GetAll();

        }


        public List<Word> GetByLevel(string level)
        {

           

            return _wordService.GetByLevel(level);


        }


        public Word GetByName(string name)
        {

            

            return _wordService.GetByName(name);


        }

   
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
