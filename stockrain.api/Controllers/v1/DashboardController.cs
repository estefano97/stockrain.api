using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using stockrain.application.Services.Repository;
using stockrain.domain.Entities;

namespace stockrain.api.Controllers.v1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DashboardController : BaseApiController
    {
        private readonly IGetStocksRepository _getStocks;

        public DashboardController(IGetStocksRepository getStocks)
        {
            _getStocks = getStocks;
        }

        [HttpGet("get-initial")]
        public async Task<IActionResult> GetStocksInitial()
        {

            List<InitialStock> data = await _getStocks.GetInitialStock();

            return Ok(data);
        }
    }
}
