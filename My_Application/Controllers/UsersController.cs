using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewModels;

namespace My_Application.Controllers
{
    public class UsersController : Infrastructure.BaseControllerWithDatabase
    {
        public UsersController(Data.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            //System.Threading.Thread.Sleep(2000);
            var result = await UnitOfWork.UserRepository.GetAllAsync();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (UserViewModel viewModel)
        {
            try
            {
                var newEntity = new Models.User
                {
                    FullName = viewModel.FullName,
                    Gender = viewModel.Gender,
                };

                await UnitOfWork.UserRepository.InsertAsync(newEntity);

                await UnitOfWork.SaveAsync();

                return View(viewModel);
            }
            catch
            {
                return Ok(value: null);
            }
        }
    }
}