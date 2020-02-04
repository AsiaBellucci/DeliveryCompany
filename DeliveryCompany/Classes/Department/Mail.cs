using DeliveryCompany.Abstracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DeliveryCompany.Classes
{
    public class Mail : Handler
    {
        public override void Handle(ParcelHandler pacco)
        {
            if (pacco.Value < 1000 && pacco.Weight<1)
            {
                Console.WriteLine($"€{pacco.Value} e weight: {pacco.Weight} ----> INSURANCE department and then to MAIL department");
            }
            else if (pacco.Weight < 1)
            {
                Console.WriteLine($"Weight: {pacco.Weight} ----> MAIL department");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(pacco);
            }
        }
    }
}
