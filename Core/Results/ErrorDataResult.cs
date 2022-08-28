using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    //This will stand for the fail result of the "DataResult" class.
    public class ErrorDataResult<T> : DataResult<T>
    {
        //Since this class is for successful result, "success" property should be false as default.
        //All the possible versions of constructors are considered below.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
