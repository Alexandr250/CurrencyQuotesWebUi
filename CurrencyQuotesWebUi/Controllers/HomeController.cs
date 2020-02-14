using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CurrencyQuotesCore;

namespace CurrencyQuotesWebUi.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            ExchangeRatesLocalRepository repository = new ExchangeRatesLocalRepository( new System.IO.FileInfo( "daily.json" ) );
            return View( repository.WithFilter( null ) );
        }
    }
}
