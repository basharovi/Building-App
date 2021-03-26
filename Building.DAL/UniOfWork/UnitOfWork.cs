using Building.DAL.Repositories;

namespace Building.DAL.UniOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IReadingRepository readingRepository,
            IBuildingRepository buildingRepository,
            IDataFieldRepository dataFieldRepository,
            IObjectRepository objectRepository)
        {
            ReadingRepository = readingRepository;
            BuildingRepository = buildingRepository;
            DataFieldRepository = dataFieldRepository;
            ObjectRepository = objectRepository;
        }

        public IReadingRepository ReadingRepository { get; }

        public IBuildingRepository BuildingRepository { get; }

        public IDataFieldRepository DataFieldRepository { get; }

        public IObjectRepository ObjectRepository { get; }
    }
}
