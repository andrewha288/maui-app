using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extron.Data
{
    //  We have 3 lelvels of membership each with different tow distance and premium amount
   public interface IMembership
    {
        string Name { get; set; }
        string GetMembershipType();
        int GetTowDistance();
        int GetPremium();
    }

    //  Create those 3 levels of membership products
    public class ClassicMember : IMembership
    {
        public string GetMembershipType()
        {
            return "Classic";
        }

        public int GetPremium()
        {
            return 75;
        }

        public int GetTowDistance()
        {
            return 10;
        }

        public string Name { get; set; }
    }

    public class PlusMember : IMembership
    {
        public string GetMembershipType()
        {
            return "Plus";
        }

        public int GetPremium()
        {
            return 150;
        }

        public int GetTowDistance()
        {
            return 100;
        }

        public string Name { get; set; }
    }

    public class PremiumMember : IMembership
    {
        public string GetMembershipType()
        {
            return "Premium";
        }

        public int GetPremium()
        {
            return 200;
        }

        public int GetTowDistance()
        {
            return 200;
        }

        public string Name { get; set; }
    }
}
