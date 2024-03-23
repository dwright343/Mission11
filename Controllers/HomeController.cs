using Mission11.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mission11.Models;
using Mission11.Models.ViewModels;

namespace Mission11.Controllers
{
    public class HomeController : Controller
    {
        private I_Repository _repo;
        public HomeController(I_Repository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum) // name this pageNum, because "page" means something to the .NET environment
        {
            int pageSize = 10;
            var PageInfo = new DefaultListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(PageInfo);
        }
    }
}
