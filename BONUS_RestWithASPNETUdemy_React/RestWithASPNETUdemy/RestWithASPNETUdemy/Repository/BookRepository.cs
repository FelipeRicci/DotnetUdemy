using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Generic;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {

        public BookRepository(MySQLContext context) : base (context) { }

        public List<Book> FindByTitle(string title, string author)
        {
            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
            {
               return _context.Books.Where(
               b => b.Title.Contains(title) &&
               b.Author.Contains(author)).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(title) && string.IsNullOrWhiteSpace(author))
            {
                return _context.Books.Where(
                b => b.Title.Contains(title)).ToList();
                
            }
            else if (string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
            {
                return _context.Books.Where(
                b => b.Author.Contains(author)).ToList();

            }
            return null;
        }
    }
}
