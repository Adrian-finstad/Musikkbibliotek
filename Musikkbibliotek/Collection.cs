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



        public Collection()
        {
            AlbumCollection = new List<Album>()
        {
            new Album("Another Year of Disaster", 2009, "Adept",new List<Song>
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


            new Album("Pain Remains",2022, "Lorna Shore", new List<Song>
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


            new Album("Scoring The End Of The World", 2022, "Motionless In White", new List<Song>
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
            var userInput = Console.ReadLine();
            Console.Clear();
            switch (userInput) 
            {
                case "1": DisplayAllAlbums(); break;
                case "2": DisplayRandomAlbum(); break;
                case "3": AddNewAlbum(); break;
                case "4":
                    DisplayAllAlbums();
                    Console.WriteLine("Please type in the corresponding number-id of the album you wish to remove.");
                    var isNumber = int.TryParse(Console.ReadLine(), out int userInputAsNumber);
                    RemoveAlbum(userInputAsNumber); break;
                default:  InitMusicCollection(); break;

            }
        }


        public void DisplayAllAlbums()
        {
            for (int i = 0; i < AlbumCollection.Count; i++)
            {
                    Console.WriteLine($"{i} - Album name:{AlbumCollection[i].GetAlbumName()}, Releaseyear: {AlbumCollection[i].GetReleaseYear()}, Artist: {AlbumCollection[i].GetBandName()}");   
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }




        //int index = 1;
        //foreach (var album in AlbumCollection)
        //{
        //    Console.WriteLine($"{index} - Album name:{album.GetAlbumName()}, Releaseyear: {album.GetReleaseYear()}, Artist: {album.GetBandName()}");
        //    index++;
        //}
        //Console.WriteLine("Press enter to return to the main menu.");
        //Console.ReadLine();
        //Console.Clear();

        public void DisplayRandomAlbum()
        {
            if (AlbumCollection.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, AlbumCollection.Count);

                Album randomAlbum = AlbumCollection[randomIndex];
                Console.WriteLine($"Random Album: {randomAlbum.GetAlbumName()}");
                Console.WriteLine($"Release year: {randomAlbum.GetReleaseYear()}");
                Console.WriteLine($"Band: {randomAlbum.GetBandName()}");
            }

        }


        public void AddNewAlbum()
        {
            Album newAlbum = new Album();
            newAlbum.SetNameOfNewAlbum();
            newAlbum.SetReleaseYearOfNewAlbum();
            newAlbum.SetBandNameOfNewAlbum();
            AlbumCollection.Add( newAlbum );
            Console.WriteLine("Your new album was added! Press enter to continue.");
            Console.ReadLine();

        }

        public void RemoveAlbum(int albumId)
        { 
            AlbumCollection.Remove(AlbumCollection[albumId]);
            Console.WriteLine($"{AlbumCollection[albumId].GetAlbumName()} was removed!");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

    }


        
         


}
 
    

        










    