using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FizzBuzzEntity.Data;
using FizzBuzzEntity.Models;

namespace FizzBuzzEntity.Pages
{
    public class CreateNewModel : PageModel
    {
        private readonly FizzBuzzEntity.Data.FizzBuzzContext _context;

        public CreateNewModel(FizzBuzzEntity.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            FizzBuzz.SessionId = HttpContext.Session.Id;
            FizzBuzz.dateTime = DateTime.Now;
            _context.FizzBuzz.Add(FizzBuzz);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
