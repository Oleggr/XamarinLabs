using System.Text;
using System;
using System.Collections.Generic;
namespace Core
{
    public static class SelectionSorter
    {
        public static string SelectionSort(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return "";
            
            List<char> numsList = new List<char>();

            foreach (var c in raw)
            {
                if ("0123456789".Contains(c))
                {
                    numsList.Add(c);
                }

            }

            char[] nums = numsList.ToArray();

            Sort(nums);

            string sortedNumber = new string(nums);

            return sortedNumber;
        }

        private static int TranslateToNumber(char c)
        {
            return (int) Char.GetNumericValue(c);
        }

        private static void Sort(char[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
        }

        private static void Swap(ref char x, ref char y)
        {
            char temp = x;
            x = y;
            y = temp;
        }
    }
}