namespace StacknQueue
{
    public class BananaQ<T>
    {
        private Node<T>? front; //Node for the front
        private Node<T>? rear; //Node for the rear 

        public BananaQ() {
            front = rear = null;
        }

        public void Enqueue(T data) //Method for adding to queue
        {
            Node<T>? newElement = new Node<T>(data);

            if(rear == null) {      //For empty queue, front and rear are both the new node
                front = rear = newElement;
            } else { //Adds new node to the end of the queue, changing the rear node
                rear.Next = newElement;
                rear = newElement;
            }
            
            Console.WriteLine("Element to be added: " +data); //For testing the method
        }

        public T? Dequeue() //Method to remove from the queue 
        {
            if(front == null){ //For empty queue, method will throw exception
                throw new NullReferenceException("Queue is empty");
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

        public void printMyQueue() //Method for printing the queue //For testing
        {
            Node<T>? current = front;
            if (current == null) {
                Console.WriteLine("The queue is empty");
            } else{
                Console.WriteLine("Singly Queue:");
                while(current != null) {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
                //To test that difference to a circular linked list:
                // Console.WriteLine("The front data is: " + front.Data);
                // Console.WriteLine("The data next to rear is: " + rear.Next.Data);
            }
            
            
        }
    }
}