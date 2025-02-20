using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Finance.Models;

namespace Finance.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _db;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
    {
        _logger = logger;
        _db = applicationDbContext;
    }

    public String Index()
    {
        String accounts = "";

        using (var context = _db)
        {

            var accountList = context.Accounts.ToList();

            foreach (var account in accountList){
                accounts = accounts + account.AccountName;
            }

        }

        return accounts;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
