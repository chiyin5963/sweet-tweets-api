using sweet_tweets_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sweet_tweets_api.Repository
{
    public class TweetRepo
    {
        public List<Tweet> Tweets;
        public TweetRepo()
        {
            Tweets = new List<Tweet>()
            {
                new Tweet() { message = "mmm. urinal cakes are cinnamon flavored. I mean scented. Scented!", author = "Capcom USA"},
                new Tweet() { message = "Fact: rap isn't music. And if you think it is, you're stupid.", author = "Ben Shapiro"},
                new Tweet() { message = "about to go to mcdonalds before school swag", author = "Playboi Carti" },
                new Tweet() { message = "Can I text u", author = "Hulk Hogan"},
                new Tweet() { message = "AAAAAAAAAAAAHHHHHRHRGRGRGRRRGURBHJBEORWPSOJWPJORGWOIRGWSGODEWPGOHEPW09GJEDPOKSD!!!!!!!!!!!!!!!0294QU8T63095JRGHWPE09UJ0PWHRGW", author = "Lady Gaga"},
                new Tweet() { message = "i have a really odd talent. i can smell when someone has cavities! i have never been wrong yet! they dont even have 2 be super close to me", author = "Kim Kardashian"},
                new Tweet() { message = "Why is rhode  island nor a road or an island", author = "Justin Bieber"},
                new Tweet() { message = "I feel like there's a giant meatloaf inside of me", author = "Kris Jenner"},
                new Tweet() { message = "soo hungry need to find my wife and head to pf changs", author = "Los Angeles Chargers"},
                new Tweet() { message = "What if Bing is just a guy in his office Googling stuff for you and doing his best", author = "Radrosaur"},
                new Tweet() { message = "Listen, frozen meal instructions, never in the history of owning microwaves have I known the wattage of any microwave", author = "Salty Mermaid"},
                new Tweet() { message = "every time i get brushed. i have to take my collar off. the human always laughs. and says that i'm naked. but joke's on them. i'm very confident in my body", author = "Thoughts of Dog"},
                new Tweet() { message = "I think I'm over her", author = "ozzy"},
                new Tweet() { message = "Without a doubt in my mind the next multi billion dollar company will be a toilet that tells you how much your poop weighs", author = "MrBeast"},
                new Tweet() { message = "can i get\nuhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhuhhhhhh", author = "McDonald's"},
                new Tweet() { message = "careening wildly into your dm's", author = "Hozier"},
                new Tweet() { message = "Drat... and double drat.\n\n That is all.", author = "Hozier"},
                new Tweet() { message = "If I got any cooler I would freeze to death", author = "ye"},
                new Tweet() { message = "Do you know where to find marble conference tables? I'm looking to have a conference... not until I get the table though", author = "Kanye West"},
                new Tweet() { message = "You have distracted from my creative process", author = "Kanye West"},
                new Tweet() { message = "I hate when I'm on a flight and I wake up with a water bottle next to me like oh great now I gotta be responsible for this water bottle", author = "Kanye West"},
                new Tweet() { message = "Sorry losers and haters, but my I.Q. is one of the highest -and you all know it! Please don't feel so stupid or insecure,it's not your fault", author = "Donald Trump"},
                new Tweet() { message = "Everyone knows that I am right that Robert Pattinson should dump Kristen Stewart. In a couple of years, he will thank me. Be smart, Robert.", author = "Donald Trump"},
                new Tweet() { message = "I put the art in fart", author = "Elon Musk"},
                new Tweet() { message = "420 is ten times better than 42", author = "Elon Musk"},
                new Tweet() { message = "Sick of having to go to 2 different huts to buy pizza & sunglasses.", author = "Elon Musk"},
                new Tweet() { message = "last night i had cereal with milk for the first time. life changing.", author = "Kylie Jenner"},
                new Tweet() { message = "Rocks, paper, siccor.......", author = "Ryan Lochte"},
                new Tweet() { message = "I'm watching the History channel in the club and I'm wondering how do these people kno what's going on then sun..ain't nobody ever been", author = "Kevin Durant"},
                new Tweet() { message = "i love arm", author = "Justin Bieber"},
                new Tweet() { message = "How many ladies aint scared 2 fart in front of ur man?", author = "Ashanti"},
                new Tweet() { message = "Does anyone think global warming is a good thing? I love Lady Gaga. I think she's a really interesting artist.", author = "Britney Spears"},
                new Tweet() { message = "If chickens could say love me love me that would be awsome.", author = "Justin Bieber"},
                new Tweet() { message = "During lockdown, while many other artists are doing mini-concerts from their homes, I thought I'd do you a favor and not.", author = "James Blunt"},
                new Tweet() { message = "I'm thoroughly convinced that I'm locked into a system designed to make me go on a murderous rampage", author = "Brett Haddock"},
                new Tweet() { message = "reality is not real", author = "NYT Minus Context"},
                new Tweet() { message = "i'll bring McNuggets", author = "McDonald's"},
                new Tweet() { message = "Gonezo", author = "Connor McGregor"},
                new Tweet() { message = "I just sat in the shower for an hour thinking about how Mercedes has 3 E's all pronounced differently", author = "Snoop Dogg"},

            };
        }
    }
}
