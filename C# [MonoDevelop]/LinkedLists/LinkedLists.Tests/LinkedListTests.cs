using System;
using NUnit.Framework;
using LinkedLists;

namespace LinkedLists.Tests
{
	[TestFixture]
	public class MyLinkedListTests : AssertionHelper
	{
		/*
		 * Feature:	Is Empty
	     * Descr.:	Returns true if the list is empty, false otherwise
		 * 
		 */
		[Test]
		public void IsEmpty_ListIsEmpty_ReturnTrue()
		{
			var uut = new MyLinkedList();

			Assert.IsTrue(uut.IsEmpty());
		}

		[Test]
		public void IsEmpty_ListIsNotEmpty_ReturnFalse()
		{
			var uut = new MyLinkedList();
			uut.HeadInsert(1);
			Assert.IsFalse(uut.IsEmpty());
		}

		/*
		 * Feature:	Head Insert (x)
		 * Descr.:	Inserts a new node at the head of the list with ‘x’ as data
		 *
		 */ 
		[Test]
		public void HeadInsert_InsertNewNodeAtHeadOfListWithDataX_DataXIsInsertedAtHeadOfList()
		{
			var uut = new MyLinkedList();
			uut.HeadInsert(1);
			Assert.IsFalse(uut.IsEmpty());
		}

		/*
		 * Feature:	Head Remove
		 * Descr.:	Removes head node
		 * 
		 */
		[Test]
		public void HeadRemove_RemoveHeadNode_HeadNodeIsRemoved()
		{
			var uut = new MyLinkedList();
			uut.HeadInsert(1);
			uut.HeadRemove();

			Assert.IsTrue(uut.IsEmpty());
		}




	}
}

