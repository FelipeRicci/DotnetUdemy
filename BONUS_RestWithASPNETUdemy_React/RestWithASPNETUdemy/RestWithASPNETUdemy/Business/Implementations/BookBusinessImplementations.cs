using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessImplementations : IBookBusiness
    {

        private readonly IBookRepository _repository;

        private readonly BookConverter _converter;

        public BookBusinessImplementations(IBookRepository repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        // Method responsible for returning all people,
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PagedSearchVO<BookVO> FindWithPagedSearch(
            string title, string sortDirection, int pageSize, int page)
        {
            var sort = (!string.IsNullOrWhiteSpace(sortDirection)) && !sortDirection.Equals("desc") ? "asc" : "desc";
            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            string query = @"select * from books b where 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(title)) query = query + $" and b.title like '%{title}%' ";
            query += $" order by b.title {sort} limit {size} offset {offset}";

            string countQuery = @"select count(*) from books b where 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(title)) countQuery = countQuery + $" and b.title like '%{title}%' ";

            var books = _repository.FindWithPagedSearch(query);
            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchVO<BookVO>
            {
                CurrentPage = page,
                List = _converter.Parse(books),
                PageSize = size,
                SortDirections = sort,
                TotalResults = totalResults
            };
        }

        // Method responsible for returning one person by ID
        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<BookVO> FindByTitle(string title, string author)
        {
            return _converter.Parse(_repository.FindByTitle(title, author));
        }

        // Method responsible to crete one new person
        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        // Method responsible for updating one person
        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        
    }
}
