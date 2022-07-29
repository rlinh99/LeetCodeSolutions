/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */

public class LRUCache
{
    Dictionary<int, LinkedListNode<(int, int)>> _dict;
    LinkedList<(int, int)> _list;
    int _capacity;

    public LRUCache(int capacity)
    {
        _dict = new();
        _list = new();
        _capacity = capacity;
    }

    public int Get(int key)
    {
        if (!_dict.ContainsKey(key))
            return -1;
        var result = _dict[key];
        _list.Remove(result);
        _list.AddFirst(result);
        return result.Value.Item2;
    }

    public void Put(int key, int value)
    {
        var toAdd = new LinkedListNode<(int, int)>((key, value));
        if (!_dict.ContainsKey(key))
        {
            if (_dict.Count == _capacity)
            {
                var toRemove = _list.Last;
                _dict.Remove(toRemove.Value.Item1);
                _list.Remove(toRemove);
                _list.AddFirst(toAdd);
                _dict.Add(key, toAdd);
            }
            else
            {
                _dict.Add(key, toAdd);
                _list.AddFirst(toAdd);
            }
        }
        else
        {
            var toModify = _dict[key];
            _list.Remove(toModify);
            _list.AddFirst(toAdd);
            _dict[key] = toAdd;
        }
    }
}
