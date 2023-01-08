namespace com.assignment.Requests;

public record CalculationRequest( int  TariffId, long LastReading, long CurrentReading );