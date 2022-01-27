using System;

namespace Simple_Base_Code
{
    class Program
    {

		/* Tutorial Room/Janitor Room */
		//make item
		static void makeItem(){
			/* Room One */
			Item nokia = new Item("Nokia Phone", "A Nokia Phone that is not even in production anymore.", 0, false);
			Item ransom = new Item("Ransomware Computer", "A computer that is infected with ransomware.", 0, false);
			Item printer = new Item("Printer", "A printer that broke a while ago.", 0, false);
			Item phoneBook = new Item("Phone Book", "A book that contains all of its owner's most recent calls. Most are to tech support.", 0, false);
			Item teaCup = new Item("Tea Cup", "A mysterious cup of tea. It could give good fortune to those who drink it.", 0, true);
			Item hair = new Item("Hair", "A strand of hair.", 0, true);
			Item spider = new Item("Spider", "A spider that has hid in the janitors cart. He stares at you with his big eyes", 0, true);
			Item eviction = new Item("Eviction Notice", "An eviction notice. Whoever it's for, they've been ignoring it.", 0, true);
			Item flashlight = new Item("Flashlight", "A flashlight. You remember using it recently. You don't know how it got here.", 0,true);

			/* RoomOne */
			Item cipherBook = new Item("Caesar's Cipher Book", "A huge book about ancient Roman encryption. Looks large enough to have a secret compartment, but is stuck closed.", 1, false);
			Item cryptographyBook = new Item("Cryptography Book", "A book about Cryptography. Smells like old book.", 1, false);
			Item ntfsBook = new Item("NTFS Book", "A book about NTFS. I don't know what NTFS stands for.", 1, false);
			Item zodiacPoster = new Item("Zodiac Killer Poster", "A poster for some documentary about the Zodiac Killer. It's a big scan of one of his cipher letters.", 1, false);
			Item pentLetter = new Item("Pentagon Letter", "A letter that says it's from the US Department of Defence. Looks like a page of pure gibberish.", 1, false);
			Item emptyAlbum = new Item("Empty Album", "A case for an album. There's nothing in it.", 1, true);
			Item drakePoster = new Item("Drake Poster", "A huge poster of Drake's face, with some blurb about a concert in Sevastopol at the bottom.", 1, true);
			Item sleepingBag = new Item("Sleeping Bag", "A used LL Bean sleeping bag. It's pretty gross looking.", 1, true);
			Item merchandise = new Item("Drake Merchandise", "A cardboard box full of Drake merchandise.", 1, true);

			/* Room Two */
			Item pillow = new Item("Bitcoin Pillow", "A round pillow with a bitcoin design printed on it. Looks cheap.", 2, false);
			Item moonPoster = new Item("To the Moon Poster", "||I Don't Know What This Is Supposed To Be||", 2, false);
			Item plushy = new Item("Doge Plush Toys", "Plush toys designed to look like the meme dog. Cute?", 2, false);
			Item mirror = new Item("Diamond-Shaped Mirror", "A mirror in a diamond shape. The edges look kinda sharp.", 2, false);
			Item jacket = new Item("Varsity Jacket", "A varsity jacket with a huge number '2' on it. Looks like it hasn't been washed in a few decades.", 2, false);
			//the number 2 is supposed to hint towards ethereum
			//no red herrings

			/* Room Three */
			Item inking = new Item("Inking 2", "A copy of Inking 2. It looks like it's ripping off another game series.", 3, false);
			Item hat = new Item("Red L Hat", "A red hat with the letter L printed on it. It reminds you of two characters.", 3, false);
			Item linkPoster = new Item("The Legend of Link Poster", "A poster that features a tall blonde princess named Link and a short hero named Zelda. Huh.", 3, false);
			Item article = new Item("News article", "The news article talks about a cool new handheld console.", 3, false);
			Item nzap = new Item("N-Zap", "A plastic lazer gun that was used to play some games on the NES.", 3, false);
			Item ballzGame = new Item("Ballz 3D Fighting Game", "A copy of the forgotten fighting game Ballz 3D. You remember the spinoff, Petz", 3, true);
			Item mincraft = new Item("Mincraft", "A bootleg game called Mincraft. It looks familiar.", 3, true);
			Item manga = new Item("Manga", "A off brand manga. Poorly drawn characters are all over the cover.", 3, true);
			Item psFive = new Item("Playstation 5 Controller", "A controller for the Playstation Five. You wonder how it got there.", 3, true);
			Item peanuts = new Item("Circus Peanuts", "A bag of circus peanuts.", 3, true);
			Item clown = new Item("Clown Costume", "A full clown cotsume, nose and all. It looks like it fits you perfectly.", 3, true);
			Item mayo = new Item("Mayo?", "A can of what you think is mayonase. You dont want to taste it", 3, true);
			Item paking = new Item("Box", "A box with a label that says Bosnian Roulette.", 3, true);

			Inventory inventory = new Inventory();
			inventory.addObject(inking);
			inventory.addObject(hat);
			inventory.addObject(article);
			inventory.addObject(linkPoster);
			inventory.addObject(nzap);
			inventory.addObject(mayo);


			nokia.PrintItem();
			peanuts.PrintItem();
			cryptographyBook.PrintItem();
		}

		static void Main(string[] args)
		{
			makeItem();
			/*
			Console.WriteLine("Enter a password(for mastermind test) :");
			string password = Console.ReadLine();
			Mastermind mastermindgame = new Mastermind(password);
			while(mastermindgame.completed == false)
			{
 
				string guess = Console.ReadLine();
				mastermindgame.guess(guess);
			}
			*/
		}
	}
}
