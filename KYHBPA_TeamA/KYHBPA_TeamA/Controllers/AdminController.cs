using KYHBPA_TeamA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace KYHBPA_TeamA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditPhotos(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.Title = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var photoViewModels = db.Photos.Select(p => new DisplayPhotosViewModel()
            {
                Id = p.PhotoID,
                Data = p.PhotoData,
                Description = p.PhotoDesc,
                Title = p.PhotoTitle,
                Date = p.TimeStamp,
                InPhotoGallery = p.InPhotoGallery

            });

            if (!String.IsNullOrEmpty(searchString))
            {
                photoViewModels = photoViewModels.Where(p => p.Title.Contains(searchString)
                                       || p.Description.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "title_desc":
                    photoViewModels = photoViewModels.OrderByDescending(s => s.Title);
                    break;
                case "Date":
                    photoViewModels = photoViewModels.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    photoViewModels = photoViewModels.OrderByDescending(s => s.Date);
                    break;
                default:  // Title ascending 
                    photoViewModels = photoViewModels.OrderBy(s => s.Title);
                    break;
            }


            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(photoViewModels.ToPagedList(pageNumber, pageSize));

            return View();
        }

    }
}