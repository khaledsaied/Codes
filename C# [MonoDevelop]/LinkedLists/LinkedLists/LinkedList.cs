using System;

namespace LinkedLists
{
	public class MyLinkedList
	{
		public int nodes = 0;
		public Node Head;

		public bool IsEmpty()
		{
			return nodes == 0;
		}

		public void HeadInsert(uint x)
		{
			nodes++;
			Head = new Node(x, Head);
		}

		public void HeadRemove()
		{
			if(IsEmpty) return;

			nodes--;
			Head = Head.Next;
		}
	}
}

