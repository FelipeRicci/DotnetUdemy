using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness {

        PersonVO Create(PersonVO person);

        PersonVO FindById(long id);

        PersonVO Update(PersonVO person);

        List<PersonVO> FindAll();

        void Delete(long id);

    }
}
