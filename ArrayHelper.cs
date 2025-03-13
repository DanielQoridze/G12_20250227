namespace G12_20250227
{
    interface IComparables 
    {
        int CompareTo(object obj);
    }
    static class ArrayHelper
    {
        public static void Sort(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] is not IComparables)
                    {
                        throw new ArgumentException("Object does not implement Comparable class.");
                    }
                    if ((array[i] as IComparables)!.CompareTo(array[j]) > 0)
                    {
                        object temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
