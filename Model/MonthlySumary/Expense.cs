namespace MonthlyExpenseControl.Model.MonthlySumary
{
    /// <summary>
    /// Represents a expense.
    /// </summary>
    public class Expense
    {
        /// <summary>
        /// Expense description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Projected Expense value.
        /// </summary>
        public double ProjectedExpense { get; set; } = 0.00;

        /// <summary>
        /// Incurred Expense value.
        /// </summary>
        public double IncurredExpense { get; set; } = 0.00;
    }
}
