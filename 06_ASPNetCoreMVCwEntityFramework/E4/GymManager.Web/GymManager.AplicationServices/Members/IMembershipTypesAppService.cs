using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Members
{
    public interface IMembershipTypesAppService
    {
        Task<List<MembershipType>> GetMembershipsAsync();

        Task<int> AddMembershipAsync(MembershipType membership);

        Task DeleteMembershipAsync(int membershipId);

        Task<MembershipType> GetMembershipAsync(int membershipId);

        Task EditMembershipAsync(MembershipType membership);
    }
}
