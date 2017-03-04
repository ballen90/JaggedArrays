namespace Arrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[][] arrayOfArrays = new int[5][];

            arrayOfArrays[0] = new int[] { 1, 2, 3 };
            arrayOfArrays[1] = new int[] { };
            arrayOfArrays[2] = new int[] { 0, 6, 12, 18, 24, 7, 9, 5 };
            arrayOfArrays[3] = new int[] { 1 };
            arrayOfArrays[4] = new int[] { };

            var InstantiateProgram = new Program();

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                for (int j = 0; j < arrayOfArrays[i].Length; j++)
                {
                    var innerArray = arrayOfArrays[i];

                    var IsNextValueInArray = InstantiateProgram.HasNext(innerArray);

                    if (IsNextValueInArray == false)
                    {
                        return;
                    }
                    else
                    {
                        InstantiateProgram.Next(innerArray);
                        break;
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method checks if array contains any values.
        /// </summary>
        /// <param name="array">The array being passed in.</param>
        /// <returns>True or false.</returns>
        public bool HasNext(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method iterates through the next items in the array.
        /// </summary>
        /// <param name="Array"></param>
        public void Next(int[] Array)
        {
            var removeEvenNumbers = new Program();
            var oddNumbersArray = removeEvenNumbers.Remove(Array);
            for (int q = 0; q < oddNumbersArray.Length; q++)
            {
                Console.WriteLine(oddNumbersArray[q]);
            }
        }

        /// <summary>
        /// Method that removes all even numbers from the array.
        /// </summary>
        /// <param name="array"></param> 
        public int[] Remove(int[] array)
        {
            var numQuery =
                from num in array
                where (num % 2) != 0
                select num;

            return numQuery.ToArray();
        }
    }
}
