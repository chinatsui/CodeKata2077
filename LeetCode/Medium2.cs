// ---------------------------------------------------------------------------
// 2. Add Two Numbers
// https://leetcode.com/problems/add-two-numbers/
// ---------------------------------------------------------------------------

namespace CodeKata2077.LeetCode
{
    using CodeKata2077.LeetCode.Entity;

    class Medium2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            int carryNum = 0;
            ListNode res = new ListNode(), cur = res;
            while (l1 != null && l2 != null) 
            {
                int sum = l1.Value + l2.Value + carryNum;
                int curNum = sum % 10;
                carryNum = sum / 10;
                cur.Next = new ListNode() { Value = curNum };
                cur = cur.Next;
                l1 = l1.Next;
                l2 = l2.Next;
            }

            if (l1 != null)
            {
                cur.Next = HandleListNodeTail(carryNum, l1);
            }
            else if (l2 != null) 
            {
                cur.Next = HandleListNodeTail(carryNum, l2);
            }

            return res.Next;
        }

        private static ListNode HandleListNodeTail(int carryNum, ListNode node) 
        {
            ListNode res = new ListNode(), cur = res;
            while (node != null) 
            {
                int sum = carryNum + node.Value;
                int curNum = sum % 10;
                carryNum = sum / 10;
                cur.Next = new ListNode() { Value = curNum };
                cur = cur.Next;
                node = node.Next;
            }

            if (carryNum > 0) 
            {
                cur.Next = new ListNode() { Value = carryNum };
            }

            return res.Next;
        }
    }
}
