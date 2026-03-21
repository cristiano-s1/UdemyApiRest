using Udemy.Api.Models;

namespace Udemy.Api.Repository.Generic;

public interface IRepository<T> where T : BaseEntity
{
    List<T> GetAll();
    T? GetById(int id);
    T Insert(T item);
    T? Update(T item);
    void Delete(int id);
    bool Exists(int id);

    //HATEOAS
    List<T> FindWithPagedSearch(string query);
    int GetCount(string query);
}
