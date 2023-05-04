namespace MonthlyExpenseControl.Model.MonthlySumary
{
    /// <summary>
    /// This class represents the summary of monthly
    /// expenses and earnings, considering projected
    /// and realized.
    /// </summary>
    public class Month
    {
        public List<MonthlyEarnings>? MonthlyEarnings { get; set; }
        public List<MonthlyExpenses>? MonthlyExpenses { get; set; }
    }
}
