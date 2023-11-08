using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {
        public Playlist Player(string songs, string commands, string start)
        {
            Playlist playlist = new Playlist();
            string text = "";
            bool exist = false;
            string[] songsArray = songs.Split(' ');
            foreach (string song in songsArray)
            {
                playlist.Add(song);
                if (song == start)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                playlist.SetNode(start);
                text += $"{playlist.GetCurrent()} ";

            }
            else
            {
                Console.Write($"Not found ");

            }
            string[] commandsArray = commands.Split(' ');
            foreach (string command in commandsArray)
            {
                if (command == "next")
                {
                    playlist.Next();
                    text += $"{playlist.GetCurrent()} ";

                }
                else if (command == "previous")
                {
                    playlist.Previous();
                    text += $"{playlist.GetCurrent()} ";

                }
                else if (command.StartsWith("add"))
                {
                    string[] addArray = command.Split(':');
                    if (addArray[1] == "")
                    {
                        Console.WriteLine("Crazy input!");
                        return null;
                    }
                    playlist.Add(addArray[1], songsArray[0], playlist.GetCurrent());
                    
                }
                else if (command.StartsWith("remove"))
                {
                    string[] removeArray = command.Split(':');
                    if (removeArray[1] == "")
                    {
                        Console.WriteLine("Crazy input!");
                        return null;

                    }
                    playlist.Remove(removeArray[1]);
                }
            }
            text = text.Trim();
            Console.WriteLine(text);
            return playlist;
        }




    }
}
