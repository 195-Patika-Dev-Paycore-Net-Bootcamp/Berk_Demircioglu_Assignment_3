using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    //This is created for methods that return an entity.
    //To get any type of entity as a result, this is created as a generic type class.
    public class DataResult<T> : Result, IDataResult<T>
    {
        //This result will return not only a success state and a message but also data.
        //All the possible versions of constructors are considered below.
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
