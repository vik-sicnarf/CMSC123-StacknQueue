namespace StacknQueue
{
    public class Stak<T>
    {
        private Node<T>? top;
        public Stak(){
            top = null;
        }
        public async void Push(T data)
        {
            // implement adding to the stack
            //Allocate Memory for new node 
            //Add the data 
            
            Node<T> MyPush = new Node<T>(data); 
            


        }

        public T Pop()
        {
            // implement deleting from the stack
            //return null;
        }

        public T Peek()
        {
            //implement peeking from the top of the stack
            //return null;
        }
    }
}