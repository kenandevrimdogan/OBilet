using Identity.API.Infrastructure;
using Identity.API.Models.Request.OBiletApi;
using Identity.API.Models.Response;
using Identity.API.Models.Response.OBiletApi;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("getSession")]
        public async Task<Result<SessionResponse>> GetSessionAsync([FromBody] SessionRequest request)
        {
            return await _identityService.GetSessionAsync(request);
        }
    }
}
