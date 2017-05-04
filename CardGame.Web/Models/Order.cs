﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame.Web.Models
{

    public class Order
    {
        public CardPackModel Pack { get; set; }
        public int Quantity { get; set; }
        public int UserBalance { get; set; }
    }

}
