using System;
using System.Collections.Generic;
using System.Text;
using PetShopApp.Coree;
using PetShopApp.Core.Entities;

namespace PetShopApp.Infastructure.Static.Data
{
    class DataInit
    {
        readonly IPetService _petService;

        public DataInit(IPetService petService)
        {
            _petService = petService;
        }

        public void InitData()
        {

            Pet pet1 = new Pet
            {
                Name = "Kitty",
                Type = "Cat",
                Color = "Black",
                Birthday = new DateTime(2019, 6, 2),
                SoldDate = new DateTime(2020, 3, 1),
                PrevOwner = "Gustaf Edinson",
                Price = 800.25,
            };
            _petService.Create(pet1);

            Pet pet2 = new Pet
            {
                Name = "Barkley",
                Type = "Dog",
                Color = "Grey",
                Birthday = new DateTime(2018, 2, 2),
                SoldDate = new DateTime(2020, 1, 6),
                PrevOwner = "Alfonso Davies",
                Price = 650.60,
            };
            _petService.Create(pet2);

            Pet pet3 = new Pet
            {
                Name = "Jerry",
                Type = "Mouse",
                Color = "Red",
                Birthday = new DateTime(2020, 6, 7),
                SoldDate = new DateTime(2020, 2, 7),
                PrevOwner = "Save Pets Company",
                Price = 30,
            };
            _petService.Create(pet3);

            Pet pet4 = new Pet
            {
                Name = "Abraham",
                Type = "Pig",
                Color = "Pink",
                Birthday = new DateTime(2020, 2, 7),
                SoldDate = new DateTime(2020, 3, 7),
                PrevOwner = "Farmer Bob",
                Price = 320.60,
            };
            _petService.Create(pet4);

            Pet pet5 = new Pet
            {
                Name = "Stefani",
                Type = "Cat",
                Color = "Purple",
                Birthday = new DateTime(2019, 6, 5),
                SoldDate = new DateTime(2020, 2, 5),
                PrevOwner = "Sir Alex",
                Price = 10500,
            };
            _petService.Create(pet5);

            Pet pet6 = new Pet
            {
                Name = "Van Gogh",
                Type = "Dog",
                Color = "White",
                Birthday = new DateTime(2020, 2, 7),
                SoldDate = new DateTime(2020, 5, 7),
                PrevOwner = "Oscar Wild",
                Price = 16499.99,
            };
            _petService.Create(pet6);
        }


    }
}
}
