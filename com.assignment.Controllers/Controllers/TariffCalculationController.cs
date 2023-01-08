using com.assignment.Common;
using com.assignment.IServices;
using com.assignment.Requests;
using Microsoft.AspNetCore.Mvc;

namespace com.assignment.TariffCalculation.Controllers;

[ApiController]
[Route("tariff")]
[Produces("application/json")]
public class TariffCalculationController : ControllerBase
{

    private readonly ITariffService _tariffService;

    public TariffCalculationController(ITariffService tariffService)
    {
        _tariffService = tariffService ?? throw new ArgumentNullException(nameof(tariffService));
    }
    
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPost("bill-amount")]
    public async Task<ResponseModel> GetBillAmount([FromBody] CalculationRequest request )
    {
        var result = await _tariffService.GetTariffAmount(request);
        return result;
    }
}