﻿using HotelWebsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWebsite.DataAccessLayer.Abstract
{
    public interface IBookingDal: IGenericDal<Booking>
    {
        //
        void BookingStatusChangeApproved(Booking booking);
    }
}
