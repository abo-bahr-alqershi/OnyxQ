public class TaxInfo : ValueObject
{
    public TaxReference Reference { get; private set; }
    public decimal TaxPercent { get; private set; }
    public decimal? TaxAmount { get; private set; }
    public decimal? TaxableAmount { get; private set; }
    public bool IsExempt { get; private set; }
    public string? ExemptionReason { get; private set; }
    
    public static TaxInfo Create(
        string? accountCode = null,
        int? taxNumber = null,
        int agencyNumber = 0,
        decimal taxPercent = 0,
        decimal? taxAmount = null,
        decimal? taxableAmount = null,
        bool isExempt = false,
        string? exemptionReason = null)
    {
        var info = new TaxInfo
        {
            Reference = TaxReference.Create(accountCode, taxNumber, agencyNumber),
            TaxPercent = taxPercent,
            TaxAmount = taxAmount,
            TaxableAmount = taxableAmount,
            IsExempt = isExempt,
            ExemptionReason = exemptionReason
        };
        
        info.ValidateState();
        return info;
    }
    
    private void ValidateState()
    {
        // تحققات...
    }
}