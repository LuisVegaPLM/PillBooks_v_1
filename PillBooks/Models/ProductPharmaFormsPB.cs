﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PillBooks.Models
{
    public class ProductPharmaFormsPB
    {
        public int ProductId { get; set; }
        public String Brand { get; set; }
        public int PharmaFormId { get; set; }
        public String PharmaForm { get; set; }
        public String Substances { get; set; }
    }
}