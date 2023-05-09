using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManger.DataAccess.Repositories
{
	public class MembershipTypeRepository : Repository<int, MembershipType>
	{
		public MembershipTypeRepository(GymManagerContext context):base(context)
		{ 
		
		}

	}
}
