using Microsoft.AspNetCore.Mvc;
using MonthlyExpenseControl.Model.MonthlySumary;

namespace MonthlyExpenseControl.Api.Controllers
{
    /// <summary>
    /// Api's controller for handling
    /// Expenses and Earnings 
    /// </summary>
    [Route("api/v1")]
    [ApiController]
    public class ExpensesAndEarningsController : ControllerBase
    {
        /// <summary>
        /// Responsible for creating the demonstrative for a month.
        /// This endpoint must be used to create a new balance for a month that doesn’t exist.
        /// </summary>
        /// <returns>Sumary</returns>
        [HttpPost]
        [Route("CreateMonthlyPlan")]
        public IActionResult CreateMonthlyPlan([FromBody] Month monthValues)
        {
            return Ok();
        }

        /// <summary>
        /// Responsible for updating the demonstrative for a month.
        /// This endpoint must be used only to update a monthly plan.
        /// </summary>
        /// <returns></returns>
        [HttpPatch]
        [Route("UpdateMonthlyPlan")]
        public IActionResult UpdateMonthlyPlan()
        {
            return Ok();
        }

        /// <summary>
        /// returns a monthlyPlan
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMonthlyPlan")]
        public IActionResult GetMonthlyPlan()
        {
            return Ok();
        }
    }
}
