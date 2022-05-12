using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extron.Data
{
    public interface IMembershipFactory
    {
        public IMembership CreateMembership();
    }

    public class ClassicMbershipFactory : IMembershipFactory
    {
        public IMembership CreateMembership()
        {
            return new ClassicMember();
        }
    }

    public class PlusMembershipFactory : IMembershipFactory
    {
        public IMembership CreateMembership()
        {
            return new PlusMember();
        }
    }

    public class PremiumMembershipFactory : IMembershipFactory
    {
        public IMembership CreateMembership()
        {
            return new PremiumMember();
        }
    }
}
