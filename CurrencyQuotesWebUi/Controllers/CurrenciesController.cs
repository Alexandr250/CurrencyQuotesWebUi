using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyQuotesCore;
using CurrencyQuotesCore.Entites;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyQuotesWebUi.Controllers {
    [Route( "api/[controller]" )]
    public class CurrenciesController : Controller {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Currency> Get() {
            ExchangeRatesLocalRepository repository = new ExchangeRatesLocalRepository( new System.IO.FileInfo( "daily.json" ) );
            return repository.WithFilter( null );
        }

        // GET: api/<controller>
        [HttpGet( "{filter}" )]
        public IEnumerable<Currency> Get( string filter ) {
            ExchangeRatesLocalRepository repository = new ExchangeRatesLocalRepository( new System.IO.FileInfo( "daily.json" ) );
            return repository.WithFilter( filter );
        }

        // GET api/<controller>/5
        //[HttpGet( "{id}" )]
        //public string Get( int id ) {
        //    return "value";
        //}

        // POST api/<controller>
        [HttpPost]
        public void Post( [FromBody]string value ) {
        }

        // PUT api/<controller>/5
        [HttpPut( "{id}" )]
        public void Put( int id, [FromBody]string value ) {
        }

        // DELETE api/<controller>/5
        [HttpDelete( "{id}" )]
        public void Delete( int id ) {
        }
    }
}
