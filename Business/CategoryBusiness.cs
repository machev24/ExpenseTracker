﻿using Data;
using Data.Models;

/// <summary>
/// Expense Tracker Business namespace
/// </summary>
namespace Business
{
    /// <summary>
    /// Category Business logic class
    /// </summary>
    public class CategoryBusiness
    {
        private Context categoryContext;

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns> Categories Collections </returns>
        public List<Category> GetAll()
        {
            using (categoryContext = new Context())
            {
                return categoryContext.Categories.ToList();
            }
        }

        /// <summary>
        /// Get Single Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category Get(int id)
        {
            using (categoryContext = new Context())
            {
                return categoryContext.Categories.Find(id);
            }
        }

        /// <summary>
        /// Add Category
        /// </summary>
        /// <param name="category"> Category </param>
        public void Add(Category category)
        {
            using (categoryContext = new Context())
            {
                //Add Category
                categoryContext.Categories.Add(category);
                //Save Changes to Database
                categoryContext.SaveChanges();
            }

        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="category"> Category </param>
        /// <exception cref="Exception">If Entry Is Not Found</exception>
        public void Update(Category category)
        {
            using (categoryContext = new Context())
            {
                var oldCategories = categoryContext.Categories.Find(category.Id);
                if (oldCategories != null)
                {
                    //Update Category Values
                    categoryContext.Entry(oldCategories).CurrentValues.SetValues(category);
                    //Save Changes to Database
                    categoryContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entry not found!");
                }
            }
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="id">Category</param>
        /// <exception cref="Exception"> If Entry Is Not Found </exception>
        public void Delete(int id)
        {
            using (categoryContext = new Context())
            {
                var category = categoryContext.Categories.Find(id);

                if (category != null)
                {
                    //Delete Category
                    categoryContext.Categories.Remove(category);
                    //Save Changes to Database
                    categoryContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entry not found!");
                }
            }
        }
    }
}