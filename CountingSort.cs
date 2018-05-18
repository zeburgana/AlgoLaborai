namespace ConsoleApplication1
{
    internal class CountingSort : Sort
    {
        // The main function that sort the given string arr[] in
// alphabatical order
        public static void Sort(Array items, Array count)
        {
            for (var i = 0; i < items.Length; i++)
            {
                count[items[i]]++;
            }

            for (var i = 1; i < items.Length + 1; i++)
                count[i] += count[i-1];
            
            for (var i = items.Length - 1; i >= 0; i--)
                items[--count[items[i]]] = items[i];
            
            
        }

        public static void Sort(LinkedList items, Array count)
        {
            var current = items.GetFirstNode();
            
            for (var i = 0; i < items.Count; i++)
            {
                count[current.Value]++;
            }

            current = items.GetFirstNode();

            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    current.Value = i;
                    current = items.NextOf(current);
                }
            }
        }
    }
}