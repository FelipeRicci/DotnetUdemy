using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> FindByTitle(string title, string author);
    }
}
