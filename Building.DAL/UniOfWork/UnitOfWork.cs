using Building.DAL.Repositories;

namespace Building.DAL.UniOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IReadingRepository readingRepository)
        {
            ReadingRepository = readingRepository;
        }

        public IReadingRepository ReadingRepository { get; }
    }
}
