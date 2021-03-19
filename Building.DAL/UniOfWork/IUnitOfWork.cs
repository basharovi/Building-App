using Building.DAL.Repositories;

namespace Building.DAL.UniOfWork
{
    public interface IUnitOfWork
    {
        IReadingRepository ReadingRepository { get; }
    }
}
