namespace SortAlgorithms
{
    public class MergeSort
    {
        public static int[] Merge(int[] arrLeft, int[] arrRight)
        {
            var array = new int[arrLeft.Length + arrRight.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < arrLeft.Length || j < arrRight.Length)
            {
                if (i < arrLeft.Length && j < arrRight.Length)
                {
                    if (arrLeft[i] <= arrRight[j])
                    {
                        array[k++] = arrLeft[i++];
                    }
                    else
                    {
                        array[k++] = arrRight[j++];
                    }
                }

                else if (i < arrLeft.Length)
                {
                    array[k++] = arrLeft[i++];
                }
                else if (j < arrRight.Length)
                {
                    array[k++] = arrRight[j++];
                }
            }

            return array;

        }

        public static int[] Sort(int[] array)
        {
            if (array.Length <= 1) return array;
            int[] left;
            int[] right;
            if (array.Length % 2 == 0)
            {
                left = new int[array.Length / 2];
                right = new int[array.Length / 2];
                for (int i = 0; i < array.Length / 2; i++)
                {
                    left[i] = array[i];
                }
                for (int i = 0; i < array.Length / 2; i++)
                {
                    right[i] = array[array.Length / 2 + i];
                }

            }
            else
            {
                left = new int[array.Length / 2 + 1];
                right = new int[array.Length / 2];
                for (int i = 0; i < array.Length / 2 + 1; i++)
                {
                    left[i] = array[i];
                }
                for (int i = 0; i < array.Length / 2; i++)
                {
                    right[i] = array[array.Length / 2 + 1 + i];
                }

            }

            left = Sort(left);
            right = Sort(right);

            var result = Merge(left, right);

            return result;

        }
    }
}
