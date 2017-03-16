using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Modules.CallOffOrders.Entities.Rates
{
    public class RateGroup
    {
        public int Id;

        public String Name;

        public ICollection<Rate> Rates;

        public RateGroup()
        {
            Rates = new List<Rate>();
        }

    }
}
