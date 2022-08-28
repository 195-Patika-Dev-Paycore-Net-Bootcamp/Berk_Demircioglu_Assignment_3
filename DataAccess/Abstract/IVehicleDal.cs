using Core.DataAccess.NHibernate;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //This is a interface of the Vehicle object.
    //This includes operations related to Vehicle Class in the database.
    //This interface receives inheritance methods from the IMapperSession for the Vehicle Class.
    public interface IVehicleDal : IMapperSession<Vehicle>
    {
        IQueryable<Vehicle> Vehicles { get; }
    }
}
