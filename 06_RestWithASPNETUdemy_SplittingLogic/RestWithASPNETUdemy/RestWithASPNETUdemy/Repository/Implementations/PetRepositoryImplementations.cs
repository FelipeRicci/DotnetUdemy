using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public class PetRepositoryImplementations : IPetRepository
    {

        private MySQLContext _context;

        public PetRepositoryImplementations(MySQLContext context)
        {
            _context = context;
        }

        public Pet Create(Pet pet)
        {
            try
            {
                _context.Add(pet);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return pet;
        }

        public void Delete(long id)
        {
            var result = _context.Pets.SingleOrDefault(p => p.Id == id);
            if (result != null)
            {
                try
                {
                    _context.Pets.Remove(result);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        public List<Pet> FindAll()
        {
            return _context.Pets.ToList();
        }

        public Pet FindById(long id)
        {
            return _context.Pets.Find(id);
        }

        public Pet Update(Pet pet)
        {
            if (!Exists(pet.Id)) return null;
            var result = _context.Pets.SingleOrDefault(p => p.Id == pet.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(pet);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return pet;
        }

        private bool Exists(long id)
        {
            return _context.Pets.Any(p => p.Id == id);
        }
    }
}
