using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extron.Data
{
   public class MembershipService
    {
        List<IMembership> members = new List<IMembership>();
        public IEnumerable<IMembership> GetAllMembershipTypes()
        {
            //  We create the 3 membership types using the factory
            return new List<IMembership>() {
                new ClassicMbershipFactory().CreateMembership(),
                new PlusMembershipFactory().CreateMembership(),
                new PremiumMembershipFactory().CreateMembership()
            };
        }

        public void AddMember(string name, IMembership membership)
        {
            membership.Name = name;
            members.Add(membership);
        }

        public IEnumerable<IMembership> GetMembers()
        {
            return members;
        }
    }
}
