﻿using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness {

        PersonVO Create(PersonVO person);

        PersonVO FindById(long id);

        List<PersonVO> FindByName(string firstName, string lastName);

        PersonVO Update(PersonVO person);

        List<PersonVO> FindAll();

        PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);

        PersonVO Disable(long id);

        void Delete(long id);

    }
}