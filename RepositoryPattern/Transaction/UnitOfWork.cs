using RepositoryPattern.Data;
using RepositoryPattern.Transaction.Interfaces;

namespace RepositoryPattern.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            /* Ao não fazer nada no rollback, no fim da requisição
             * o Garbage Collector retira os objetos da memória
             * e não ocorre a persistência no banco
             */
        }
    }
}
