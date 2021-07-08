using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using raven_db_api.Repositories;
using Raven.Client.Documents;

namespace raven_db_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;
        private readonly ISearchRepository _searchRepository;

        public SearchController(ILogger<SearchController> logger, ISearchRepository searchRepository)
        {
            _logger = logger;
            _searchRepository = searchRepository;
        }

        [HttpGet]
        public IActionResult GetSearchResult()
        {
            // _searchRepository.
            return Ok("Ok");
        }
        
        
        [HttpPost]
        public IActionResult AddSearch()
        {
            _searchRepository.AddDocument();
            return Ok("Ok");
        }
    }
}