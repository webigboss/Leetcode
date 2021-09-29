using System;
using System.Collections.Generic;
using System.Text;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class AmazonOA_FindMaxSumOfPairsInALinkedList
{

    public void Test()
    {
        int[] values;
        ListNode head;
        values = new int[] { 1, 2, 4, 4, 5, 6, 7, 8, 9, 10 };
        head = CreateLinkedList(values);
        Console.WriteLine($"MaxSumOfPair({PrintLinkedList(head)}) -> {MaxSumOfPair(head)}");
        values = new int[] { 1, 2, 4, 4, 5, 6, 7, 8, 9 };
        head = CreateLinkedList(values);
        Console.WriteLine($"MaxSumOfPair({PrintLinkedList(head)}) -> {MaxSumOfPair(head)}");
        values = new int[] { 1 };
        head = CreateLinkedList(values);
        Console.WriteLine($"MaxSumOfPair({PrintLinkedList(head)}) -> {MaxSumOfPair(head)}");
        values = new int[] { 1, 2 };
        head = CreateLinkedList(values);
        Console.WriteLine($"MaxSumOfPair({PrintLinkedList(head)}) -> {MaxSumOfPair(head)}");
    }

    private ListNode CreateLinkedList(int[] values)
    {
        var dummyHead = new ListNode(0);
        var cur = dummyHead;
        foreach (var val in values)
        {
            cur.next = new ListNode(val);
            cur = cur.next;
        }
        return dummyHead.next;
    }

    public int MaxSumOfPair(ListNode head)
    {
        var dummyHead = new ListNode(0, head);
        var fast = dummyHead;
        var slow = dummyHead;
        // even d->1->2(s)->3->4(f)
        // odd d->1->2(s)->3->4(f)->5

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode next = slow.next;
        if (fast.next == null)
        { //even
            slow.next = null;
        }

        var reversed = Reverse(next);
        Console.WriteLine(PrintLinkedList(head));
        Console.WriteLine(PrintLinkedList(reversed));
        
        var ans = int.MinValue;
        while(head != null && reversed != null){
            ans = Math.Max(ans, head.val + reversed.val);
            head = head.next;
            reversed = reversed.next;
        }
        return ans;
    }

    private ListNode Reverse(ListNode head)
    {
        if (head == null) return null;
        ListNode temp = null;
        ListNode pre = null;
        while (head != null)
        {
            temp = head.next;
            head.next = pre;
            pre = head;
            head = temp;
        }
        return pre;
    }

    private string PrintLinkedList(ListNode head)
    {
        var sb = new StringBuilder();
        sb.Append("[");
        bool isHead = true;
        while (head != null)
        {
            if (!isHead)
            {
                sb.Append("->");
            }
            isHead = false;
            sb.Append(head.val);
            head = head.next;
        }
        sb.Append("]");
        return sb.ToString();
    }
}