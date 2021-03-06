using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementations : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementations(IRepository<Person> repository)
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
