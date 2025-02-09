namespace apartment.Types;

public class RentalPricing(decimal monthlyRent, decimal securityDeposit, decimal maintenanceFee)
{
    public decimal MonthlyRent { get; set; } = monthlyRent;
    public decimal SecurityDeposit { get; set; } = securityDeposit;
    public decimal MaintenanceFee { get; set; } = maintenanceFee;
}