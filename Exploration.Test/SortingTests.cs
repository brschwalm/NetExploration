using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exploration.Test
{
	[TestClass]
	public class SortingTests
	{
		[TestMethod]
		public void Test_BubbleSort()
		{
			int[] items = new int[] { 80, 60, 40, 20, 10, 30, 50, 70 };
			int[] expected = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

			Sorting sorter = new Sorting();
			int[] actual = sorter.BubbleSort(items);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_BubbleSort_2()
		{
			int[] items = new int[] { 80, 60, 120, 40, 20, 90, 100, 10, 30, 110, 50, 70 };
			int[] expected = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };

			Sorting sorter = new Sorting();
			int[] actual = sorter.BubbleSort(items);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_InsertionSort()
		{
			int[] items = new int[] { 80, 60, 40, 20, 10, 30, 50, 70 };
			int[] expected = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

			Sorting sorter = new Sorting();
			int[] actual = sorter.InsertionSort(items);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_QuickSortIterative()
		{
			int[] items = new int[] { 80, 60, 120, 40, 20, 90, 100, 10, 30, 110, 50, 70 };
			int[] expected = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };
			int length = items.Length - 1;

			Sorting sorter = new Sorting();
			int[] actual = sorter.QuickSortIterative(items, 0, length);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_QuickSortRecursive()
		{
			int[] items = new int[] { 80, 60, 120, 40, 20, 90, 100, 10, 30, 110, 50, 70 };
			int[] expected = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };
			int length = items.Length - 1;

			Sorting sorter = new Sorting();
			int[] actual = sorter.QuickSortRecursive(items, 0, length);

			CollectionAssert.AreEqual(expected, actual);
		}

	}
}
