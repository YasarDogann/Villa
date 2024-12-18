using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Villa_DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class // T bir sınıftır de
    {
        Task CreateAsync(T entity); // ekleme
        Task UpdateAsync(T entity); // güncelleme
        Task DeleteAsync(ObjectId id); // silme
        Task<List<T>> GetListAsync(); // listeleme
        Task<T> GetByIdAsync(ObjectId id); // id'ye göre listeleme
        Task<int> CountAsync(); // içindeki propertiesleri saydırır
        Task<List<T>> GetFilteredListAsync(Expression<Func<T,bool>> predicate); // expresssion türünde linq sorgusu yapıcaz
    }
}
