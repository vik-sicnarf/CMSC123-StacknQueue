namespace StacknQueue
{
    public class Stak<T>
    {
        private Node<T>? top;
        public Stak(){
            top = null;
        }
        public void Push(T data)
        {
            // implement adding to the stack
            //Allocate Memory for new node 
            //Add the data 
            Console.WriteLine("Element to be added: "+data); //FOR TESTING TO SEE IF ELEMENT TO BE ADDED IS RIGHT 

            Node<T>? TopNow = top; //defines a temp variable that is the Current Top of the stack  
            top = new Node<T>(data){Next = TopNow}; 
            // declares the new node as the top and Sets Next as the node that was previously at the top of the stack
           


        }

        public void /*T*/ Pop() //void return type for now. change to T when done implementing 
        {
            // implement deleting from the stack
            //return null;
        }

        public void /*T*/ Peek() //void return type for now. change to T when done implementing 
        {
            //implement peeking from the top of the stack
            //return null;
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