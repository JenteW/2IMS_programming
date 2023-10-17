using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class FindKey
    {
        public int Count { get; set; }
        public string Algorithm1(string folder)
        {
           Queue<string> folders = new Queue<string>();
           folders.Enqueue(folder); //enqueue is vanachter toevoegen
            while (folders.Count > 0)
            { 
                Count++;
                folder = folders.Dequeue(); // dequeue is vanvoor verwijderen
                if(Directory.GetFiles(folder).Length > 0) return folder;
                else
                {
                    foreach( string dir in Directory.GetDirectories(folder))
                    {
                        folders.Enqueue(dir);
                    }
                                    
                }

            }
            return "not found";
        }
        public string Algorithm2(string folder)
        {
            foreach(string entry in Directory.GetFileSystemEntries(folder))
            { Count++;
                if(Directory.Exists(entry))
                {
                    string returnvalue = Algorithm2(entry); // recursie, ik roep mezelf terug op
                    if(returnvalue != "not found") return returnvalue;
                }
               else if(File.Exists(entry)){

                    return entry;
                }
            }
            return "not found";
        }
    }
}
