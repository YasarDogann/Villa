using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Villa_Businesss.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TCreateAsync(T entity); // ekleme
        Task TUpdateAsync(T entity); // güncelleme
        Task TDeleteAsync(ObjectId id); // silme
        Task<List<T>> TGetListAsync(); // listeleme
        Task<T> TGetByIdAsync(ObjectId id); // id'ye göre listeleme
        Task<int> TCountAsync(); // içindeki propertiesleri saydırır
        Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate);
    }
}
