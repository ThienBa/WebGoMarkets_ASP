﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGoMarkets.Models;

namespace WebGoMarkets.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
