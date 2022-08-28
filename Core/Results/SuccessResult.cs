using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    //This will stand for the successful result of the "Result" class.
    public class SuccessResult : Result
    {
        //Since this class is for successful result, "success" property should be true as default.
        //All the possible versions of constructors are considered below.
        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
