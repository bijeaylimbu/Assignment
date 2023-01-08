namespace com.assignment.DomainEntities;

public class TariffDetails
{
    public  int TariffId { get; set; }
    public int StartUnit { get; set; }
    public int EndUnit { get; set; }
    public long EnergyRate { get; set; }
    public long ServiceCharge { get; set; }

    public virtual TariffMaster TarifMaster { get; set; }
}