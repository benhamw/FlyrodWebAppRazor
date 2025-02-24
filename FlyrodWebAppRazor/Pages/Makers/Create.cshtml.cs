﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FlyrodWebAppRazor.Data;
using FlyrodWebAppRazor.Models;

namespace FlyrodWebAppRazor.Pages.Makers
{
    public class CreateModel : PageModel
    {
        private readonly FlyrodWebAppRazor.Data.FlyrodWebAppRazorContext _context;

        public CreateModel(FlyrodWebAppRazor.Data.FlyrodWebAppRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Maker Maker { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          //if (!ModelState.IsValid)
          //  {
          //      return Page();
          //  }

            _context.Maker.Add(Maker);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
