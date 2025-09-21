namespace Assignment11._2._2
{
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

    public class Solution
    {
        public ListNode? ReverseList(ListNode? head)
        {
            ListNode? prev = null;
            ListNode? curr = head;

            while (curr != null)
            {
                ListNode? nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }
    }
    internal class Program
    {
        static void PrintList(ListNode? head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var head = new ListNode(1,
                         new ListNode(2,
                         new ListNode(3,
                         new ListNode(4,
                         new ListNode(5)))));

            var solution = new Solution();
            var reversed = solution.ReverseList(head);

            PrintList(reversed); // Output: 5 4 3 2 1
        }
    }
}
