﻿using Microsoft.AspNetCore.Mvc;
using OBilet.API.Infrastructure;
using OBilet.API.Models.Request.Client;
using OBilet.API.Models.Response.Client;

namespace OBilet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost("getBuslocations")]
        public async Task<SessionResponse> GetBusLocationsAsync([FromBody] SessionRequest request)
        {
            return await _clientService.GetSessionAsync(request);
        }
    }
}