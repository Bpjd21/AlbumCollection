using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        AlbumRepository albumRepo;

        public AlbumController(AlbumRepository albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var model = albumRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = albumRepo.GetById(id);
            return View(model);
        }       
    }
}