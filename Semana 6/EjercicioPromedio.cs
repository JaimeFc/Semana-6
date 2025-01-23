namespace EjercicioPromedio
{
    // Clase Nodo
    public class AverageNode
    {
        public int Data { get; set; }
        public AverageNode? Next { get; set; }

        public AverageNode(int data)
        {
            Data = data;
            Next = null;
        }
    }

    // Clase Lista Enlazada
    public class EjercicioPromedio
    {
        private AverageNode? head;

        public EjercicioPromedio()
        {
            head = null;
        }

        public void Add(int data)
        {
            AverageNode newNode = new AverageNode(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                AverageNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            AverageNode? current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public double CalculateAverage()
        {
            if (head == null) return 0;

            int sum = 0;
            int count = 0;
            AverageNode? current = head;

            while (current != null)
            {
                sum += current.Data;
                count++;
                current = current.Next;
            }

            return (double)sum / count;
        }
    }
}

