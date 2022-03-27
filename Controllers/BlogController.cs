using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Linq;
using WebGoMarkets.Helper;
using WebGoMarkets.Models;

namespace WebGoMarkets.Controllers
{
    public class BlogController : Controller
    {
        private readonly dbMarketsContext _context;
        public BlogController(dbMarketsContext context)
        {
            _context = context;
        }
        [Route("blogs.html", Name="Blog")]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = Utilities.PAGE_SIZE;
            var lsTinDangs = _context.TinDangs.AsNoTracking().OrderByDescending(x => x.PostId);
            PagedList<TinDang> models = new PagedList<TinDang>(lsTinDangs, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [Route("/blogs/{Alias}-{id}.html", Name = "BlogDetails")]
        public IActionResult Details(int id)
        {
            var tinDang = _context.TinDangs.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (tinDang == null)
            
            {
                return RedirectToAction("index");
            }
            var lsRelatedBlogs = _context.TinDangs.AsNoTracking()
                    .Where(x => x.PostId != tinDang.CatId && x.Published == true)
                    .Take(4).OrderByDescending(x => x.CreatedDate)
                    .ToList();
            ViewBag.lsRelatedBlogs = lsRelatedBlogs;
            return View(tinDang);
        }
    }
}
