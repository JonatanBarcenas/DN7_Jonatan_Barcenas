using GymManager.AplicationServices.MembershipTypes;
using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService)
        {
            _membershipTypesAppService = membershipTypesAppService;
        }

        public IActionResult Index()
        {
            List<MembershipType> membershipTypes = _membershipTypesAppService.GetMembershipTypes();
            MembershipTypeListViewModel viewModel= new MembershipTypeListViewModel();
            viewModel.MembershipTypes = membershipTypes;
            
            return View(viewModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult Delete(int membershipTypeId)
        {
            _membershipTypesAppService.DeleteMembershipType(membershipTypeId);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int membershipTypeId)
        {
            MembershipType membershipType = _membershipTypesAppService.GetMembershipType(membershipTypeId);
           

            return View(membershipType);
        }

        [HttpPost]
        public IActionResult Create(MembershipType membershipType)
        {
            _membershipTypesAppService.AddMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membershipType)
        {
            _membershipTypesAppService.EditMembershipType(membershipType);

            return RedirectToAction("Index");
        }
    }
}
