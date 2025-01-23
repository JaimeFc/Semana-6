namespace FuncionCalculo
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; } // Permitir valores null

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class FuncionCalculo
    {
        private Node? head; // Permitir valores null

        public FuncionCalculo()
        {
            head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null) head = newNode;
            else
            {
                Node current = head;
                while (current.Next != null) current = current.Next;
                current.Next = newNode;
            }
        }

        public int Count()
        {
            int count = 0;
            Node? current = head; // Usar nullable aquí también
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}
