using Entities.Concrete;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace DataAccess.Concrete.NHibernate.Mapping
{
    public class ContainerMap : ClassMapping<Container>
    {
        //The given method below helps us to match Container class with the Container database tables.
        public ContainerMap()
        {
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int64); // Type of the property.
                x.Column("Id"); // Column is stated.
                x.UnsavedValue(0); // Default Value.
                x.Generator(Generators.Increment); //Auto Increment is applied.
            });

            Property(b => b.ContainerName, x =>
            {
                x.Length(50); // Max length is given.
                x.Type(NHibernateUtil.String); // Type of the property.
                x.NotNullable(false);  // This property can be null.

            });

            Property(b => b.Latitude, x =>
            {
                x.Type(NHibernateUtil.Double); // Type of the property.
                x.NotNullable(false);  // This property can be null.
            });

            Property(b => b.Longitude, x =>
            {
                x.Type(NHibernateUtil.Double); // Type of the property.
                x.NotNullable(false);  // This property can be null.
            });

            Property(b => b.VehicleId, x =>
            {
                x.Type(NHibernateUtil.Int64); // Type of the property.
                x.NotNullable(false);  // This property can be null.
            });

            Table("Container");
        }
    }
}
