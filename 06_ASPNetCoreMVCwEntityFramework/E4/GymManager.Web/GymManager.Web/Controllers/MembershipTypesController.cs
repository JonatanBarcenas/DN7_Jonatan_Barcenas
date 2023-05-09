using GymManager.AplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppService _membershipTypesAppService;
        public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService)
        {
            _membershipTypesAppService = membershipTypesAppService;
        }

        public async Task<IActionResult> Index()
        {
            List<MembershipType> membershipTypes = await _membershipTypesAppService.GetMembershipsAsync();
            MembershipListViewModel viewModel = new MembershipListViewModel();
            viewModel.MembershipTypes = membershipTypes;
            return View(viewModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        public async Task<IActionResult> Delete(int membershipId)
        {
            await _membershipTypesAppService.DeleteMembershipAsync(membershipId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int membershipId)
        {
            MembershipType membership = await _membershipTypesAppService.GetMembershipAsync(membershipId);

            MembershipTypesViewModel viewModel = new MembershipTypesViewModel
            {
                Name = membership.Name,
                Description = membership.Description,
                Price = membership.Price,
                DurationInMonths = membership.DurationInMonths
               
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipTypesViewModel viewModel)
        {
            MembershipType membership = new MembershipType
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price,
                DurationInMonths = viewModel.DurationInMonths
               
            };
            await _membershipTypesAppService.AddMembershipAsync(membership);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MembershipType membership)
        {
            await _membershipTypesAppService.EditMembershipAsync(membership);

            return RedirectToAction("Index");
        }
    }
}
