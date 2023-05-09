using GymManager.AplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using GymManger.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
	[Authorize]
	public class RenewalController : Controller
	{
        private readonly GymManagerContext _context;
        private readonly IMembersAppService _membersAppService;
        public RenewalController(IMembersAppService membersAppService, GymManagerContext context)
        {
            _membersAppService = membersAppService;
            _context = context;
        }
        public IActionResult Index()
		{
			return View();
		}

        public async Task<IActionResult> Get(int memberId)
        {
            Member member = await _membersAppService.GetMemberAsync(memberId);
            if (member == null)
            {
                TempData["ErrorMessage"] = "El miembro no existe.";
                return RedirectToAction("Error");
            }
            MemberViewModel viewModel = new MemberViewModel
            {
                Id = member.Id,
                Name = member.Name,
                LastName = member.LastName,
                BirthDay = member.BirthDay,
                Email = member.Email,
                AllowNesLetter = member.AllowNesLetter,
                CityId = member.City.Id,
                
                
            };
            if (member.MembershipType != null)
            {
                viewModel.MembershipId = member.MembershipType.Id;
            }
            return View(viewModel);
        }

        public IActionResult Error()
        {
            var errorMessage = TempData["ErrorMessage"];
            return RedirectToAction("Index", errorMessage);
        }

        [HttpPost]
        public IActionResult Edit(MemberViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var member = _context.Members.FirstOrDefault(m => m.Id == viewModel.Id);
            if (member == null)
            {
                return NotFound();
            }

            var city = _context.Cities.FirstOrDefault(c => c.Id == viewModel.CityId);
            var membership = _context.MembershipTypes.FirstOrDefault(m => m.Id == viewModel.MembershipId);

            member.Name = viewModel.Name;
            member.LastName = viewModel.LastName;
            member.BirthDay = viewModel.BirthDay;
            member.Email = viewModel.Email;
            member.City = city;
            member.AllowNesLetter = viewModel.AllowNesLetter;
            member.MembershipType = membership;

            _context.Members.Update(member);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
