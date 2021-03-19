﻿using Building.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public interface IReadingService
    {
        Task<IReadOnlyList<Reading>> GetAllAsync();
    }
}