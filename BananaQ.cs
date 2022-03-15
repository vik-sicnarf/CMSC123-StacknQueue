namespace StacknQueue
{
    public class BananaQ<T>
    {
        private Node<T>? front;
        private Node<T>? rear;

        public BananaQ() {
            front = rear = null;
        }

        public void Enqueue(T data)
        {
            //implement adding to queue
            Node<T>? newElement = new Node<T>(data);

            if(rear == null) { //For empty queue, front and rear are both the new node
                front = rear = newElement;
            } else { //Adds new node to the end of the queue, changing the rear node
                rear.Next = newElement;
                rear = newElement;
            }
            Console.WriteLine("Element to be added: " +data); //For testing the method
        }

        public T? Dequeue()
        {
            // implement removing from a queue
            
            if(front == null){ //For empty queue, method will throw exception
                throw new NullReferenceException("The queue is empty");
            }

            //Store the front to a temporary node and moves front one node ahead
            T? data = front.Data;
            front = front.Next;

            if(front == null){ //In case of all node being dequeued, set rear to null
                rear = null;
            }

            Console.WriteLine(data + " has been deleted from the queue"); //For testing the method
            return data;
        }

        public void printMyQueue()
        {
            Node<T>? current = front;
            
            while(current != null) {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}