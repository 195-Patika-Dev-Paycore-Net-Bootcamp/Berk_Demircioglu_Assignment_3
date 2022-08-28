using Business.Abstract;
using Core.Messages;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //To see relevant messages, check Core.Messages.Messages.cs
    public class ContainerManager : IContainerService
    {
        //Considering the possibility of using a different database in the future, injection was made with an interface. 
        IContainerDal _containerDal;

        public ContainerManager(IContainerDal containerDal)
        {
            _containerDal = containerDal;
        }

        public IResult Add(Container container) //This method of adding the instance with the parameters taken from body to the list.
        {
            try
            {
                _containerDal.BeginTransaction(); // It starts the transaction.
                _containerDal.Save(container); // It adds the entity to the database.
                _containerDal.Commit(); // It commits the changes.
                return new SuccessResult(Messages.ContainerAdded); // It turns out the relevant message.
            }
            catch (Exception)
            {
                _containerDal.Rollback(); // It rolls-back the database transaction.
                return new ErrorResult(Messages.ContainerNotAdded); // It turns out the relevant message.
            }
            finally
            {
                _containerDal.CloseTransaction(); // It closes the transaction.
            }
        }

        public IResult Delete(int id)
        {
            Container container = _containerDal.Containers.Where(x => x.Id == id).FirstOrDefault(); // The instance that will be deleted is found.

            //It is checked whether the element that will be added is already in the list or not.
            if (container == null)
            {
                return new ErrorResult(Messages.ContainerIdInvalid); // The result was returned with a relevant message.
            }

            try
            {
                _containerDal.BeginTransaction(); // It starts the transaction. 
                _containerDal.Delete(container);  //The element was deleted.
                _containerDal.Commit(); // It commits the changes.
                return new SuccessResult(Messages.ContainerDeleted); // It turns out the relevant message.
            }
            catch (Exception)
            {
                _containerDal.Rollback(); // It rolls-back the database transaction.
                return new ErrorResult(Messages.ContainerNotDeleted); // It turns out the relevant message.
            }
            finally
            {
                _containerDal.CloseTransaction(); // It closes the transaction.
            }
        }

        public IDataResult<List<Container>> GetAll() //All the elements in the list were introduced  with a relevant message.
        {
            return new SuccessDataResult<List<Container>>(_containerDal.Containers.ToList(),Messages.ContainersListed);
        }

        public IResult Update(Container request) //This method of updating the instance according to the parameters taken from body to the list.
        {
            Container container = _containerDal.Containers.Where(x => x.Id == request.Id).FirstOrDefault();  //Find the instance that will be updated.

            if (container == null) //If the instance does not exist, the relevant message is sent.
            {
                return new ErrorResult(Messages.ContainerIdInvalid);
            }

            try
            {
                //Updating Process
                _containerDal.BeginTransaction();
                container.ContainerName = request.ContainerName;
                container.Latitude = request.Latitude;
                container.Longitude=request.Longitude;
                container.VehicleId = container.VehicleId;
                _containerDal.Update(container);

                _containerDal.Commit();
                return new SuccessResult(Messages.ContainerUpdated);
            }
            catch (Exception)
            {
                //If update process cannot be completed, all steps are rolled-back and message is sent.
                _containerDal.Rollback();
                return new ErrorResult(Messages.ContainerNotUpdated);
            }
            finally
            {
                _containerDal.CloseTransaction();
            }
        }
    }
}
