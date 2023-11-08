using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Module_03.Assignment;

namespace Module_03
{

    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = this;
            Previous = this;
        }
    }


    public class Playlist
    {
        public Node Head { get; set; }
        

        public Playlist()
        {
            Head = null;
        }
        public void SetNode(string song)
        {
            Node current = Head;
            while (current.Data != song && current.Next != Head)
            {
                current = current.Next;
            }

            if (current.Data == song)
            {
                Head = current;
            }
        }
        public bool IsEmpty()
        {
            return Head == null;
        }

        public string Next()
        {
            if (Head == null)
            {
                return "empty";
            }
            // Move to the next song.
            Head = Head.Next;
            return Head.Data;
        }

        public string Previous()
        {
            if (Head == null)
            {
                return "empty";
            }

            // Move to the previous song.
            Head = Head.Previous;
            return Head.Data;
        }
        public void Add(string data)
        {

            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node tail = Head.Previous;
                newNode.Next = Head;
                newNode.Previous = tail;
                tail.Next = newNode;
                Head.Previous = newNode;
            }
        }


        public void Add(string data, string first, string current)
        {
            
            SetNode(first);
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node tail = Head.Previous;
                newNode.Next = Head;
                newNode.Previous = tail;
                tail.Next = newNode;
                Head.Previous = newNode;
            }
            SetNode(current);
        }

        public void Remove(string data)
        {
            if (Head == null)
            {
                return;
            }

            Node current = Head;
            do
            {
                if (current.Data == data)
                {
                    if (current == Head)
                    {
                        if (Head.Next == Head)
                        {
                            Head = null; // Only one node in the list
                        }
                        else
                        {
                            Head = current.Next;
                        }
                    }
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    return;
                }
                current = current.Next;
            } while (current != Head);
        }

        public string GetCurrent()
        {
            return Head != null ? Head.Data : "empty";
        }

        // Set the head to the node with the specified data.
        
    }
}
