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
            
            Node<T> MyPush = new Node<T>(data); 
            top.Data = data; 
            top = top.Next; 
            


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