namespace StacknQueue
{
    public class BananaQnaBilog<T>
    {
        private Node<T>? front; //Node for the front
        private Node<T>? rear; //Node for the rear 

        public BananaQnaBilog() {
            front = rear = null;
        }

        public void Enqueue(T data) //Method for adding to queue
        {   
            // Create a new node and insert data into it
            Node<T>? newElement = new Node<T>(data);
            newElement.Data = data;

            // For empty queue, front is the new node
            if (front == null){
                front = newElement;
            } else { //Adds new node to the end of the queue, changing the rear node
                rear.Next = newElement;
            }
            
            rear = newElement;
            rear.Next = front; //Rear node has an address to the front
            
            Console.WriteLine("Element to be added: " +data); //For testing the method
        }

        public T? Dequeue() //Method to remove from the queue 
        {
            //For empty queue, print a message
            if(front == null) {
                throw new NullReferenceException("Queue is empty");
            }


            T? data;
            if (front == rear) { //If front = rear, set both front and rear to null
                data = front.Data;
                front = null;
                rear = null;
            } else { //If not, move the front to the next node
                Node<T>? temp = front;
                data = temp.Data;
                front = front.Next;
                rear.Next = front; //Update the rear node to the new front
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
                Console.WriteLine("Circular Queue: ");
                while(current.Next != front){
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
                Console.WriteLine(current.Data);
                Console.WriteLine("The front data is: " + front.Data);
                Console.WriteLine("The data next to rear is: " + rear.Next.Data);
            }
            
        }
    }
}