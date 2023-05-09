namespace MonthlyExpenseControl.Model.MonthlySumary
{
    /// <summary>
    /// Monthly sumary of Total earnings and Expenses.
    /// </summary>
    public class Sumary
    {
        /// <summary>
        /// Total earnings.
        /// </summary>
        public Earning? Earnings { get; set; }

        /// <summary>
        /// Total Earning.
        /// </summary>
        public Expense? Expenses { get; set; }

        /// <summary>
        /// Total Investment Capacity.
        /// </summary>
        public InvestmentCapaticy? InvestmentCapacity { get; set; }
    }
}
