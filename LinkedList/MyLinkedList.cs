namespace LinkedList
{
    internal class MyLinkedList
    {

        // add to beginning of list
        // * add to end of list
        // * there is no list 
        // add to middle
        // sort the list
        private Node _head;
        public Node Add(string payload)
        {
            if (_head == null)
            {
                _head = new Node(payload);
                return _head;
            }
            Node current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(payload);

            return _head;
        }

        public bool Remove(string item)
        {
            bool isRemoved = false;
            if (_head == null)
            {
                return isRemoved;
            }
            Node current = _head;
            while (current != null)
            {
                if (current.Data.ToLower() == item.ToLower())
                {
                    current = current.Next;
                    isRemoved = true;
                    continue;
                }
                current = current.Next;
            }
            return isRemoved;
        }

        public bool Contains(string item)
        {
            bool matchFound = false;
            if (_head == null)
            {
                return matchFound;
            }
            Node current = _head;
            while (current != null)
            {
                if (current.Data.ToLower() == item.ToLower())
                {
                    matchFound = true;
                    break;
                }
                current = current.Next;
            }
            return matchFound;
        }

        public string PrintAllNodes()
        {
            string nodeList = "";
            string[] strings = new string[0];
            Node current = _head;
            while (current != null)
            {
                Array.Resize(ref strings, strings.Length + 1);
                strings[strings.Length - 1] = current.Data;
                current = current.Next;
            }

            Array.Sort(strings);

            foreach (string s in strings)
            {
                nodeList += s + Environment.NewLine;
            }

            return nodeList;
        }

        public void Print()
        {
            if (_head == null)
            {
                Console.WriteLine("empty list! aborting!!!!!!!");
                return;
            }
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

            //Console.WriteLine(current.Data);
        }
    }
}
