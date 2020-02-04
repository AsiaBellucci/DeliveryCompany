using DeliveryCompany.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryCompany.Classes.Department
{
    public class Heavy : Handler
    {
        public override void Handle(ParcelHandler pacco)
        {
            if(pacco.Value > 1000 && pacco.Weight >10)
            {
                Console.WriteLine($"€{pacco.Value} e weight: {pacco.Weight} ----> INSURANCE department and then to HEAVY department");
            }
            else if (pacco.Weight > 10)
            {
                Console.WriteLine($"Weight: {pacco.Weight} ----> HEAVY department");
            }
        }
    }
}
