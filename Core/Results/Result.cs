using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    //This is created for methods that return void.
    public class Result : IResult
    {
        //The constructor is created to obtain the relevant success state and given message.
        //P.S : The properties with getter can be set in the constructor.
        //Both options,with and without a message, are considered. That's why the constructor is generated in the way given below.
        //All the possible versions of constructors are considered below.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
            //Success = success; //Success could be written within the first constructor.To avoid repetitive codes, another constructor is generated. 
            //With the help of ":this(succes)", with or without message versions of Result will be obtained.
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
