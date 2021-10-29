namespace Algorithms
{
    public class DoubleLinkedListNode
    {
        public int value;
        public string key;
        public DoubleLinkedListNode next;
        public DoubleLinkedListNode prev;

        public DoubleLinkedListNode(int value, string key)
        {
            this.value = value;
            this.key = key;
        }

        public void RemoveBindings()
        {
            if(prev != null)
            {
                prev.next = next;
            }
            if(next != null)
            {
                next.prev = prev;
            }
            next = null;
            prev = null;
        }
    }
}