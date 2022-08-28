using Business.Abstract;
using Core.Extentions.VehicleExtentions;
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
    public class VehicleManager : IVehicleService
    {
        //Considering the possibility of using a different database in the future, injection was made with an interface. 
        IVehicleDal _vehicleDal;
        IContainerDal _containerDal; // This is also added to reach Containers for the GetContainers method.

        public VehicleManager(IVehicleDal vehicleDal, IContainerDal containerDal)
        {
            _vehicleDal = vehicleDal;
            _containerDal = containerDal;
        }

        public IResult Add(Vehicle vehicle) //This method of adding the instance with the parameters taken from body to the list.
        {
            try
            {
                _vehicleDal.BeginTransaction(); // It starts the transaction.
                _vehicleDal.Save(vehicle); // It adds the entity to the database.
                _vehicleDal.Commit(); // It commits the changes.
                return new SuccessResult(Messages.VehicleAdded); // It turns out the relevant message.
            }
            catch (Exception)
            {
                _vehicleDal.Rollback();  // It rolls-back the database transaction.
                return new ErrorResult(Messages.VehicleNotAdded); // It turns out the relevant message.
            }
            finally
            {
                _vehicleDal.CloseTransaction(); // It closes the transaction.
            }
        }

        public IResult Delete(int id)
        {
            Vehicle vehicle = _vehicleDal.Vehicles.Where(x => x.Id == id).FirstOrDefault(); // The instance that will be deleted is found.

            if (vehicle == null) //It is checked whether the element that will be added is already in the list or not.
            {
                return new ErrorResult(Messages.VehicleIdInvalid); //The result was returned with a relevant message.
            }

            try
            {
                _vehicleDal.BeginTransaction(); // It starts the transaction. 
                foreach (var container in _containerDal.Containers) // It deletes the containers that belonged to the vehicle.
                {
                    if (container.VehicleId == id)
                    {
                        _containerDal.Delete(container);
                    }
                }
                _vehicleDal.Delete(vehicle); //The element was deleted.
                _vehicleDal.Commit(); // It commits the changes.
                return new SuccessResult(Messages.VehicleDeleted); // It turns out the relevant message.
            }
            catch (Exception)
            {
                _vehicleDal.Rollback(); // It rolls-back the database transaction.
                return new ErrorResult(Messages.VehicleNotDeleted); // It turns out the relevant message.
            }
            finally
            {
                _vehicleDal.CloseTransaction(); // It closes the transaction.
            }
        }

        public IDataResult<List<Vehicle>> GetAll() //All the elements in the list were introduced  with a relevant message.
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.Vehicles.ToList(), Messages.VehiclesListed);
        }

        public IDataResult<List<Container>> GetContainers(int id) // It brings the containers that belonged to the vehicle.
        {
            Vehicle vehicle = _vehicleDal.Vehicles.Where(x => x.Id == id).FirstOrDefault(); // The instance is found.

            if (vehicle == null) // If there is no instance with the given id.
            {
                return new ErrorDataResult<List<Container>>(Messages.VehicleIdInvalid); // It turns out the relevant message.
            }

            var result = _containerDal.Containers.Where(x => x.VehicleId == id).ToList(); //Related containers are brought.

            if (result.Count == 0) // If there is no container for the vehicle. It turns out the relevant message.
            {
                return new ErrorDataResult<List<Container>>(result,Messages.NoContainerWithId);
            }
            return new SuccessDataResult<List<Container>>(result,Messages.ContainersListed); //Container list and relevant message are turned out.
        }

        public List<List<Container>> PartitionContainers(int vehicleId, int partitionNumber)
        //The partition containers of the related vehicle with respect to a given partitionNumber size.
        {
            var vehicle = _vehicleDal.Vehicles.Where(v => v.Id == vehicleId).FirstOrDefault();
            var containersList = _containerDal.Containers.Where(c => c.VehicleId == vehicleId).ToList(); //Containers are obtained.
            try
            {
                if (vehicle == null)
                {
                    return null; // If there is no vehicle with given id.
                }
                if (containersList.Count == 0) // If there is no container. Relevant message is sent.
                {
                    return null;
                }
                return containersList.PartitionContainers(partitionNumber); //Partition process.
            }
            catch (Exception ex)
            {
                return null; //In the event that something goes wrong. 
            }
        }

        public IResult Update(Vehicle request) //This method of updating the instance according to the parameters taken from body to the list.
        {
            Vehicle vehicle = _vehicleDal.Vehicles.Where(x => x.Id == request.Id).FirstOrDefault(); //Find the instance that will be updated.

            if (vehicle == null) //If the instance does not exist, the relevant message is sent.
            {
                return new ErrorResult(Messages.VehicleIdInvalid);
            }

            try
            {
                //Updating Process
                _vehicleDal.BeginTransaction();
                vehicle.VehiclePlate = request.VehiclePlate;
                vehicle.VehicleName = request.VehicleName;
                _vehicleDal.Update(vehicle);
                _vehicleDal.Commit();
                return new SuccessResult(Messages.VehicleUpdated);
            }
            catch (Exception)
            {
                //If update process cannot be completed, all steps are rolled-back and message is sent.
                _vehicleDal.Rollback();
                return new ErrorResult(Messages.VehicleNotUpdated);
            }
            finally
            {
                _vehicleDal.CloseTransaction();
            }
        }
    }
}
