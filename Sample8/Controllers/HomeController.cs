using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.ApplicationService;
using Domain.Contract;
using Domain.Entittes;
using Microsoft.AspNetCore.Mvc;
using Sample8.Models;

namespace Sample8.Controllers
{
    public class HomeController : Controller
    {
        ITblUserFacade TblUserFacade;
        public HomeController()
        {
            TblUserFacade = new TblUserFacade();
        }
        public IActionResult Index()
        {
            List<TblUser> data = TblUserFacade.GetTblUsers();
            return View(data);
        }
    }
}
