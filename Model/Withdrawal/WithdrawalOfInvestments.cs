namespace MonthlyExpenseControl.Model.Withdrawal
{
    /// <summary>
    /// Represents monthly Withdraw of the investments
    /// </summary>
    public class WithdrawalOfInvestments
    {
        /// <summary>
        /// Month Name.
        /// </summary>
        public string? Month { get; set; }

        /// <summary>
        /// Withdraw description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Amount that was withdrawn.
        /// </summary>
        public double? WithDrawalValue { get; set; }
    }
}
