using Core.DataAccess.NHibernate;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Abstract

{
    //This is a interface of the Container object.
    //This includes operations related to Container Class in the database.
    //This interface receives inheritance methods from the IMapperSession for the Container Class.
    public interface IContainerDal : IMapperSession<Container>
    {
        IQueryable<Container> Containers { get; }
    }
}
