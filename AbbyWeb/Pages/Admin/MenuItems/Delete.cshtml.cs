using Abby.DataAccess.Data;
using Abby.DataAccess.Repository.IRepository;
using Abby.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWeb.Pages.Admin.MenuItems;

[BindProperties]
public class DeleteModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    //? 
    public Category? Category { get; set; }

    public DeleteModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public void OnGet(int id)
    {
        Category = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
    }

    public async Task<IActionResult> OnPost()
    {
        var categoryFromDb = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == Category.Id);
        if (categoryFromDb != null)
        {
            _unitOfWork.Category.Remove(categoryFromDb);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");

        }

        return Page();
    }
}

