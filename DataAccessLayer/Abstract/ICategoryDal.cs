using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
     public interface ICategoryDal
    {
        //CRUD
        //Type Name ();
        List<Category> List(); //Listeleme islemi için.

        void Insert(Category p); // Ekleme islemi için.

        void Update(Category p); //Guncelleme islemi için.

        void Delete(Category p); //Silme islemi için.
    }
}
