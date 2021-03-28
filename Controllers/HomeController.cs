using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiriamsStoreSln.Models;

namespace MiriamsStoreSln.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
