using FF.Models;
using FF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FF.Controllers
{
    public class MonAnController : Controller
    {
        // GET: MonAn
        private readonly ApplicationDbContext _dbContext;
        public MonAnController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize(Roles ="Admin")]
        public ActionResult ThemMon()
        {
            var viewModel = new MonAnViewModel
            {
                MonAns = _dbContext.MonAns.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ThemMon(MonAnViewModel viewModel)
        {
            var monan = new MonAn
            {
                Id = _dbContext.MonAns.ToList().Count + 1,
                TenMon = viewModel.TenMon,
                DonGia = viewModel.DonGia
            
                
            };
            _dbContext.MonAns.Add(monan);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}