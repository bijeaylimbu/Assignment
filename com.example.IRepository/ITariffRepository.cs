using com.assignment.Common;
using com.assignment.Requests;

namespace com.example.IRepository;

public interface ITariffRepository: IUnitOfWork
{
     Task<AmountResponse> GetTariffAmount(CalculationRequest request);
}