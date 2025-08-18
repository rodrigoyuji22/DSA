namespace DataStructureAndAlgorithms.DataStructures.Stack;

public class LeetCode155
{
    public class MinStack {

        public MinStack() {
        }

        public class StackNode{
            public int val;
            public StackNode next;
            public int minHere;

            public StackNode(int val, int minHere){
                this.val = val;
                this.minHere = minHere;
                next = null;
            }
        }
        public StackNode _top;

        public void Push(int val) {
            StackNode newNode;
            if(_top == null)
                newNode = new StackNode(val, val);
            else
                newNode = new StackNode(val, Math.Min(val, _top.minHere));
            newNode.next = _top;
            _top = newNode;
        }
    
        public void Pop() {
            if(_top != null)
                _top = _top.next;
            else
                throw new InvalidOperationException("error");
        }
    
        public int Top() {
            if(_top != null)
                return _top.val;
            else
                throw new InvalidOperationException("error");

        }
    
        public int GetMin() {
            if(_top != null)
                return _top.minHere;
            else
                throw new InvalidOperationException("error");

        }
    }
}