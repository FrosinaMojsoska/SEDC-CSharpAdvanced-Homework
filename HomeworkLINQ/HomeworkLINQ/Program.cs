using Entities_for_Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLINQ
{
    class Program
    {
        public static List<Artist> Artists { get; set; }
        public static List<Album> Albums { get; set; }
        public static List<Song> Songs { get; set; }
        static void Main(string[] args)
        {









            Init();// this method fills the arrays above with data

            /*
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░████████░░░░░░░░░
                ░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░
                ░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒███░░░░
                ░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░
                ░░░░█▒▒▒▒▒█░░░██▒▒▒▒▄██▄▒▒▒▒▄██▄▒▒▒███░
                ░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒██
                ░░░█████████████▒▒▒▒▀██▀▒▒▒▒▀██▀▒▒▒▒▒██
                ░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒██
                ░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒██▒▒▒▒██
                ██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒▒▒██
                █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒███████▒▒▒▒▒▒▒██
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░
                ░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░
                ░██▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░
                ░░████████████░░░████████████████░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░▄█████▄░▄███████▄░▄███████▄░██████▄░░
                ░░██▒▒▒▒█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░██▒▒▒▒▒░██▒▒▒▒▒██░██▒▒▒▒▒██░██▒▒▒██░░
                ░░██▒▒▒▀█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░▀█████▀░▀███████▀░▀███████▀░██████▀░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░▄█████░██▒▒▒▒██▀░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▀▒▒▒░██▒▒▒██░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▒▒▒▒░█████▀░░░░░░░
                ░░░░██▒▒▒▒░██▄▒▄██░██▄▒▒▒░██▒▒▒██░░░░░░
                ░░░░▀█████░▀█████▀░▀█████░██▒▒▒▒██▄░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            */

            Action line =()=>Console.WriteLine(); 
            //1 - how many Songs start with the letter 'a' (case insensitive)
            //int StartsWithA=Songs.Where(song=>song.Name.StartsWith("a")).Count();
            int StartsWithA2=Songs.Count(song=>song.Name.ToLower().StartsWith("a"));
            Console.WriteLine($"{StartsWithA2} songs start with the letter a");
            line();

            //2 - how many artists end with letter 'a' (case insensitive)
            int ArtistEndWithA=Artists.Count(artist=>artist.FullName.ToLower().EndsWith("a"));
            Console.WriteLine($"{ArtistEndWithA} artist end with the letter a");
            line();

            //3 - whats the name of the song with longest duration
            //int SongWithLongestDuration=Songs.Max(song=>song.Duration);
            var SongNameLongestDuration=Songs.Where(songD=>songD.Duration==Songs.Max(song=>song.Duration))
                .Select(nameSong=>nameSong.Name)
                .FirstOrDefault(); // if there are more songs with the same duration as the max duration it will be shown only the name of the first one
            Console.WriteLine($"The name of the song with longest duration is {SongNameLongestDuration}");
            line();
            
            //4 - whats the total Duration of all Songs
            int totalDuration=Songs.Sum(song=>song.Duration);
            Console.WriteLine($"Total duration of all songs is {totalDuration} s");
            line();

            //5 - how many albums have Songs longer than 300 seconds
            int numOfAlbumsLonger300=Albums.Count(album=>album.Songs.Any(song=>song.Duration>300));
            Console.WriteLine($"There are {numOfAlbumsLonger300} albums with songs longer than 300s " );
            line();

            //6 - print the names of the artists(separated with "--"), that have more than one album of PopRock genre
             var ArtistAlbum = Artists.Join(Albums,
                 ar => ar.Id,
                 a => a.ArtistId,
                (ar, a) => new { Name=ar.FullName, Albums=ar.Albums, Genre=a.Genre });

            var Name=ArtistAlbum.Where(x=>x.Genre==Genre.PopRock)
                .GroupBy(n=>n.Name)
                .Select(a=>new {Name=a.Key, Num=a.Count()})
                .Where(x=>x.Num>1)
                .Select(n=>n.Name);
            Console.WriteLine(string.Join("--",Name));
            line();

            //7 - print the name of the album that has highest Average duration of a song
            var AverageDuration=Albums.Select( s =>new {albumName=s.Name , averageDuration=s.Songs.Average(d=>d.Duration)});
            var maxADuration=AverageDuration.Max(s=>s.averageDuration);
            var NameAlbumHighestAverageDuraion=AverageDuration
                .Where(album=>album.averageDuration==maxADuration)
                .Select(s=>s.albumName);
            Console.WriteLine(string.Join(" ",NameAlbumHighestAverageDuraion) + " album with highest average duration of a songs");
            line();

            //8 - how many characters has the song that has the shortest Duration
            var shortestDuration=Songs.Min(song=>song.Duration);
            var NameOfThesongWithShortestDuration=Songs.Where(song=>song.Duration==shortestDuration)
                .Select(s=>s.Name)
                .FirstOrDefault();
            var Characters=NameOfThesongWithShortestDuration.Replace(" ","").ToList().Count();
            //Console.WriteLine(characters);
            Console.WriteLine($"The song that has the shortest Duration has {Characters} characters ");
            line();

            //9 - print the name and the genre of the album that has most songs
            var SongNum=Albums.Select(album=>new {name=album.Name , genre=album.Genre , songs=album.Songs.Count()});
            var max=SongNum.Max(album=>album.songs);
            var nameAndGenre=SongNum.Where(album=>album.songs==max)
                .Select(n=> new {AlbumName=n.name,AlbumGenre=n.genre});
            
            Console.WriteLine(string.Join(" ",nameAndGenre) + " has most songs");
            line();

            //10 - print the name of the artist that has most songs
            var ArtistAndNumSong=Artists.Join(Albums,
                ar=>ar.Id,
                a=>a.ArtistId , (ar,a)=>new {Name=ar.FullName, numSongs=a.Songs.Count()});
          
            var ArtistSong=ArtistAndNumSong
                .GroupBy(n=>n.Name)
                .Select(s=>new {nameArtis=s.Key , num=s.Sum(k=>k.numSongs)});

            var maxSong=ArtistSong.Max(song=>song.num);
            var ArtistWithMaxSongs=ArtistSong
                .Where(s=>s.num==maxSong)
                .Select(n=>n.nameArtis);
            Console.WriteLine("The name of the artist that has the most songs is"+ string.Join(" ",ArtistWithMaxSongs));
            line();

            //11 - print the type of the artist(SoloArtist/Band) that has most albums published before year 2000

            //all artists with number of their albums published before 2000
            var  albumsAndYears=Albums.Where(album=>album.Year<2000)
                .GroupBy(a=>a.ArtistId)
                .Select(artist=>new{artistId=artist.Key,albumbs=artist.Count()});
            //one album and artist id whit max albums published before 2000
            var m=albumsAndYears.Max(a=>a.albumbs);
            var id=albumsAndYears.Where(a=>a.albumbs==m);
            //type of the artist
            var artistType=Artists.Join(id,
                a=>a.Id,
                i=>i.artistId,
                (a,i)=>new {type=a.ArtistType});
            
           Console.WriteLine("The type of the artist that has most albums published before 2000 y is " + string.Join(" ",artistType));
            line();

            //12 - print the average song duration, of the album that has most songs
            var SongAndAlbum=Albums.Select(album=>new {name=album.Name , averageD=album.Songs.Average(s=>s.Duration) , songs=album.Songs.Count()});
            var maxSongs=SongAndAlbum.Max(album=>album.songs);
            var averageSongDurationMostSongs=SongAndAlbum.Where(album=>album.songs==maxSongs)
                .Select(songs=>songs.averageD)
                .FirstOrDefault();
            Console.WriteLine($"The average song duration of the album that has most songs is {averageSongDurationMostSongs}");
            line();

            // Bonus:
            //13 - print the longest song duration of the album that has least songs
            var albumLeast=Albums.Select(s=>new {name=s.Name,songs=s.Songs.Count() , id=s.Id});
            var minSongInAlbum=albumLeast.Min(s=>s.songs);
            
            var albumWithLeast=albumLeast.Where(s=>s.songs==minSongInAlbum);
            // min broj na pesni vo album e 8 no ima 2 albumi so po 8 pesni
            // kako rezultat najdolga pesna vo odnos na dvata albumi so najmal broj pesni
            var songFromAlbum=albumWithLeast.Join(Songs ,
                a=>a.id,
                s=>s.AlbumId,
                (a,s)=>new{songName=s.Name, duration=s.Duration}
                );
            var songDuration=songFromAlbum.Max(s=>s.duration);
            var LongestSongFromAlbumWithLeastSongs=songFromAlbum.Where(s=>s.duration==songDuration)
                .Select(s=>s.songName);
            Console.WriteLine("The longest song of the album with least songs is " + string.Join(" ",LongestSongFromAlbumWithLeastSongs));
            line();
          
            //14 - print the name of the album that has most songs that contain letter 'a' in the name
            var songsAndLetterA=Songs.Select(s=>new {SongName=s.Name,albumId=s.AlbumId});
            var numOfA=songsAndLetterA.Select(s=>new {vk=s.SongName.ToLower().ToCharArray().Count(a=>a.Equals('a')), albumId=s.albumId})
                .Where(A=>A.vk>0)
                .GroupBy(a=>a.albumId)
                .Select(S=>new{idA=S.Key, songs=S.Count()});
            var mostWithA=numOfA.Max(a=>a.songs);
            var albumName=numOfA.Where(a=>a.songs==mostWithA).Join(Albums,
                a=>a.idA,
                al=>al.Id,
                (a,al)=>new{nameAlbum=al.Name});
               // .Select(s=>new{albumId=s.Key,songsD=s.Count(a=>a.vk)});
           // Console.WriteLine(string.Join(" ",numOfA));
            Console.WriteLine("The name of the album that has most songs that contain letter a is " + string.Join(" ",albumName));
            line();
            //15 - print the name of the artist that has most songs that end with letter 'd'
              
              //artist id and number of songs that the artist has which ends with d 
              var songsLetterD=Songs.Where(song=>song.Name.ToLower().EndsWith("d"))
                .GroupBy(s=>s.AlbumId)
                .Select(a=>new {albumId=a.Key,songsD=a.Count()});
              var MaxsongD=songsLetterD.Max(s=>s.songsD);
           
            var albumId=songsLetterD.Where(s=>s.songsD==MaxsongD).Join(Albums,
                aId=>aId.albumId,
                a=>a.Id,
                (aId,a)=>new{artistId=a.ArtistId}
                ).Join(Artists,
                art=>art.artistId,
                a=>a.Id,
                (art,a)=>new{artistName=a.FullName}
                );
            Console.WriteLine("The name of the artist that has most songs that end with letter d is " + string.Join(" ",albumId));

            Console.ReadLine();


        }

        #region Data Initialization
        private static void Init()
        {
            InitArtists();
            InitAlbums();
            InitSongs();
            FillAlbums();
            FillArtists();
        }
        private static void FillAlbums()
        {
            foreach (var album in Albums)
            {
                album.Songs = Songs.Where(x => x.AlbumId == album.Id).ToList();
            }
        }
        private static void FillArtists()
        {
            foreach (var artist in Artists)
            {
                artist.Albums = Albums.Where(album => album.ArtistId == artist.Id).ToList();
            }
        }
        private static void InitArtists()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist(1, "Metallica", ArtistType.Band));
            Artists.Add(new Artist(2, "Iron Maiden", ArtistType.Band));
            Artists.Add(new Artist(3, "Rammstein", ArtistType.Band));
            Artists.Add(new Artist(4, "Coldplay", ArtistType.Band));
            Artists.Add(new Artist(5, "Beyonce", ArtistType.SoloArtist));
        }
        private static void InitAlbums()
        {
            Albums = new List<Album>();
            Albums.Add(new Album(1, 1, "Metallica", Genre.PopRock, 1991));
            Albums.Add(new Album(2, 1, "Ride The Lightning", Genre.PopRock, 1984));
            Albums.Add(new Album(3, 2, "Brave New World", Genre.PopRock, 2000));
            Albums.Add(new Album(4, 2, "Seventh Son of a Seventh Son", Genre.PopRock, 1988));
            Albums.Add(new Album(5, 3, "MUTTER", Genre.PopRock, 2001));
            Albums.Add(new Album(6, 3, "RosenRot", Genre.PopRock, 2005));
            Albums.Add(new Album(7, 4, "Mylo Xyloto", Genre.PopRock, 2011));
            Albums.Add(new Album(8, 5, "Lemonade", Genre.RnB, 2016));
        }
        private static void InitSongs()
        {
            Songs = new List<Song>();

            #region Metallica - Metallica
            Songs.Add(new Song(1, 1, "Enter Sandman", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "Sad But True", 5 * 60 + 24));
            Songs.Add(new Song(3, 1, "Holier Than Thou", 3 * 60 + 47));
            Songs.Add(new Song(4, 1, "The Unforgiven", 6 * 60 + 27));
            Songs.Add(new Song(5, 1, "Wherever I May Roam", 6 * 60 + 44));
            Songs.Add(new Song(6, 1, "Don't Tread on Me", 4 * 60 + 0));
            Songs.Add(new Song(7, 1, "Through the Never", 4 * 60 + 4));
            Songs.Add(new Song(8, 1, "Nothing Else Matters", 6 * 60 + 28));
            Songs.Add(new Song(9, 1, "Of Wolf and Man", 4 * 60 + 16));
            Songs.Add(new Song(10, 1, "The God That Failed", 5 * 60 + 8));
            Songs.Add(new Song(11, 1, "My Friend of Misery", 6 * 60 + 49));
            Songs.Add(new Song(12, 1, "The Struggle Within", 3 * 60 + 53));
            #endregion

            #region Metallica - ride-the-lightning
            Songs.Add(new Song(13, 2, "Fight Fire with Fire", 4 * 60 + 44));
            Songs.Add(new Song(14, 2, "Ride the Lightning", 6 * 60 + 36));
            Songs.Add(new Song(15, 2, "For Whom the Bell Tolls", 5 * 60 + 9));
            Songs.Add(new Song(16, 2, "Fade to Black", 6 * 60 + 57));
            Songs.Add(new Song(17, 2, "Trapped Under Ice", 4 * 60 + 4));
            Songs.Add(new Song(18, 2, "Escape", 4 * 60 + 23));
            Songs.Add(new Song(19, 2, "Creeping Death", 6 * 60 + 36));
            Songs.Add(new Song(20, 2, "The Call of Ktulu", 8 * 60 + 53));
            #endregion

            #region Iron Maiden - Brave New World
            Songs.Add(new Song(21, 3, "The Wicker Man", 4 * 60 + 35));
            Songs.Add(new Song(22, 3, "Ghost of the Navigator", 6 * 60 + 50));
            Songs.Add(new Song(23, 3, "Brave New World", 6 * 60 + 18));
            Songs.Add(new Song(24, 3, "Blood Brothers", 7 * 60 + 14));
            Songs.Add(new Song(25, 3, "The Mercenary", 4 * 60 + 42));
            Songs.Add(new Song(26, 3, "Dream of Mirrors", 9 * 60 + 21));
            Songs.Add(new Song(27, 3, "The Fallen Angel", 4 * 60 + 0));
            Songs.Add(new Song(28, 3, "The Nomad", 9 * 60 + 5));
            Songs.Add(new Song(29, 3, "Out of the Silent Planet", 6 * 60 + 25));
            Songs.Add(new Song(30, 3, "The Thin Line Between Love and Hate", 8 * 60 + 27));

            #endregion

            #region Iron Maiden - Seventh Son of a Seventh Son
            Songs.Add(new Song(31, 4, "Moonchild", 5 * 60 + 41));
            Songs.Add(new Song(32, 4, "Infinite Dreams", 6 * 60 + 9));
            Songs.Add(new Song(33, 4, "Can I Play with Madness", 3 * 60 + 31));
            Songs.Add(new Song(34, 4, "The Evil That Men Do", 4 * 60 + 34));
            Songs.Add(new Song(35, 4, "Seventh Son of a Seventh Son", 9 * 60 + 53));
            Songs.Add(new Song(36, 4, "The Prophecy", 5 * 60 + 6));
            Songs.Add(new Song(37, 4, "The Clairvoyant", 4 * 60 + 27));
            Songs.Add(new Song(38, 4, "Only the Good Die Young", 4 * 60 + 42));
            #endregion

            #region Rammstein - MUTTER
            Songs.Add(new Song(39, 5, "Mein Herz Brennt", 4 * 60 + 39));
            Songs.Add(new Song(40, 5, "Mein Herz Brennt", 3 * 60 + 36));
            Songs.Add(new Song(41, 5, "Sonne", 4 * 60 + 32));
            Songs.Add(new Song(42, 5, "Ich Will", 3 * 60 + 37));
            Songs.Add(new Song(43, 5, "Feuer Frei!", 3 * 60 + 11));
            Songs.Add(new Song(44, 5, "Mutter", 4 * 60 + 32));
            Songs.Add(new Song(45, 5, "Spieluhr", 4 * 60 + 46));
            Songs.Add(new Song(46, 5, "Zwitter", 4 * 60 + 17));
            Songs.Add(new Song(47, 5, "Rein Raus", 3 * 60 + 9));
            Songs.Add(new Song(48, 5, "Adios", 3 * 60 + 49));
            Songs.Add(new Song(49, 5, "Nebel", 4 * 60 + 54));
            #endregion

            #region Rammstein - Rosenrot
            Songs.Add(new Song(50, 6, "Benzin", 3 * 60 + 46));
            Songs.Add(new Song(51, 6, "Mann Gegen Mann", 3 * 60 + 50));
            Songs.Add(new Song(52, 6, "Rosenrot", 3 * 60 + 54));
            Songs.Add(new Song(53, 6, "Spring", 5 * 60 + 24));
            Songs.Add(new Song(54, 6, "Wo Bist Du", 3 * 60 + 55));
            Songs.Add(new Song(55, 6, "Stirb Nicht Vor Mir(Don't Die Before I Do)", 4 * 60 + 5));
            Songs.Add(new Song(56, 6, "Zerstören", 5 * 60 + 28));
            Songs.Add(new Song(57, 6, "Hilf Mir", 4 * 60 + 43));
            Songs.Add(new Song(58, 6, "Te Quiero Puta!", 3 * 60 + 55));
            Songs.Add(new Song(59, 6, "Feuer und Wasser", 5 * 60 + 17));
            Songs.Add(new Song(60, 6, "Ein Lied", 3 * 60 + 43));
            #endregion

            #region Coldplay - Mylo Xyloto
            Songs.Add(new Song(61, 7, "Mylo Xyloto", 0 * 60 + 43));
            Songs.Add(new Song(62, 7, "Hurts Like Heaven", 4 * 60 + 2));
            Songs.Add(new Song(63, 7, "Paradise", 4 * 60 + 37));
            Songs.Add(new Song(64, 7, "Charlie Brown", 4 * 60 + 45));
            Songs.Add(new Song(65, 7, "Us Against the World", 3 * 60 + 59));
            Songs.Add(new Song(66, 7, "M.M.I.X.", 0 * 60 + 48));
            Songs.Add(new Song(67, 7, "Every Teardrop Is a Waterfall", 4 * 60 + 0));
            Songs.Add(new Song(68, 7, "Major Minus", 3 * 60 + 30));
            Songs.Add(new Song(69, 7, "U.F.O.", 2 * 60 + 17));
            Songs.Add(new Song(70, 7, "Princess of China", 3 * 60 + 59));
            Songs.Add(new Song(71, 7, "Up in Flames", 3 * 60 + 13));
            Songs.Add(new Song(72, 7, "A Hopeful Transmission", 0 * 60 + 33));
            Songs.Add(new Song(73, 7, "Don't Let It Break Your Heart", 3 * 60 + 53));
            Songs.Add(new Song(74, 7, "Up with the Birds", 3 * 60 + 47));
            #endregion

            #region Beyonce - Lemonade
            Songs.Add(new Song(75, 8, "", 3 * 60 + 15));
            Songs.Add(new Song(76, 8, "", 3 * 60 + 41));
            Songs.Add(new Song(77, 8, "", 3 * 60 + 53));
            Songs.Add(new Song(78, 8, "", 3 * 60 + 52));
            Songs.Add(new Song(79, 8, "", 4 * 60 + 20));
            Songs.Add(new Song(80, 8, "", 4 * 60 + 47));
            Songs.Add(new Song(81, 8, "", 3 * 60 + 57));
            Songs.Add(new Song(82, 8, "", 3 * 60 + 2));
            Songs.Add(new Song(83, 8, "", 1 * 60 + 19));
            Songs.Add(new Song(84, 8, "", 4 * 60 + 49));
            Songs.Add(new Song(85, 8, "", 5 * 60 + 21));
            Songs.Add(new Song(86, 8, "", 3 * 60 + 25));

            #endregion

        }
        #endregion

    }
}

