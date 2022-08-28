using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    //This will stand for the successful result of the "DataResult" class.
    public class SuccessDataResult<T> : DataResult<T>
    {

        //Since this class is for successful result, "success" property should be true as default.
        //All the possible versions of constructors are considered below.
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
