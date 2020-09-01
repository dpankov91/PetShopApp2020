﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.Entities
{
    public class Pet
    {
            
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime SoldDate { get; set; }

        public string Color { get; set; }

        public string PrevOwner { get; set; }

        public double Price { get; set; }


    }
}
