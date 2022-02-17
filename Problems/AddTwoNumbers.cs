using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    public class AddTwoNumbers
    {

        public void CreatInput()
        {
            ListNode listNode1 = new ListNode();
            listNode1.val = 2;
            listNode1.next = new ListNode();
            listNode1.next.val = 4;
            listNode1.next.next = new ListNode();
            listNode1.next.next.val = 3;

            ListNode listNode2 = new ListNode();
            listNode2.val = 5;
            listNode2.next = new ListNode();
            listNode2.next.val = 6;
            listNode2.next.next = new ListNode();
            listNode2.next.next.val = 4;

            var ls = Add_Two_Numbers(listNode1, listNode2);
        }

        public ListNode Add_Two_Numbers(ListNode l1, ListNode l2)
        {
            string s1 = ConvertingList(l1, string.Empty);
            string s2 = ConvertingList(l2, string.Empty);
            var value = (Convert.ToInt64(String.IsNullOrEmpty(s1) ? "0" : s1) +
                (Convert.ToInt64(String.IsNullOrEmpty(s2) ? "0" : s2))).ToString().ToCharArray().Reverse();

            ListNode listNode = new ListNode();
            listNode = BuildListNode(listNode, value.ToArray());
            return listNode;
        }

        public string ConvertingList(ListNode l1, string value)
        {
            if (l1.next == null)
            {
                value = l1.val + value;
            }
            else
            {
                value = l1.val + value;
                value = ConvertingList(l1.next, value);
            }
            return value;
        }

        public ListNode BuildListNode(ListNode listNode, char[] value)
        {
            if (value.Length == 1)
            {
                listNode.next = null;
                listNode.val = Convert.ToInt32(value[0].ToString());
            }
            else if (value.Length > 1)
            {
                listNode.val = Convert.ToInt32(value[0].ToString());
                listNode.next = new ListNode();
                var v = value.Skip(1).ToArray();
                listNode.next = BuildListNode(listNode.next, v);
            }
            return listNode;
        }
    }
}
