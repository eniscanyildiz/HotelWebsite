﻿using HotelWebsite.DataAccessLayer.Abstract;
using HotelWebsite.DataAccessLayer.Concrete;
using HotelWebsite.DataAccessLayer.Repositories;
using HotelWebsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWebsite.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {

        }
    }

}

