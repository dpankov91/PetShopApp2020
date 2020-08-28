using System;
using System.Collections.Generic;
using System.Text;
using PetShopApp.Core.Entities;

namespace PetShopApp.Coree
{
    public interface IPetService
    {
        Pet NewPet( string Name,
                    string lastName,
                    string lastName,
                    string lastName,
                    string lastName,
                               string address);
        List<Pet> GetPets();

        Pet FindPetById(int id);


        Pet Update(Pet pet);

        Pet Delete(Pet )
    }
}
    