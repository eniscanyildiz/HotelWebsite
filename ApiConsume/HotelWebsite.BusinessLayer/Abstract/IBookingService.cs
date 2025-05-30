﻿using HotelWebsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWebsite.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        //
        void TBookingStatusChangeApproved(Booking booking);
    }
}
