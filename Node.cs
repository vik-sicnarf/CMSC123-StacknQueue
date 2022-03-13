namespace StacknQueue
{
    
    //Node class for the program 
    public class Node<T>
    {
        // Properties also known as smart fields are the equivalent of a private field in Java with a getter and a setter
        public Node<T>? Next { get; set; } //The question mark means it is nullable. Not sure if this the correct way to do it
        
        public T? Data { get; set; }  //Question mark makes the variable nullable 

        public Node (T data)
        {
            this.Data = data;
            Next = null; //Sets the next node as null 
        }
        
    }

   
}