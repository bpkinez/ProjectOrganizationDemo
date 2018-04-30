using Microsoft.AspNetCore.Mvc;
using BudgetApp.Core.Accounting;
using BudgetApp.Models;
using System.Collections.Generic;

namespace BudgetApp.BudgetAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/transactions")]
    public class TransactionController : Controller
    {
        TransactionService transactionService;
        List<Transaction> transactions;
    }
}