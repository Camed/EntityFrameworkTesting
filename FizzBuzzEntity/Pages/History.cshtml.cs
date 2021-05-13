using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzEntity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzEntity.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly FizzBuzzEntity.Data.FizzBuzzContext _context;

        public HistoryModel(FizzBuzzEntity.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IEnumerable<FizzBuzz> FizzBuzzList { get; set; }
        public void OnGet()
        {
            FizzBuzzList = (from x in _context.FizzBuzz orderby x.dateTime descending select x).Take(10);
        }
    }
}
