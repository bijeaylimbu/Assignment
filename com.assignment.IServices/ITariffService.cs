using com.assignment.Common;
using com.assignment.Requests;

namespace com.assignment.IServices;

public interface ITariffService
{
   Task<ResponseModel> GetTariffAmount(CalculationRequest request);
}