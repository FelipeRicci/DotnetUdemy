using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementations : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementations(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
          return _repository.Update(person); 
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
