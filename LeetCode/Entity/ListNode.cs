using System.Text;

namespace CodeKata2077.LeetCode.Entity
{
    class ListNode
    {
        public int Value { get; set; }

        public ListNode Next { get; set; }

        public static ListNode Deserialize(params int[] nums) 
        {
            if (nums == null || nums.Length < 1) return null;
            ListNode root = new ListNode() { Value = nums[0] }, cur = root;
            for (int i = 1; i < nums.Length; i++)
            {
                cur.Next = new ListNode() { Value = nums[i] };
                cur = cur.Next;
            }
            return root;
        }

        public static string Serialize(ListNode root) 
        {
            if (root == null) return string.Empty;
            StringBuilder sb = new StringBuilder();
            while (root != null) 
            {
                sb.Append(root.Value + ",");
                root = root.Next;
            }
            return sb.ToString(0, sb.Length - 1);
        }
    }
}
