namespace DataStructureAndAlgorithms.DataStructures.Stack;

public class Stack
{
    private class StackNode
    {
        public int val;
        public StackNode? next;

        public StackNode(int val)
        {
            this.val = val;
            next = null;
        }
    }
    private StackNode? _top;
    private int _count;

    public void Push(int val)
    {
        var newNode = new StackNode(val);
        newNode.next = _top;
        _top = newNode;
        _count++;
    }
    public int Count => _count;
    // prop global

    public int Pop()
    {
        if (_top == null)
            throw new InvalidOperationException("Stack underflow");
        var node = _top.val;
        _top = _top.next;
        _count--;
        return node;
    }
}