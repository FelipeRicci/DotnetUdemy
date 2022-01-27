using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPetRepository
    {

        Pet Create(Pet pet);  

        Pet Update(Pet pet);

        Pet FindById(long id);

        List<Pet> FindAll();

        void Delete(long id);

    }
}
