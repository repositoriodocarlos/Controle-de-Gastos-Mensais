namespace MonthlyExpenseControl.Model.MonthlySumary
{
    /// <summary>
    /// Represents monthly investment capacity
    /// </summary>
    public class InvestmentCapaticy
    {
        /// <summary>
        /// Projected investment capacity.
        /// </summary>
        public double ProjectedInvestmentCapacity { get; set; } = 0.00;

        /// <summary>
        /// Incurred investment capacity 
        /// </summary>
        public double IncurredInvestmentCapacity { get; set; } = 0.00;
    }
}
