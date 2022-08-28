using Entities.Concrete;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.NHibernate.Mapping
{
    public class VehicleMap : ClassMapping<Vehicle> 
    {
        //The given method below helps us to match Vehicle class with the Vehicle database tables.
        public VehicleMap() 
        {
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int64); // Type of the property. 
                x.Column("Id"); // Column is stated.
                x.UnsavedValue(0); // Default Value.
                x.Generator(Generators.Increment); //Auto Increment is applied.
            });

            Property(b => b.VehicleName, x =>
            {
                x.Length(50); // Max length is given.
                x.Type(NHibernateUtil.String); // Type of the property.
                x.NotNullable(false); // This property can be null.

            });

            Property(b => b.VehiclePlate, x =>
            {
                x.Length(50); // Max length is given.
                x.Type(NHibernateUtil.String); // Type of the property.
                x.NotNullable(false); // This property can be null.
            });

            Table("Vehicle");
        }
    }
}
