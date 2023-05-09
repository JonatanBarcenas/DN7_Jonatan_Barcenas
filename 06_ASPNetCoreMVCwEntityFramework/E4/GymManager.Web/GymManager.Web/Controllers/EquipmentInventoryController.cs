using GymManager.AplicationServices.Equipments;
using GymManager.AplicationServices.Members;
using GymManager.Core.Equipment;
using GymManager.Core.Gym;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
	public class EquipmentInventoryController : Controller
	{
        private readonly IEquipmentAppService _equipmentAppService;
		public EquipmentInventoryController(IEquipmentAppService equipmentAppService)
		{
			_equipmentAppService= equipmentAppService;
		}
        public async Task<IActionResult> Index()
		{
			List<EquipmentInventory> list = await _equipmentAppService.GetEquipmentsAsync();
			EquipmentListViewModel viewModel= new EquipmentListViewModel();
			viewModel.Equipments = list;
			return View(viewModel);
		}

        public IActionResult Create()
        {

            return View();
        }

        public async Task<IActionResult> Delete(int equipmentId)
        {
            await _equipmentAppService.DeleteEquipmentAsync(equipmentId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int equipmentId)
        {
            EquipmentInventory equipment = await _equipmentAppService.GetEquipmentAsync(equipmentId);

            EquipmentViewModel viewModel = new EquipmentViewModel()
            {
                Id= equipment.Id,
                Name= equipment.Name,
                AcquisitionDate= equipment.AcquisitionDate,
                State=equipment.State,
                EquipmentTypeId = equipment.Type.Id
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EquipmentViewModel viewModel)
        {
            EquipmentInventory equipment = new EquipmentInventory()
            {
                Name = viewModel.Name,
                AcquisitionDate= viewModel.AcquisitionDate,
                State=viewModel.State,
                Type = new EquipmentType
                {
                    Id = viewModel.EquipmentTypeId
                }
              
            };
            await _equipmentAppService.AddEquipmentAsync(equipment);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EquipmentInventory equipment)
        {
            await _equipmentAppService.EditEquipmentAsync(equipment);

            return RedirectToAction("Index");
        }

    }
}
