﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewsModels
{
    public class SellerFormViewModels
    {

        public Seller Seller { get; set; }
        public ICollection<Departments> Departments { get; set; }
    }
}
