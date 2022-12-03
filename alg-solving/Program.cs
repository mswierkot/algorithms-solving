
using alg_solving;
using System.Numerics;
using System.Text;

public static class Solution
{
    public static ListNode ParseNumberToNode(int[] arr)
    {
        ListNode head = null;
        foreach(int n in arr)
        {
            ListNode node = new ListNode(n, head);
            head = node;
        }
        return head;
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        StringBuilder number1 = new StringBuilder("");
        StringBuilder number2 = new StringBuilder("");

        while (l1 != null || l2 != null)
        {
            if(l1 != null)
            {
                number1.Insert(0, l1.val.ToString());
                l1 = l1.next;
            }
            if (l2 != null)
            {
                number2.Insert(0, l2.val.ToString());
                l2 = l2.next;
            }
        }

        BigInteger num = BigInteger.Parse(number1.ToString()) + BigInteger.Parse(number2.ToString());

        ListNode head = null;
        for(int i = 0; i < num.ToString().Length; i++)
        {
            ListNode node = new ListNode(int.Parse(num.ToString()[i].ToString()), head);
            head = node;
        }

        return head;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
        int[] arr2 = new int[] { 5,6,4};

        var node10 = Solution.ParseNumberToNode(arr1);
        var node11 = Solution.ParseNumberToNode(arr2);
        var head = Solution.AddTwoNumbers(node10, node11);

        string result = "";
        while(head != null)
        {
            result += head.val;
            head = head.next;
        }
        Console.WriteLine(result);
    }
}