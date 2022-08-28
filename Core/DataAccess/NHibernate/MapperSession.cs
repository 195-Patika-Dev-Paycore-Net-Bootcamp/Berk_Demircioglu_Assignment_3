using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.NHibernate

{
    public class MapperSession<T> : IMapperSession<T>
    {
        //Dependency injection
        private readonly ISession session;
        private ITransaction transaction;

        public MapperSession(ISession session)
        {
            this.session = session;
        }

        public void BeginTransaction() // It starts the transaction.
        {
            transaction = session.BeginTransaction();
        }

        public void Commit() // It commits the changes.
        {
            transaction.Commit();
        }

        public void Rollback() // It rolls-back the database transaction. 
        {
            transaction.Rollback();
        }

        public void CloseTransaction() // It closes the transaction. 
        {
            if (transaction != null)
            {
                transaction.Dispose();
                transaction = null;
            }
        }

        public void Save(T entity) // It adds the entity to the database.
        {
            session.Save(entity);
        }
        public void Update(T entity) // It updates the entity properties. 
        {
            session.Update(entity);
        }
        public void Delete(T entity) // It deletes the entity from database.
        {
            session.Delete(entity);
        }
    }
}
