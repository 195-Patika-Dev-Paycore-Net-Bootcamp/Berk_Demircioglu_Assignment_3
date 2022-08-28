using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //The service operations that will be used in the business layer were declared in this interface.
    //Our own result types have been created to indicate whether the transactions were successful or to indicate why they failed if they failed.
    //This allows us to write readable and standardized codes.
    //All methods related with Container are stated here.
    public interface IContainerService
    {
        IDataResult<List<Container>> GetAll();
        IResult Add(Container container);
        IResult Update(Container container);
        IResult Delete(int id);
    }
}
