using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WordManager :IWordService
    {

         IWordDal _wordDal;


        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }

        public bool Add(Word word)
        {

           return _wordDal.Add(word);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Word GetByName(string name)
        {

            return _wordDal.Get(x => x.Name == name);

        }

        public List<Word> GetAll()
        {
            return _wordDal.GetAll() ;
        }

        public List<Word> GetByLevel(string level)
        {
            return _wordDal.GetAll(x => x.Level == level);
        }

        public bool Update(Word word)
        {

            return _wordDal.Update(word);

        }

        public Word Get(int id)
        {
            return _wordDal.Get( x => x.Id == id);
        }
    }
}
