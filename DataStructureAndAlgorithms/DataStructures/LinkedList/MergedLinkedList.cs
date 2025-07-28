namespace DataStructureAndAlgorithms.DataStructures;

public class MergedLinkedList
{
    public class MergedSinglyLinkedList
    {
        //ex do leetcode 876
        public class ListNode
        {
            public int val;
            public ListNode? next;

            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2) {
            var dummy = new ListNode();
            var tail = dummy;
            while(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    tail.next = list1;  // adiciona no final apos o tail
                    tail = tail.next;  // move o tail para o ultimo node
                    list1 = list1.next;  // itera o elemento da lista
                }
                else
                {
                    tail.next = list2;  // adiciona no final apos o tail
                    tail = tail.next;  // move o tail para o ultimo node
                    list2 = list2.next;  // itera o elemento da lista
                }
            }

            if(list1 != null)
            {
                tail.next = list1;
            }else{
                tail.next = list2;
            }
            return dummy.next;
        }
    }
}