using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyLibraryApp.Data;
using MyLibraryApp.Model;

namespace MyLibraryApp.Pages.Books
{
    [Authorize(Policy = "LoggedInUsersOnly")]
    public class RentModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }
        public User User { get; set; }

        private readonly LibraryDbContext _context;

        public RentModel(LibraryDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Book = _context.Book.Find(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            int userId = int.Parse(HttpContext.User.Identity.Name);  // cheeky cheeky Name = User.Id :>
            Book.MemberId = userId;

            _context.Book.Update(Book);
            await _context.SaveChangesAsync();
            
            TempData["Success"] = "The book has been rented successfuly.";

            return RedirectToPage("/Books/Index");
        }
    }
}
