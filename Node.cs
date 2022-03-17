namespace StacknQueue
{
    
    //Node class for the program 
    public class Node<T>
    {
        public Node<T>? Next { get; set; } //The question mark means it is nullable.
        
        public T? Data { get; set; }  //Question mark makes the variable nullable 

        public Node (T data)
        {
            this.Data = data;
        }
        
    }

   
}