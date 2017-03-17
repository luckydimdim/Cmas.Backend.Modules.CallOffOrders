using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Modules.CallOffOrders.Entities
{
   public class Rate
    {
        public int Id;

        public String Name;

        public bool IsRate;

        /// <summary>
        /// Ставка
        /// </summary>
        public double Amount;

        /// <summary>
        /// Валюта
        /// </summary>
        public String Currency;

        /// <summary>
        /// Ед. изм.
        /// </summary>
        public String UnitName;
    }
}
