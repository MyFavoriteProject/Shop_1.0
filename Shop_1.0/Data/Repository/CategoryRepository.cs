﻿using Shop_1._0.Data.Interfaces;
using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Repository
{
    public class CategoryRepository : IBooksCategory
    {
        private readonly AppDBContent _appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => _appDBContent.Category;
    }
}
