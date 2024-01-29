using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikkbibliotek
{
    internal class Collection
    {
        private List<Album> AlbumCollection;
        private Album currentlyPlayingAlbum;
        
        public Collection()
        {
            currentlyPlayingAlbum = null;
            AlbumCollection = new List<Album>( )
        {  
            new CD("CD","Another Year of Disaster", 2009, "Adept",new List<Song>
            {
                new Song("Business of Living", "Adept", 0),
                new Song("Shark! Shark! Shark!","Adept",0),
                new Song("Sound the Alarm", "Adept",0),
                new Song("At Least Give Me My Dreams Back, You Negligent Whore!", "Adept", 0),
                new Song("Caution! Boys Night Out","Adept", 0),
                new Song("The Ballad of Planet Earth", "Adept", 0),
                new Song("Lets Celebrate, Gorgeous!(You Know Whose Party This Is)","Adept",0),
                new Song("Grow Up, Peter Pan", "Adept", 0),
                new Song("An Era of Treachery", "Adept", 0),
                new Song("Everything Dies", "Adept", 0),
            }),


            new CD("CD","Pain Remains",2022, "Lorna Shore", new List<Song>
            {
                new Song("Welcome Back, O' Sleeping Dreamer", "Lorna Shore", 0),
                new Song("Into the Earth", "Lorna Shore", 0),
                new Song("Sun//Eater", "Lorna Shore", 0),
                new Song("Cursed to Die", "Lorna Shore", 0),
                new Song("Soulless Existence", "Lorna Shore", 0),
                new Song("Apotheosis", "Lorna Shore", 0),
                new Song("Wrath", "Lorna Shore", 0),
                new Song("Pain Remains I: Dancing Like Flames", "Lorna Shore", 0),
                new Song("Pain Remains II: After All I've Done, I'll Disappear", "Lorna Shore",0),
                new Song("Pain Remains III: In a Sea of Fire", "Lorna Shore", 0),
            }),


            new CD("CD","Scoring The End Of The World", 2022, "Motionless In White", new List<Song>
            {
                new Song("Meltdown", "Motionless In White",0),
                new Song("Sign Of Life", "Motionless In White",0),
                new Song("Werewolf", "Motionless In White",0),
                new Song("Porcelain", "Motionless In White",0),
                new Song("Slaughterhouse(feat. Bryan Garris)", "Motionless In White",0),
                new Song("Masterpiece", "Motionless In White",0),
                new Song("Cause Of Death", "Motionless In White",0),
                new Song("We Become The Night","Motionless In White",0),
                new Song("Burned At Both Ends II","Motionless In White",0),
                new Song("BFBTG: Corpse Nation","Motionless In White",0),
                new Song("Cyberhex","Motionless In White",0),
                new Song("Red, White & Boom(feat. Caleb Shomo)","Motionless In White",0),
            }),


            new Casette("Casette","The Best Of The Alan Parsons Project",1977,"The Alan Parsons Project", new List<Song>
                {
                    new Song("I Wouldn't Want To Be Like You", "The Alan Parsons Project",0),
                    new Song("Eye In The Sky - Remastered","The Alan Parsons Project",0),
                    new Song("Games People Play", "The Alan Parsons Project",0),
                    new Song("Time","The Alan Parsons Project",0),
                    new Song("Pyramania","The Alan Parsons Project",0),
                    new Song("You Don't Believe","The Alan Parsons Project",0),
                    new Song("Lucifer","The Alan Parsons Project",0),
                    new Song("Psychobabble","The Alan Parsons Project",0),
                    new Song("Damned If I Do","The Alan Parsons Project",0),
                    new Song("Don't Let It Show","The Alan Parsons Project",0),
                    new Song("Can't Take It With You","The Alan Parsons Project",0),
                    new Song("Old And Wise","The Alan Parsons Project",0),
                }),

            new Casette("Casette","Best of the Alan Parsons Project, Vol. 2",1984,"The Alan Parsons Project", new List<Song>
                {
                    new Song("Prime Time","The Alan Parsons Project",0),
                    new Song("Let's Talk About Me","The Alan Parsons Project",0),
                    new Song("Standing On Higher Ground","The Alan Parsons Project",0),
                    new Song("Stereotomy","The Alan Parsons Project",0),
                    new Song("Don't Answer Me","The Alan Parsons Project",0),
                    new Song("Limelight","The Alan Parsons Project",0),
                    new Song("I Robot","The Alan Parsons Project",0),
                    new Song("What Goes Up","The Alan Parsons Project",0),
                    new Song("Days Are Numbers","The Alan Parsons Project",0),
                    new Song("Ammonia Avenue","The Alan Parsons Project",0),
                    new Song("The Turn of a Friendly Card, Pt. 2","The Alan Parsons Project",0),
                }),

            new Vinyl("Vinyl", "Everyone Is Everybody Else", 1974, "Barclay James Harvest", new List<Song>
                {
                    new Song("Child Of The Universe","Barclay James Harvest",0),
                    new Song("Negative Earth","Barclay James Harvest",0),
                    new Song("Paper Wings","Barclay James Harvest",0),
                    new Song("The Great 1974 Mining Disaster","Barclay James Harvest",0),
                    new Song("Crazy City","Barclay James Harvest",0),
                    new Song("See Me See You","Barclay James Harvest",0),
                    new Song("Poor Boy Blues","Barclay James Harvest",0),
                    new Song("Mill Boys","Barclay James Harvest",0),
                    new Song("For No One","Barclay James Harvest",0),
                    new Song("Child Of The Universe - US Single version","Barclay James Harvest",0),
                    new Song("The Great 1974 Mining Disaster - Original Mix","Barclay James Harvest",0),
                    new Song("Maestoso (A Hymn In The Roof Of The World)","Barclay James Harvest",0),
                    new Song("Negative Earth - Original Mix","Barclay James Harvest",0),
                    new Song("Child Of The Universe - Alternate Recording","Barclay James Harvest",0),
                })
            };
        
        }
        public void InitMusicCollection()
        {
            Console.WriteLine("Welcome to your music collection!");
            Console.WriteLine("What do you wish to do?");
            Console.WriteLine("1. Display all albums");
            Console.WriteLine("2. Display random album");
            Console.WriteLine("3. Add a new album");
            Console.WriteLine("4. Remove an album");
            Console.WriteLine("5. Play an album");
            Console.WriteLine("6. Play a random album.");
            var userInput = Console.ReadLine();
            Console.Clear();
            switch (userInput) 
            {
                case "1": DisplayAllAlbums(); break;
                case "2": DisplayRandomAlbum(); break;
                case "3": Console.WriteLine("Please type in the format of the album you wish to add (i.e 'casette', 'vinyl' or 'cd', then press enter."); 
                    var chosenUserFormat = Console.ReadLine();
                    AddNewAlbum(chosenUserFormat); break;
                case "4":
                    DisplayAllAlbums();
                    Console.WriteLine("Please type in the corresponding number-id of the album you wish to remove.");
                    var isNumber = int.TryParse(Console.ReadLine(), out int userInputAsNumber);
                    RemoveAlbum(userInputAsNumber); break;
                case "5":
                    DisplayAllAlbums();
                    Console.WriteLine("Please type in the number of the album you wish to play.");
                   var albumToPlay = int.TryParse(Console.ReadLine(), out int albumChoiceAsNumber);
                    PlayAlbum(AlbumCollection[albumChoiceAsNumber]);
                    break;
                case "6":
                    PlayRandomAlbum();
                    break;
                default:  InitMusicCollection(); break;

            }
        }
        public void DisplayAllAlbums()
        {
            for (int i = 0; i < AlbumCollection.Count; i++)
            {
                    Console.WriteLine($"{i} - Album name:{AlbumCollection[i].GetAlbumName()}, Format: {AlbumCollection[i].GetFormat()} Releaseyear: {AlbumCollection[i].GetReleaseYear()}, Artist: {AlbumCollection[i].GetBandName()}");   
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void DisplayRandomAlbum()
        {
            if (AlbumCollection.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, AlbumCollection.Count);

                Album randomAlbum = AlbumCollection[randomIndex];
                Console.WriteLine($"Random Album: {randomAlbum.GetAlbumName()}");
                Console.WriteLine($"Random Album Format: {randomAlbum.GetFormat()}");
                Console.WriteLine($"Release year: {randomAlbum.GetReleaseYear()}");
                Console.WriteLine($"Band: {randomAlbum.GetBandName()}");
            }
            Console.WriteLine("Press enter to return to the main menu.");
            Console.ReadLine();
            Console.Clear();

        }
        public void AddNewAlbum(string format)
        {
            var newAlbum = new Album();
            switch (format.ToLower())
            {
                case "cd":
                    newAlbum = new CD();
                    break;
                case "casette":
                    newAlbum = new Casette();
                    break;
                case "vinyl":
                    newAlbum = new Vinyl();
                    break;
                default:
                    Console.WriteLine("Invalid format. Album not added.");
                    return;
            }
            newAlbum.SetNameOfNewAlbum();
            newAlbum.SetReleaseYearOfNewAlbum();
            newAlbum.SetBandNameOfNewAlbum();

            Console.Write("Do you want to add songs to the album?(yes/no):");
            string ifAddSongsInput = Console.ReadLine();
            if (ifAddSongsInput.ToLower() == "yes")
            {
                Console.Write("Enter the number of songs to add:");
                var isNumber = int.TryParse(Console.ReadLine(), out int userInputAsNumber);
                for (int i = 0; i < userInputAsNumber; i++)
                {
                    Song newSong = new Song();
                    newSong.SetSongName();
                    newSong.SetSongBandName();
                    newSong.SetPlayCount();
                }
            }
            AlbumCollection.Add(newAlbum);
            Console.WriteLine("Your new album was added! Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

        }
        public void RemoveAlbum(int albumId)
        { 
            AlbumCollection.Remove(AlbumCollection[albumId]);
            Console.WriteLine($"{AlbumCollection[albumId].GetAlbumName()} was removed!");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void PlayAlbum(Album album)
        {
            if (album != null)
            {
                currentlyPlayingAlbum = album;
                Console.WriteLine($"Now playing {album.GetAlbumName()}, by {album.GetBandName()}.");
            }
            else 
            {
                Console.WriteLine("Album not found or not specified.");
            }
            Console.WriteLine("Press enter to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        public void PlayRandomAlbum()
        {
            if (AlbumCollection.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, AlbumCollection.Count);
                Album randomAlbumToPlay = AlbumCollection[randomIndex];
                Console.WriteLine($"{randomAlbumToPlay.GetAlbumName()} by {randomAlbumToPlay.GetBandName()} is now playing.");
                Console.WriteLine("Press enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }


}

         



 
    

        










    