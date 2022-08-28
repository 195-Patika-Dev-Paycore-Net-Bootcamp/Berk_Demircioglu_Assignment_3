using Core.DataAccess.NHibernate;
using DataAccess.Abstract;
using Entities.Concrete;
using NHibernate;
using System.Linq;

namespace DataAccess.Concrete.NHibernate
{
    public class NhContainerDal : MapperSession<Container>, IContainerDal
    {
        // With the help of given expressions below, Entities in the database are accessed.
        private readonly ISession session;

        public NhContainerDal(ISession session) : base(session)
        {
            this.session = session;
        }

        // Containers are stored in a list.
        public IQueryable<Container> Containers => session.Query<Container>().OrderBy(x => x.Id);
    }
}
