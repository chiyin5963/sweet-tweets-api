using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sweet_tweets_api.Models;
using sweet_tweets_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sweet_tweets_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TweetsController: ControllerBase
    {
        private readonly ILogger<TweetsController> _logger;
        private static TweetRepo _repo;
        public TweetsController(ILogger<TweetsController> logger, TweetRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public Tweet Get()
        {
            Random rand = new Random();
            int index = rand.Next(_repo.Tweets.Count);
            return _repo.Tweets[index];
        }

        [HttpGet]
        [Route("text")]
        public string GetAsText()
        {
            Random rand = new Random();
            int index = rand.Next(_repo.Tweets.Count);
            return $"\"{_repo.Tweets[index].message}\" -{_repo.Tweets[index].author}";
        }
    }
}
