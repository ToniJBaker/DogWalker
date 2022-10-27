using DogWalker.Models;
using DogWalker.Models.ViewModels;
using DogWalker.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DogWalker.Controllers
{
    public class WalkersController : Controller
    {
        private readonly IWalkerRepository _walkerRepo;
        private readonly INeighborhoodRepository _neighborhoodRepo;
        private readonly IWalkRepository _walkRepo;
        



        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalkersController(
            IWalkerRepository walkerRepository, 
            INeighborhoodRepository nighborhoodRepository, 
            IWalkRepository walkRepository)
        {
            _walkerRepo = walkerRepository;
            _neighborhoodRepo = nighborhoodRepository;
            _walkRepo = walkRepository;
            
        }
        // GET: WalkersController
        public ActionResult Index()
        {
            List<Walker> walkers = _walkerRepo.GetAllWalkers();
            return View(walkers);
        }

        // GET: WalkersController/Details/5
        public ActionResult Details(int id)
        {
            Walker walker = _walkerRepo.GetWalkerById(id);
            List<Walk> walks = _walkRepo.GetWalksByWalkerId(walker.Id);
           

            //if (walker == null)
            //{
            //    return NotFound();
            //}
            WalkerDetailsViewModel vm = new WalkerDetailsViewModel()
            {
                Walker = walker,
                Walks = walks
            };

            return View(vm);
        }

        // GET: WalkersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalkersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalkersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalkersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
