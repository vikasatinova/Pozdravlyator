using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pozdravlyator.Domein;
using Pozdravlyator.Domein.Entities;
using Pozdravlyator.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Controllers
{
    public class AllBirthdaysController : Controller
    {
        private readonly DataMeneger dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public AllBirthdaysController(DataMeneger dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(int id)
        {
            var entity = id == default ? new Birthday() : dataManager.Birthdays.GetBirthdayById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Birthday model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.photo = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.Birthdays.SaveBirthday(model);
                return RedirectToAction(nameof(HomeController.AllBirth), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Birthdays.DeleteBirthday(id);
            return RedirectToAction(nameof(HomeController.AllBirth), nameof(HomeController).CutController());
        }
    }
}
