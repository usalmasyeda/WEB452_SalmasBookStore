﻿using Microsoft.AspNetCore.Mvc;
using SalmasBook.DataAccess.Repository;
using SalmasBook.DataAccess.Repository.IRepository;
using SalmasBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalmasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for Upsert
        {
            Category category = new Category();
            if (id == null)
            {
                //this is for create
                return View(category);
            }
            //this for the edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)  //Checks all validations in the model
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                    /*  _unitOfWork.Save();*/
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }                  
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index)); // to see all the categories
            }
            return View(category);
        }

        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        { 
            //return not found
        var allObj =_unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
            #endregion
        }
}

}
