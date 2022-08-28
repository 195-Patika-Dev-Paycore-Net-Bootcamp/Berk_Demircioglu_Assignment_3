using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    //This is created for methods that return an entity.
    //To get any type of entity as a result, this is created as a generic type class.
    //This result will return not only a success state and a message but also data.
    //That is the explanation of where the inheritance and "T Data" come from.
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
