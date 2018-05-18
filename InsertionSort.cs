namespace ConsoleApplication1
{
    internal class InsertionSort : Sort
    {
        public static void Sort(Array items, Array count)
        {
            for (var i = 0; i < items.Length - 1; i++)
            {
                var key = items[i];
                var j = i-1;
 
                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && items[j] > key)
                {
                    items[j+1] = items[j];
                    j = j-1;
                }
                
                items[j+1] = key;
            }
        }

        public static void Sort(LinkedList items, Array count)
        {
            var current = items.GetFirstNode();
            var sorted = new int[items.Count];

            for (var i = 0; i < sorted.Length; i++)
            {
                sorted[i] = current.Value;
                current = items.NextOf(current);
            }
            
            for (var i = 0; i < sorted.Length - 1; i++)
            {
                var key = sorted[i];
                var j = i-1;
 
                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && sorted[j] > key)
                {
                    sorted[j+1] = sorted[j];
                    j = j-1;
                }
                
                sorted[j+1] = key;
            }

            current = items.GetFirstNode();

            foreach (var t in sorted)
            {
                current.Value = t;
                current = items.NextOf(current);
            }
        }
    }
}