﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame.Web.Models
{
    public class CardPackModel
    {
        public int CardPackID { get; set; }
        public string PackName { get; set; }
        public int NumCards { get; set; }
        public int Price { get; set; }
    }
}
