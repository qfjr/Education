using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Lesson
{
    class ListNode<T>
    {
        public T data;
        public ListNode<T> next;

        public static ListNode<int> search(ListNode<int> L, int key)
        {
            while(L != null && L.data != key)
            {
                L = L.next;
            }

            // If key was not present in the list, L will have become null
            return L;
        }


    }
}
