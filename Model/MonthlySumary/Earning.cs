namespace MonthlyExpenseControl.Model.MonthlySumary
{
    /// <summary>
    /// Represents a earning.
    /// </summary>
    public class Earning
    {
        /// <summary>
        /// Earning description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Projected Earning value.
        /// </summary>
        public double? ProjectedEarning { get; set; } = 0.00;

        /// <summary>
        /// Incurred Earning value.
        /// </summary>
        public double IncurredEarning { get; set; } = 0.00;
    }
}
