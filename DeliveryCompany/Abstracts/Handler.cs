using DeliveryCompany.Interfaces;
using DeliveryCompany.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryCompany.Abstracts
{
    public abstract class Handler : IHandler
    {
        protected IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
        public abstract void Handle(ParcelHandler pacco);
        //{
        //    if(this._nextHandler != null)
        //    {
        //        return this._nextHandler.Handle(request);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
