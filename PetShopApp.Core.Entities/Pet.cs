using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.Entities
{
    public class Pet
    {
            
        public int Id { get; set; }

        public string Name { get; set; }

        public enum Pets 
        {
            Cat, Dog, Mouse, Snake        
        }

        public DateTime Birthday { get; set; }

        public DateTime DateTime { get; set; }

        public string Color { get; set; }

        public string prevOwner { get; set; }

        public double Price { get; set; }


    }
}
