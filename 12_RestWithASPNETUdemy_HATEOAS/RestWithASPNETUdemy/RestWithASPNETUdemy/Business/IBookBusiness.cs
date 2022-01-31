using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        List<BookVO> FindAll();

        BookVO FindById(long id);

        BookVO Create(BookVO book);

        BookVO Update(BookVO book); 

        void Delete(long id);
    }
}
