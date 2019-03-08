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
        ISongRepository songRepo;

        public SongController(SongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        public ViewResult Index()
        {
            return View();
        }       
    }
}
