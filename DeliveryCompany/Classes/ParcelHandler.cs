using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryCompany.Classes
{
    public class ParcelHandler
    {
        public string Sender { get; set; }
        public string Receipient { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public ParcelHandler(string sender, string receipient, double weight, double value)
        {
            this.Sender = sender;
            this.Receipient = receipient;
            this.Weight = weight;
            this.Value = value;
        }

    }
}
