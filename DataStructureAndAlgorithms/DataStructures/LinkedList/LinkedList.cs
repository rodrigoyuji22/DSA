namespace DataStructureAndAlgorithms.DataStructures;

public class DoublyLinkedList
{
    private class ListNode
    {
        public readonly int Value;
        public ListNode? Next;
        public ListNode? Prev;

        public ListNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
    private ListNode? _head;
    private ListNode? _tail;

    public void BeginInsert(int value)
    {
        var newNode = new ListNode(value);
        if (_head == null)
            _head = _tail = newNode;
        else
        {
            _head.Prev =  newNode;
            newNode.Next = _head;
            _head = newNode;
        }
    }
    public void EndInsert(int value)
    {
        var newNode = new ListNode(value);
        if (_tail == null)
            _tail = _head = newNode;
        else
        {
            _tail.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;
        }
    }

    public void BeginRemove()
    {
        if (_head == null)
            return;
        _head = _head.Next;
        if (_head != null)
            _head.Prev = null;
        else
        {
            _tail = null;
        }
    }

    public void EndRemove()
    {
        if(_tail == null)
            return;
        _tail = _tail.Prev;
        if (_tail != null)
            _tail.Next = null;
        else
        {
            _head = null;
        }
    }

    public void PrintList()
    {
        var curr = _head;
        var values = new List<int>();
        if(curr == null)
            return;
        while (curr!= null)
        {
            values.Add(curr.Value);
            curr = curr.Next;
        }

        Console.WriteLine("[" + string.Join(", ", values) + "]");
    }
}    