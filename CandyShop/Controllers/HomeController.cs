﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        //in order to access the list of candy
        private readonly ICandyRepository _candyRepository;

        public HomeController(ICandyRepository candyRepository)
        {
            _candyRepository = candyRepository;
        }
        
        //get the list of candy on sale
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _candyRepository.GetCandyOnSale
            };

            return View(homeViewModel);
        }
    }
}