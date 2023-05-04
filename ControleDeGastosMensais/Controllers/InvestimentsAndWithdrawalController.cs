using Microsoft.AspNetCore.Mvc;

namespace MonthlyExpenseControl.Api.Controllers
{
    /// <summary>
    /// Api's controller for handling
    /// Investiments and Withdraws from investments
    /// </summary>
    /// 
    [Route("api/v1")]
    [ApiController]
    public class InvestimentsAndWithdrawalController : ControllerBase
    {
        /// <summary>
        /// returns the monthly investments and withdrawals from investments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetInvestimentsAndWithdrawal")]
        public IActionResult GetInvestimentsAndWithdrawal()
        {
            return Ok();
        }

        /// <summary>
        /// returns the monthly investments and withdrawals from investments
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [Route("UpdateMonthlyInvestment")]
        public IActionResult UpdateMonthlyInvestment()
        {
            return Ok();
        }

        /// <summary>
        /// responsible for create a new withdrawal.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("PutWithdrawal")]
        public IActionResult PutWithdrawal()
        {
            return Ok();
        }

        /// <summary>
        ///  responsible for update a withdrawal.
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [Route("UpdateWithdrawal")]
        public IActionResult UpdateWithdrawal()
        {
            return Ok();
        }

        /// <summary>
        ///  responsible for delete a withdrawal.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("UpdateWithdrawal")]
        public IActionResult DeleteWithdrawal()
        {
            return Ok();
        }
    }
}
