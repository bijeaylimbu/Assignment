using com.assignment.Common;
using com.assignment.Requests;
using com.example.IRepository;

namespace com.example.Repository;

public class TariffRepository: ITariffRepository
{
    public async Task<AmountResponse> GetTariffAmount(CalculationRequest request)
    {
        try
        {
            if (request.LastReading < request.CurrentReading)
            {
                throw new ArgumentException("Last Reading cannot be greater than Current Reading");
            }
            double energyRate = 0;
            double serviceCharge = 0;
            double readingDifference = request.LastReading - request.CurrentReading;


            if (readingDifference >= 0 && readingDifference <= 10)
            {
                energyRate = 0;
                serviceCharge = 30;
                var amount = readingDifference + (energyRate * serviceCharge);
                return new AmountResponse(amount);
            }
            else if (readingDifference >= 11 && readingDifference <= 20)
            {
                energyRate = 3;
                serviceCharge = 30;
                var amount = readingDifference + (energyRate * serviceCharge);
                return new AmountResponse(amount);
            }
            else if (readingDifference >= 21 && readingDifference <= 30)
            {
                energyRate = 6.5;
                serviceCharge = 50;
                var amount = (10 * 3) + (readingDifference + (energyRate * serviceCharge));
                return new AmountResponse(amount);
            }
            else if (readingDifference >= 31 && readingDifference <= 50)
            {
                energyRate = 8;
                serviceCharge = 50;
                var amount = (10 * 3) + (6.5 * 10) + (readingDifference + (energyRate * 20));
                return new AmountResponse(amount);
            }
            else if (readingDifference >= 51 && readingDifference <= 100)
            {
                energyRate = 9;
                serviceCharge = 75;
                var amount = (10 * 3) + (6.5 * 10) + (8 * 20) + (readingDifference + (energyRate * 50));
                return new AmountResponse(amount);
            }
            else if (readingDifference >= 101 && readingDifference <= 200)
            {
                energyRate = 10;
                serviceCharge = 100;
                var amount = (10 * 3) + (6.5 * 10) + (8 * 20) + (9 * 50) + (readingDifference + (energyRate * 100));
                return new AmountResponse(amount);
            }
            else
            {
                energyRate = 11;
                serviceCharge = 150;
                var amount = (10 * 3) + (6.5 * 10) + (8 * 20) + (9 * 50) + (11 * 150) +
                             (readingDifference + (energyRate * serviceCharge));
                return new AmountResponse(amount);
            }

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
       
    }
}