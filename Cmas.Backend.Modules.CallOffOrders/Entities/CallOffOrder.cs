using Cmas.Backend.Modules.CallOffOrders.Entities.Rates;
using System;
using System.Collections.Generic;

namespace Cmas.Backend.Modules.CallOffOrders.Entities
{
    /// <summary>
    /// Наряд заказ
    /// </summary>
    public class CallOffOrder
    {
        /// <summary>
        /// Уникальный внутренний идентификатор
        /// </summary>
        public String Id;

        /// <summary>
        /// Идентификатор договора
        /// </summary>
        public String ContractId;

        /// <summary>
        /// Номер наряд заказа
        /// </summary>
        public String Number;

        /// <summary>
        /// Дата и время создания
        /// </summary>
        public DateTime CreatedAt;

        /// <summary>
        /// Дата и время обновления
        /// </summary>
        public DateTime UpdatedAt;

        /// <summary>
        /// Наименование заказа (по сути - работы)
        /// </summary>
        public String Name;

        /// <summary>
        /// Ставки
        /// </summary>
        public ICollection<Rate> Rates;
        public ICollection<RateGroup> RateGroups;

        public CallOffOrder()
        {
            Rates = new List<Rate>();
            RateGroups = new List<RateGroup>();
        }

    }
}
