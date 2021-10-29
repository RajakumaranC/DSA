namespace Algorithms
{
    #nullable enable
    
    public class DoubleLinkedList
    {
        public DoubleLinkedListNode? head;
        public DoubleLinkedListNode? tail;

        public void SetHead(DoubleLinkedListNode node)
        {
            if(node == head)
                return;

            if(head == null)
            {
                head = node;
                tail = node;
            }

            if(head == tail)
            {
                tail.prev = node;
                head = node;
                head.next = tail;
                return;
            }
            if(tail == node)
            {
                RemoveTail();
            }
            node.RemoveBindings();
            node.next = head;
            head.prev = node;
            head = node;

        }

        public void RemoveTail()
        {
            if(tail == null)
                return;
            
            if(tail == head)
            {
                head = null;
                tail = null;
            }

            tail = tail?.prev;
            tail.next = null;

        }


    }
}