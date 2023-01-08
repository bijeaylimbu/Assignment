namespace com.assignment.DomainEntities;

public class TariffMaster
{
    public int TariffId { get; set; }
    public  int RebateDays { get; set; }
    public long RebateRate { get; set; }
    public  int PenaltyDays { get; set; }
    public  long PenaltyRate { get; set; }
    public  virtual  ICollection<TariffDetails> TariffDetails { get; set; }
}