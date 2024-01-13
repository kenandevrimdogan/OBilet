﻿using LocationBus.API.Models.Request;
using LocationBus.API.Models.Response;

namespace LocationBus.API.Infrastructure
{
    public interface ILocationBusService
    {
       Task<BusLocationResponseModel> GetBuslocationsAsync(BuslocationRequest request);
    }
}