namespace AlgsExam;

public class LinkedList<T>
{
    class Node<T>
    {
        public Node(T data)
        {
            this.data = data;
        }

        public T data;

        public Node<T> prev;
        public Node<T> next;
    }

    private Node<T> head;
    private Node<T> tail;
    private int size;
    
    
}