using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.NHibernate
{
    //Since all of these operations could be used for different entities, a "Generic" type was done.
    //If a different entity is added to the program later, it is enough for us to send the relevant entity instead of "T" to apply the methods in it.
    public interface IMapperSession<T> 
    {
        void BeginTransaction(); // It starts the transaction.
        void Commit(); // It commits the changes.
        void Rollback(); // It rolls-back the database transaction. 
        void CloseTransaction(); // It closes the transaction. 
        void Save(T entity); // It adds the entity to the database.
        void Update(T entity); // It updates the entity properties. 
        void Delete(T entity); // It deletes the entity from database.

    }
}
