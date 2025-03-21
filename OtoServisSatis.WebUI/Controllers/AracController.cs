﻿using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;

namespace OtoServisSatis.WebUI.Controllers
{
    public class AracController : Controller
    {
        private readonly ICarService _serviceArac;
        private readonly IService<Musteri> _serviceMusteri;

        public AracController(ICarService serviceArac, IService<Musteri> serviceMusteri)
        {
            _serviceArac = serviceArac;
            _serviceMusteri = serviceMusteri;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = await _serviceArac.GetCustomCar(id);
            return View(model);
        }
        [Route("tum-araclarimiz")]
        public async Task<IActionResult> List(int id)
        {
            var model = await _serviceArac.GetCustomCarList(c=>c.SatistaMi);
            return View(model);
        }
        public async Task<IActionResult> Ara(string q)
        {
            var model = await _serviceArac.GetCustomCarList(c => c.SatistaMi && c.Marka.Adi.Contains(q)|| c.KasaTipi.Contains(q) || c.Modeli.Contains(q));
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> MusteriKayıt(Musteri musteri )
        {
            if (ModelState.IsValid) {
                try
                {
                    await _serviceMusteri.AddAsync(musteri);
                    await _serviceMusteri.SaveAsync();
                    return Redirect("/Arac/Index/"+musteri.AracId);


                        
                        
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Hata oluştu");
                }
            }
            return View();
        }
    }
}
