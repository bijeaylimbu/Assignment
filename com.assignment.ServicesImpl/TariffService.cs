using com.assignment.Common;
using com.assignment.IServices;
using com.assignment.Requests;
using com.example.IRepository;

namespace com.assignment.ServicesImpl;

public class TariffService: ITariffService
{
    private readonly ITariffRepository _tariffRepository;

    public TariffService(ITariffRepository tariffRepository)
    {
        _tariffRepository = tariffRepository ?? throw new ArgumentNullException(nameof(tariffRepository));
    }
    public async Task<ResponseModel> GetTariffAmount(CalculationRequest request)
    {
        var result = await _tariffRepository.GetTariffAmount(request);
        return new ResponseModel
        {
            Data = result.Total.ToString(),
        };
    }
}