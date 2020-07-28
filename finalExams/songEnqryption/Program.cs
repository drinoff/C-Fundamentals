using System;
using System.Text;
using System.Text.RegularExpressions;

namespace songEnqryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"^(?<name>[A-Z] ?[a-z]+ ?[a-z]+'? ?[a-z]+'? ?[a-z]+ ?)$";
            var songPattern = @"^(?<song>[A-Z ]+)$";
            StringBuilder sb = new StringBuilder();
            while (input != "end")
            {
                var info = input.Split(":");
                var artist = info[0];
                var song = info[1];
                var validMatch = Regex.Match(artist, pattern);
                var validArtist = validMatch.Groups["name"].Value.ToCharArray();
                var validSongMatch = Regex.Match(song, songPattern);
                var validSong = validSongMatch.Groups["song"].Value.ToCharArray();
                if (validArtist.Length != 0 && validSong.Length != 0)
                {

                    var key = validArtist.Length;
                    var firstLetter = validArtist[0];
                    if (firstLetter + key > 90)
                    {
                        var enqryptedFirstLetter = key - (90 - firstLetter) + 64;
                        sb.Append((char)enqryptedFirstLetter);
                    }
                    else
                    {
                        sb.Append((char)(firstLetter + key));
                    }
                    for (int i = 1; i < validArtist.Length; i++)
                    {
                        if (validArtist[i] != ' ' && validArtist[i] != '\'')
                        {
                            var encrypted = validArtist[i] + key;
                            if (encrypted > 122)
                            {
                                encrypted = key - (122 - validArtist[i]) + 96;
                            }
                            sb.Append((char)encrypted);
                        }
                        else
                        {
                            if (validArtist[i] == ' ')
                            {
                                sb.Append(" ");
                            }
                            else
                            {
                                sb.Append("'");
                            }
                        }
                    }
                    sb.Append("@");

                    for (int i = 0; i < validSong.Length; i++)
                    {
                        if (validSong[i] != ' ' && validSong[i] != '\'')
                        {
                            var encrypted = validSong[i] + key;
                            if (encrypted > 90)
                            {
                                encrypted = key - (90 - validSong[i]) + 64;
                            }
                            sb.Append((char)encrypted);
                        }
                        else
                        {
                            if (validSong[i] == ' ')
                            {
                                sb.Append(" ");
                            }
                            else
                            {
                                sb.Append("'");
                            }
                        }

                    }
                }
                if (validMatch.Length == 0 || validSongMatch.Length == 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine($"Successful encryption: {sb.ToString()}");
                }
                input = Console.ReadLine();
                sb.Clear();
            }
        }
    }
}
