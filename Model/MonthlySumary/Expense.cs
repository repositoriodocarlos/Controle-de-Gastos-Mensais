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
        public double ProjectedExpense { get; set; }

        /// <summary>
        /// Incurred Expense value.
        /// </summary>
        public double IncurredExpense { get; set; }
    }
}
