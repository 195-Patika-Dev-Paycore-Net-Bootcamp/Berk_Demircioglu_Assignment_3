using Core.DataAccess.NHibernate;
using DataAccess.Abstract;
using Entities.Concrete;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.NHibernate
{
    public class NhVehicleDal : MapperSession<Vehicle> ,IVehicleDal
    {
        // With the help of given expressions below, Entities in the database are accessed.
        private readonly ISession session;
        public NhVehicleDal(ISession session) : base(session)
        {
            this.session = session;
        }

        // Vehicles are stored in a list.
        public IQueryable<Vehicle> Vehicles => session.Query<Vehicle>().OrderBy(x => x.Id);
    }
}

