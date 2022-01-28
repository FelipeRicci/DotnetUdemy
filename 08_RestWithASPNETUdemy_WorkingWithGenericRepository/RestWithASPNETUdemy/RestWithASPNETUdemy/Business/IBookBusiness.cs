using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        List<Book> FindAll(); 

        Book FindById(long id);  

        Book Create(Book book);

        Book Update(Book book); 

        void Delete(long id);
    }
}
