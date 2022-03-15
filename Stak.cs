namespace StacknQueue
{
    public class Stak<T>
    {
        private Node<T>? top;
        public Stak(){
            top = null;
        }
        public void Push(T data) //Pushing to the stack
        {
            Console.WriteLine("Element to be added: "+data); //FOR TESTING TO SEE IF ELEMENT TO BE ADDED IS RIGHT 

            Node<T>? TopNow = top; //defines a temp variable node that is the Current Top of the stack  

            // declares the new node as the top and Sets Next as the node that was previously at the top of the stack
            top = new Node<T>(data)
            {
                Next = TopNow    
            }; 
            

        }

        public T Pop() //Removing element from the top of the stack
        {
            //Exception handling for pop when the stack is empty
            try {
                T data = top.Data; 
                top = top.Next;
                return data;
            }catch(NullReferenceException e){ //Catches the exception when the stack is empty and returns null
                Console.WriteLine("The stack is empty");
                return default(T); //returns null
            }
                
    
            
        }

        public T Peek() //Peeking from the top of the stack
        {
            //Exception handling for peeking when the stack is empty
            try{ //Returns the top element since the stack is not empty 
                Console.WriteLine("Peeking the stack the element at top is: " + top.Data);
                return top.Data; 
            }catch(NullReferenceException e){ //Catches the exception when the stack is empty and returns null
                Console.WriteLine("Peeking the stack the element at top is empty");
                return default(T); //returns null
            }
        }

        
        public void printMystack(){ //METHOD TO PRINT THE STACK (FOR TESTING PURPOSES) TO BE TESTED IF THIS WORKS 
            Node<T>? current = top; 
            while(current != null){
                    
                    Console.WriteLine(current.Data);
                    current = current.Next;
            }
        }
      
    }
    
}