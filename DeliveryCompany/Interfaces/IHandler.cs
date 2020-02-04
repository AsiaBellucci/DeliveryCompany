using DeliveryCompany.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryCompany.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(ParcelHandler pacco);
    }
}
