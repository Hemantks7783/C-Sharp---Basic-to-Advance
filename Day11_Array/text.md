{
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements of the array are:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
}