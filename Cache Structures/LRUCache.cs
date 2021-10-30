namespace Algorithms
{
    public class LRUResult {
		public bool found;
		public int value;

		public LRUResult(bool found, int value) {
			this.found = found;
			this.value = value;
		}
	}
    public class LRUCache {
		public int maxSize;
        public Dictionary<string, DoubleLinkedListNode> store_map;
        public DoubleLinkedList store_list;

		public LRUCache(int maxSize) {
			this.maxSize = maxSize > 1 ? maxSize : 1;
            store_list = new DoubleLinkedList();
            store_map = new Dictionary<string, DoubleLinkedListNode>();
		}

		public void InsertKeyValuePair(string key, int value) {
			
            if(store_map.ContainsKey(key))
            {
                DoubleLinkedListNode current = store_map[key];
                current.value = value;
                UpdateRecentlyUsed(key);
                return;
            }

            DoubleLinkedListNode node = new DoubleLinkedListNode(value, key);
            store_list.SetHead(node);
            store_map.Add(key, node);
            if(store_map.Count > maxSize)
                EvictLeastUsed();
		}

        private void EvictLeastUsed()
        {
            if(store_map.Count <= 0)
                return;
#nullable disable
            string key = store_list.tail.key;
            store_map.Remove(key);
            store_list.RemoveTail();
        }

        private void UpdateRecentlyUsed(string key)
        {
            DoubleLinkedListNode current = store_map[key];
            store_list.SetHead(current);
        }

        public LRUResult GetValueFromKey(string key) {
			
            
            if(store_map.ContainsKey(key))
            {
                int result = store_map[key].value;
                UpdateRecentlyUsed(key);
                return new LRUResult(true, result);
            }
			return new LRUResult(false, -1);
		}

		public string GetMostRecentKey() {
			
            if(store_map.Count > 0)
            {
                string key = store_list.head.key;
                return key;
            }
			return null;
		}
	}
}
