namespace MonthlyExpenseControl.Model.Investments
{
    /// <summary>
    /// Monthly investment summary.
    /// </summary>
    public class MonthInvestment
    {
        /// <summary>
        /// Month that the investment happened.
        /// </summary>
        public string? Month { get; set; }

        /// <summary>
        /// The amount invested.
        /// </summary>
        public double? InvestmentAmount { get; set; }

        /// <summary>
        /// Type of investment.
        /// </summary>
        public string? TypeOfInvestment { get; set; }

        /// <summary>
        /// The percentage invested related to the salary amount for example 0.10.
        /// </summary>
        public double? InvestmentPercentage { get; set; }
    }
}
