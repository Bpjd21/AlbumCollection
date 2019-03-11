using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        SongRepository songRepo;

        public SongController(SongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Details(int id)
        {
            var model = songRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            var songRepo = new Song()
            {
                AlbumId = id
            };
            return View(songRepo);
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("../Album/Details/" + song.AlbumId);
        }
    }
}
