using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        
        BookVO FindById(long id);

        List<BookVO> FindByTitle(string title, string author);

        List<BookVO> FindAll();

        PagedSearchVO<BookVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int page);

        BookVO Update(BookVO book); 

        void Delete(long id);
    }
}
