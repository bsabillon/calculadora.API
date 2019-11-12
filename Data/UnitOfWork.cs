using System.Threading.Tasks;

namespace calculadora.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public IOperationsRepository Operations { get; }


        public UnitOfWork(DataContext context)
        {
            _context = context;
            Operations = new OperationRepository(_context);
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}