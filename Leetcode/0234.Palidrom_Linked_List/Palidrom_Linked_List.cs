/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        //Get all items from the list
        List<int> items = GetAllItemsFromNode(head);

        //Check all values
        bool schalter = true;
        int upper_bound = items.Count / 2;
        for(int i = 0; i < upper_bound; i++)
        {
            if(items[i] != items[items.Count - i - 1])
            {
                schalter = false;
            }
        }

        //Return the solution
        return schalter;
    }

    public List<int> GetAllItemsFromNode(ListNode head)
    {
        List<int> items = new List<int>();
        while(head != null)
        {
            items.Add(head.val);
            head = head.next;
        }
        return items;
    }
}
