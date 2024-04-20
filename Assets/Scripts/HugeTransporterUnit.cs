// INHERITANCE
public class HugeTransporterUnit: TransporterUnit
{
    public HugeTransporterUnit()
    {
        MaxAmountTransported = 100;
    }

    // POLYMORPHISM
    public override string GetName()
    {
        return "Huge Transporter";
    }

    // POLYMORPHISM
    public override string GetData()
    {
        return $"Can transport up to {MaxAmountTransported}";
    }
}