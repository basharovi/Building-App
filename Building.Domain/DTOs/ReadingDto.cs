using System;

namespace Building.Domain
{
    public class ReadingDto
    {
        public int BuildingId { get; set; }
        public int DataFieldId { get; set; }
        public int ObjectId { get; set; }
        public DateTime TimestampFrom { get; set; }
        public DateTime TimestampTo { get; set; }

    }
}
