using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinked
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public ulong Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Count = 0;
        }
        public bool Empty
        {
            get { return Head == null; }
        }

        public void AddFirst(string value) //Adds a new node witht he given value to the BEGINNING of the list
        {
            //Create new node
            Node newNode = new Node();

            //Set Value new node
            newNode.Value = value;


            if (this.Empty)
            {
                this.Head = newNode;
            }
            else 
            { 
                //Get the node at head
                Node head = this.Head;

                //Set the next of new node to node at head
                newNode.Next = head;

                //Set the head to the new node
                this.Head = newNode; 
            }

            this.Count++;
        }

        public void AddLast(string value) //Adds a new node with the given value to the END of list
        {
            Node newNode = new Node();

            newNode.Value = value;

            newNode.Next = null;

            if (this.Empty)
            {
                this.Head = newNode;
            }
            else
            {
                Node currentNode = this.Head;

                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }

            Count++;
         
        }
        public void RemoveFirst() //Removes the first node in the list
        {
            if (this.Head == null)
            {
                return;
            }
            this.Head = this.Head.Next;
            this.Count--;
        }

        public void RemoveLast() //Removes the last node in the list
        {
            Node current = this.Head;

            if (this.Head == null)
            {
                return;
            }
            if (this.Head.Next == null)
            {
                this.Head = null;
                this.Count= 0;
                return;
            }
            while(current.Next.Next != null)
            {
                current= current.Next;
            }
            current.Next = null;
            this.Count--;
        }

        public string GetValue(ulong index) //Retrieves the value of the node at the given index
        {
            if (index < 0)//out of range exception if index is "-"
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }
            if (this.Empty)//if empty return null
            {
                return null;
            }
            if (index >= this.Count)
            {
                index = this.Count - 1;
            }
            
            Node currentNode = this.Head;
            ulong counter = 1;
            while (counter < index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode.Value;
            //while (index > 0 && current != null)
            //{
            //    current = current.Next;
            //    index--;
            //}
            //return current.Value;

        }

        public void Clear()
        {
            this.Head = null;
            this.Count= 0;
        }
    }
}

