﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }




        // GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL() //BL: BusinessLayer 
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBL(Category p)
        //{
        //    if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length >= 51)
        //    {
        //        //Hata mesajı içi ayrı bir sınıf oluşturacağız.
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }

        //}
        public List<Category> GetList()
        {
            return 
        }
    }
}
