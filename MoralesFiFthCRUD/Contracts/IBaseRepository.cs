using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesFiFthCRUD.Contracts
{
    public enum ErrorCode
    {
        Success,
        Error
    }

    public enum UserRole
    {
        Tutor,
        Client
    }
    public class User
    {

        public UserRole Role { get; set; }
    }
    public interface IBaseRepository<T>
    {
        T Get(object id);

        List<T> GetAll();

        ErrorCode Create(T t);

        ErrorCode Update(object id, T t);

        ErrorCode Delete(object id);

    }
}
