﻿using GymManager.AplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        public MembersController(IMembersAppService membersAppService) { 
        _membersAppService = membersAppService;
        }  
        public async Task<IActionResult> Index()
        {
            List<Member> members = await _membersAppService.GetMembersAsync();
            MemberListViewModel viewModel = new MemberListViewModel();  
            viewModel.NewMembersCount= 2;
            viewModel.Members = members;
            return View(viewModel);
        }

        public IActionResult Create()
        {
           
            return View();
        }

		public async Task<IActionResult> Delete(int memberId)
		{
           await  _membersAppService.DeleteMemberAsync(memberId);
			return RedirectToAction("Index");
		}

        public async Task<IActionResult> Edit(int memberId)
        {
            Member member = await _membersAppService.GetMemberAsync(memberId);

            MemberViewModel viewModel = new MemberViewModel
            {
                AllowNesLetter = member.AllowNesLetter,
                BirthDay= member.BirthDay,
                CityId = member.City.Id,
                Email= member.Email,
                Id= member.Id,
                LastName= member.LastName,
                Name= member.Name
            };
           
            return View(viewModel);
        }

        [HttpPost]
		public async Task<IActionResult> Create(MemberViewModel viewModel)
		{
            Member member = new Member
            {
    Name= viewModel.Name,
    BirthDay= viewModel.BirthDay,
    LastName= viewModel.LastName,
    Email= viewModel.Email,
    City = new City
    {
        Id = viewModel.CityId
    },
    AllowNesLetter= viewModel.AllowNesLetter
            };
            await _membersAppService.AddMemberAsync(member);

			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> Edit(Member member)
		{
			await _membersAppService.EditMemberAsync(member);

			return RedirectToAction("Index");
		}

		public IActionResult Test()
        {
            return View();
        }
    }
}
