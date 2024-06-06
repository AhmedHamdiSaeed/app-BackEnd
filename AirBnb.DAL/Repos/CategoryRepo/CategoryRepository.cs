﻿using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.CategoryRepo
{
	public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
	{
		private readonly AppDbContext _context;
		public CategoryRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

        public async Task<Category> GetPropertiesOfCategory(int categoryId)
        {
                return await _context.Set<Category>()
                                     .Include(c => c.Properties)
                                     .FirstOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
