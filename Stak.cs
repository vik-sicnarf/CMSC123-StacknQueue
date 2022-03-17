namespace StacknQueue
{
    public class Stak<T>
    {
        private Node<T>? top; //Node for the top
        public Stak(){
            top = null;
        }
        public void Push(T data) //Pushing to the stack
        {
            Console.WriteLine("Element to be added: "+data); //For testing

            Node<T>? TopNow = top; //Defines a temp variable node that is the Current Top of the stack  

            // Declares the new node as the top and Sets Next as the node that was previously at the top of the stack
            top = new Node<T>(data)
            {
                Next = TopNow    
            }; 
        }

        public T? Pop() //Removing element from the top of the stack
        {
            //Checks if the stack is empty before popping 
            if (top != null){
                T? data = top.Data; 
                top = top.Next;
                Console.WriteLine("Element popped from stack: "+ data);
                return data;
            }else{
                Console.WriteLine("The stack is empty");
                return default(T); //returns null
            }
        }

        public T? Peek() //Peeking from the top of the stack
        {
            //Checks if the stack is empty before peeking 
            if(top != null){
                Console.WriteLine("Peeking the stack the element at the top is: " + top.Data);
                return top.Data; 
            }else{
                Console.WriteLine("Peeking the stack the element at top is empty");
                return default(T); //returns null if stack is empty
            }
        }

        
        public void printMystack(){ //Method to print the stack //For testing purposes
            Node<T>? current = top; 
            while(current != null){
                    Console.WriteLine(current.Data);
                    current = current.Next;
            }
        }
      
    }
    
}