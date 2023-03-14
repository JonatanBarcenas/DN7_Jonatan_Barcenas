using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        public List<Member> GetMembers()
        {
           List<Member> members = new List<Member>();
            members.Add(new Member
            {
                Name = "Israel",
                LastName = "Garcia",
                BirthDay = new DateTime(2000, 10, 11),
                AllowNesLetter = false,
                CytiId = 2,
                Email = "isra@prueba.com"

            }) ;

            members.Add(new Member
            {
                Name = "Edgar",
                LastName = "Garcia",
                BirthDay = new DateTime(2000, 10, 11),
                AllowNesLetter = false,
                CytiId = 2,
                Email = "Edgar@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Jaime",
                LastName = "Perez",
                BirthDay = new DateTime(2000, 10, 11),
                AllowNesLetter = false,
                CytiId = 2,
                Email = "Jaime@prueba.com"

            });

            members.Add(new Member
            {
                Name = "elon",
                LastName = "musk",
                BirthDay = new DateTime(2000, 12, 2),
                AllowNesLetter = false,
                CytiId = 2,
                Email = "elon@tesla.com"

            });

            members.Add(new Member
            {
                Name = "Bart",
                LastName = "Simpson",
                BirthDay = new DateTime(1982, 4, 20),
                AllowNesLetter = false,
                CytiId = 3,
                Email = "bart@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Rick",
                LastName = "Sanches",
                BirthDay = new DateTime(1982, 9, 24),
                AllowNesLetter = false,
                CytiId = 3,
                Email = "rick@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Manuel",
                LastName = "Sanches",
                BirthDay = new DateTime(1982, 9, 24),
                AllowNesLetter = false,
                CytiId = 2,
                Email = "Hol@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Gerardo",
                LastName = "Sanches",
                BirthDay = new DateTime(1982, 9, 24),
                AllowNesLetter = false,
                CytiId = 2,
                Email = "gera@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Joantan",
                LastName = "Barcenas",
                BirthDay = new DateTime(1982, 9, 24),
                AllowNesLetter = true,
                CytiId = 3,
                Email = "rick@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Steven",
                LastName = "Barcenas",
                BirthDay = new DateTime(1982, 9, 24),
                AllowNesLetter = true,
                CytiId = 3,
                Email = "steve@prueba.com"

            });

            return members;
        }
    }
}
