using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exploration
{
	/// <summary>
	/// Helper to test out and explore different methods of sorting
	/// </summary>
    public class Sorting
    {
		//*********************************************************************************************
		//  Helpers Sort
		//*********************************************************************************************

		public void Shift(int[] array, int index, int direction = -1)
		{
			int temp = array[index + direction];
			array[index + direction] = array[index];
			array[index] = temp;
		}

		public void Swap(int[] array, int oldPosition, int newPosition)
		{
			int temp = array[oldPosition];
			array[oldPosition] = array[newPosition];
			array[newPosition] = temp;
		}

		//*********************************************************************************************
		//  Bubble Sort
		//*********************************************************************************************

		public int[] BubbleSort(int [] items)
		{
			if (items == null || items.Length == 0)
				throw new InvalidOperationException();

			int max = items.Length;

			for (int i = 1; i < max; i++)
			{
				for (int j = 0; j < max - i; j++)
				{
					if (items[j] > items[j + 1])
					{
						Shift(items, j, 1);
					}
				}
			}

			return items;
		}

		//*********************************************************************************************
		//  Insertion Sort
		//*********************************************************************************************

		public int[] InsertionSort(int[] items)
		{
			if (items == null || items.Length == 0)
				throw new InvalidOperationException();

			for (int i = 1; i < items.Length; i++)
			{
				int j = i;
				while (j > 0)
				{
					if (items[j - 1] > items[j])
					{
						//int temp = items[j - 1];
						//items[j - 1] = items[j];
						//items[j] = temp;
						Shift(items, j);
						j--;
					}
					else
						break;
				}
			}

			return items;
		}

		//*********************************************************************************************
		//  Quick Sort
		//*********************************************************************************************
		
		public int Partition(int[] values, int left, int right)
		{
			int pivot = values[left];
			while (true)
			{
				while (values[left] < pivot)
					left++;

				while (values[right] > pivot)
					right--;

				if (left < right)
				{
					Swap(values, left, right);
				}
				else
					return right;
			}
		}

		struct QuickPosition
		{
			public int Left;
			public int Right;
		}

		public int[] QuickSortIterative(int[] items, int left, int right)
		{
			if (left >= right)
				throw new ArgumentException("Left must be less than right.");		//Invalid index range

			List<QuickPosition> list = new List<QuickPosition>();
			QuickPosition pos = new QuickPosition() { Left = left, Right = right };
			list.Insert(list.Count, pos);

			while (true)
			{
				if (list.Count == 0)
					break;

				left = list[0].Left;
				right = list[0].Right;
				list.RemoveAt(0);

				int pivot = Partition(items, left, right);

				if (pivot > 1)
				{
					pos.Left = left;
					pos.Right = pivot - 1;
					list.Insert(list.Count, pos);
				}

				if (pivot + 1 < right)
				{
					pos.Left = pivot + 1;
					pos.Right = right;
					list.Insert(list.Count, pos);
				}
			}

			return items;
		}

		public int[] QuickSortRecursive(int[] items, int left, int right)
		{
			if (left < right)
			{
				int pivot = Partition(items, left, right);

				if (pivot > 1)
					QuickSortRecursive(items, left, pivot - 1);

				if (pivot + 1 < right)
					QuickSortRecursive(items, pivot + 1, right);
			}

			return items;
		}
    }
}
