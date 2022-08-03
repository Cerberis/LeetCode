using Common.Contracts;

namespace Common.Code.Extensions
{
    public static class ListNodeExtensions
    {
        public static int[] ConvertToIntArray(this ListNode node)
        {
            var list = new List<int>();
            while (node.next != null)
            {
                list.Add(node.next.val);
                node.next = node.next.next;
            }
            return list.ToArray();
        }
    }
}
