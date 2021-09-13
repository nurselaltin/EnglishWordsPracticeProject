using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWordService
    {

        bool Add(Word word);
        bool Update(Word word);

        void Delete(int id);

        List<Word> GetAll();

        Word GetByName(string name);

        List<Word> GetByLevel(string level);

        Word Get(int id);


    }
}
