namespace Accentuate
{
    public class Quote
    {
        public string quote { get; set; }
        public string film { get; set; }
        public int releaseYear { get; set; }

        public Quote(string quote, string film, int releaseYear)
        {
            this.quote = quote;
            this.film = film;
            this.releaseYear = releaseYear;
        }
    }

    public class QuoteList
    {
        public List<Quote> quoteList { get; private set; }
        public QuoteList()
        {
            this.quoteList = new List<Quote>();
            
            this.quoteList.Add(new Quote("Love means never having to say you're sorry", "Love Story", 1970));;
            this.quoteList.Add(new Quote("They may take our lives, but they'll never take our freedom!", "Braveheart", 1995));;
            this.quoteList.Add(new Quote("If you let my daughter go now, that'll be the end of it. I will not look for you, I will not pursue you. But if you don't, I will look for you, I will find you, and I will kill you.", "Taken", 2008));
            this.quoteList.Add(new Quote("My name is Maximus Decimus Meridius, commander of the Armies of the North, General of the Felix Legions and loyal servant to the true emperor, Marcus Aurelius. Father to a murdered son, husband to a murdered wife. And I will have my vengeance, in this life or the next.", "Gladiator", 2000));
            this.quoteList.Add(new Quote("Get your stinking paws off me, you damned dirty ape!", "Planet of the Apes", 1968));
            this.quoteList.Add(new Quote("Forget it, Jake. It's Chinatown.", "Chinatown", 1974));
            this.quoteList.Add(new Quote("I'm walking here! I'm walking here!", "Midnight Cowboy", 1969));
            this.quoteList.Add(new Quote("Magic Mirror on the wall, who is the fairest one of all?", "Snow White", 1937));
            this.quoteList.Add(new Quote("Wax on, wax off.", "Karate Kid", 1984));
            this.quoteList.Add(new Quote("You ain't heard nothin' yet!", "The Jazz Singer", 1927));
            this.quoteList.Add(new Quote("Gentlemen, you can't fight in here! This is the war room!", "Dr. Strangelove", 1964));
            this.quoteList.Add(new Quote("That'll do, pig. That'll do.", "Babe", 1995));
            this.quoteList.Add(new Quote("I wish I knew how to quit you.", "Brokeback Mountain", 2005));
            this.quoteList.Add(new Quote("Good morning, Vietnam!", "Good Morning Vietnam", 1987));
            this.quoteList.Add(new Quote("I have always depended on the kindness of strangers.", "A Streecar Named Desire", 1951));
            this.quoteList.Add(new Quote("Go ahead, make my day.", "Sudden Impact", 1983));
            this.quoteList.Add(new Quote("You know how to whistle, don't you, Steve? You just put your lips together and blow.", "To Have and Have Not", 1944));
            this.quoteList.Add(new Quote("Hasta la vista, baby.", "Terminator 2 Judgement Day", 1991));
            this.quoteList.Add(new Quote("I'll get you, my pretty, and your little dog, too!", "Wizard of Oz", 1939));
            this.quoteList.Add(new Quote("I'm having an old friend for dinner.", "Silence of the Lambs", 1991));
            this.quoteList.Add(new Quote("Mama says, 'Stupid is as stupid does.'", "Forrest Gump", 1994));
            this.quoteList.Add(new Quote("I'm the king of the world!", "Titanic", 1997));
            this.quoteList.Add(new Quote("What we've got here is a failure to communicate.", "Cool Hand Luke", 1967));
            this.quoteList.Add(new Quote("Keep your friends close, but your enemies closer.", "The Godfather Part II", 1974));
            this.quoteList.Add(new Quote("The greatest trick the devil ever pulled was convincing the world he didn't exist.", "The Usual Suspects", 1995));
            this.quoteList.Add(new Quote("You don't understand! I could've had class. I could've been a contender. I could've been somebody, instead of a bum, which is what I am.", "On the Waterfront", 1954));
            this.quoteList.Add(new Quote("Roads? Where we're going we don't need roads.", "Back to the Future", 1985));
            this.quoteList.Add(new Quote("I love the smell of napalm in the morning.", "Apocalypse Now", 1979));
            this.quoteList.Add(new Quote("You've got to ask yourself one question: 'Do I feel lucky?' Well, do ya punk?", "Dirty Harry", 1971));
            this.quoteList.Add(new Quote("Say hello to my little friend!", "Scarface", 1983));
            this.quoteList.Add(new Quote("Mrs. Robinson, you're trying to seduce me, aren't you?", "The Graduate", 1967));
            this.quoteList.Add(new Quote("I am serious. And don't call me Shirley.", "Airplane", 1980));
            this.quoteList.Add(new Quote("Here's Johnny!", "The Shining", 1980));
            this.quoteList.Add(new Quote("There's no crying in baseball!", "A League of Their Own", 1992));
            this.quoteList.Add(new Quote("Houston, we have a problem.", "Apollo 13", 1995));
            this.quoteList.Add(new Quote("Yippie-ki-yay, motherfucker!", "Die Hard", 1988));
            this.quoteList.Add(new Quote("Why so serious?", "Dark Knight", 2008));
            this.quoteList.Add(new Quote("Hello. My name is Inigo Montoya. You killed my father. Prepare to die.", "The Princess Bride", 1987));
            this.quoteList.Add(new Quote("The first rule of Fight Club is: You do not talk about Fight Club.", "Fight Club", 1999));
            this.quoteList.Add(new Quote("I'm going to make him an offer he can't refuse.", "The Godfather", 1972));
            this.quoteList.Add(new Quote("You're gonna need a bigger boat.", "Jaws", 1975));
            this.quoteList.Add(new Quote("Here's looking at you, kid.", "Casablanca", 1942));
            this.quoteList.Add(new Quote("Frankly, my dear, I don't give a damn.", "Gone With the Wind", 1939));
            this.quoteList.Add(new Quote("A boy's best friend is his mother.", "Psycho", 1960));
            this.quoteList.Add(new Quote("Open the pod bay doors, HAL.", "2001 A Space Aodyssey", 1968));
            this.quoteList.Add(new Quote("He's not the Messiah, he's a very naughty boy", "Life of Brian", 1979));
            this.quoteList.Add(new Quote("I have had it with these motherfuckin’ snakes on this motherfuckin’ plane!", "Snakes on a Plane", 2006));
            this.quoteList.Add(new Quote("Nobody puts Baby in a corner.", "Dirty Dancing", 1987));
            this.quoteList.Add(new Quote("Bring out the gimp", "Pulp Fiction", 1994));
            this.quoteList.Add(new Quote("It doesn’t even have a first name – it just says McLovin!", "Superbad", 2007));
            this.quoteList.Add(new Quote("I can't carry it for you, but I can carry you!", "LOTR Return of the King", 2003));
            this.quoteList.Add(new Quote("The power of Christ compels you", "The Exorcist", 1973));
            this.quoteList.Add(new Quote("You musn't be afraid to dream a little bigger, darling", "Inception", 2010));
            this.quoteList.Add(new Quote("Hope is a good thing, maybe the best of things, and no good thing ever dies", "Shawshank Redemption", 1994));
            this.quoteList.Add(new Quote("Snakes, why did it have to be snakes?", "Raiders of the Lost Ark", 1981));
            this.quoteList.Add(new Quote("Are you gonna bark all day, little doggy, or are you gonna bite?", "Reservoir Dogs", 1992));
            this.quoteList.Add(new Quote("You're a wizard, Harry", "Philosopher's Stone", 2001));
            this.quoteList.Add(new Quote("Where is my super suit?", "Incredibles", 2004));
            this.quoteList.Add(new Quote("Oh look at that, I've been impaled", "Frozen", 2013));
            this.quoteList.Add(new Quote("You thinking what I'm thinking partner? Aim for the bushes?", "The Other Guys", 2010));
            this.quoteList.Add(new Quote("At some point, you got to decide for yourself who you're going to be — can't let nobody make that decision for you", "Moonlight", 2016));
            this.quoteList.Add(new Quote("Well, good morning, everybody, and welcome to day 255,642 aboard the Axiom.", "WALL-E", 2008));
            this.quoteList.Add(new Quote("I used to think this was the beginning of your story. Memory is a strange thing. It doesn't work like I thought it did. We are so bound by time, by its order", "Arrival", 2016));
            this.quoteList.Add(new Quote("Hey TARS, what's your honesty parameter? ", "Interstellar", 2014));
            this.quoteList.Add(new Quote("You're a cunt now, and you've always been a cunt. And the only thing that's going to change is that you're going to be an even bigger cunt.", "In Bruges", 2008));
            this.quoteList.Add(new Quote("All these protocols and procedures to make it seem like you have it under control. But you're a bunch of boys making models out of balsa wood!", "First Man", 2018));
            this.quoteList.Add(new Quote("Were you rushing or were you dragging? ", "Whiplash", 2014));
            this.quoteList.Add(new Quote("In the woods there grew a tree and a fine fine tree was he", "The Wicker Man", 1973));
            this.quoteList.Add(new Quote("Every great magic trick consists of three parts or acts. The first part is called The Pledge.", "The Prestige", 2006));
            this.quoteList.Add(new Quote("Do not try and bend the spoon. That's impossible. Instead... only try to realize the truth. ", "The Matrix", 1999));
            this.quoteList.Add(new Quote("Who the fuck are you? I'm the guy who does his job. You must be the other guy.", "The Departed", 2006));
            this.quoteList.Add(new Quote("Got a name? Officer KD6-3... That's not a name. It's a serial number.", "Blade Runner 2049", 2017));
        }
    };
}