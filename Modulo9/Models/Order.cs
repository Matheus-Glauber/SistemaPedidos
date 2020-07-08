using Modulo9.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo9.Models
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
