using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepo;

        public SongController(SongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        public ViewResult Index()
        {
            return View();
        }       

        public ViewResult Details( int id)
        {
            var model = songRepo.GetById(id);
            return View(model);
        }
    }
}
