namespace LinkedList
{
    internal class MyLinkedList
    {

        // add to beginning of list
        // * add to end of list
        // * there is no list 
        // add to middle
        // sort the list
        private int NodeLength = 0;
        private Node _head;
        public Node Add(string payload)
        {
            if(_head == null)
            {
                _head = new Node(payload);
                NodeLength++;
                return _head;
            }
            Node current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(payload);
            NodeLength++;

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
                    NodeLength--;
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
            string[] strings = new string[NodeLength];
            Node current = _head;
            int index = 0;
            while (current != null)
            {
                strings[index] = current.Data;
                index++;
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
