using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerManagement.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public List<SelectListItem> GetCategorySelection()
        {
            var categories = _repo.GetCategories();
            List<SelectListItem> listCategoriItems = categories.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            return listCategoriItems;
        }
    }
}
