using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PetBusinessImplementations : IPetBusiness
    {

        private readonly IPetRepository _repository;

        public PetBusinessImplementations(IPetRepository repository)
        {
            _repository = repository;
        }

        public Pet Create(Pet pet)
        {
            return _repository.Create(pet); 
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Pet> FindAll()
        {
            return _repository.FindAll();
        }

        public Pet FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Pet Update(Pet pet)
        {
            return _repository.Update(pet);
        }
    }
}
