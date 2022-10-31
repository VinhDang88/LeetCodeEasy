
  public class TreeNode
  {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 4, TreeNode left = null, TreeNode right = null)
      {
        this.val = val;
        //this.left = left;
        //this.right = right;

      }
  }

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode InvertTree(TreeNode root)
            {
                if (root == null)
                    return root;

                TreeNode temp = root.right;
                root.right = root.left;
                root.left = temp;

                InvertTree(root.left);
                InvertTree(root.right);

                return root;
            }


            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            //int level = 1;
            //while(ints.Count > 0)
            //{
            //    level++;
            //    List<int> int2 = new List<int>();
            //    for(int i = 0; i < ints.Count; i++)
            //    {
            //       int2.Add(ints[i]);
            //       ints.RemoveAt(i);
            //    }
            //    //ints = int2;

            //}
            //Console.WriteLine(level);

            int[] ints = { 2, 2, 1, 3, 3, 4 };

            int FindOne(int[] ints) //the idea here is that if the number appears twice we can add it and then remove it right after
            {
                int counter = 0;
                int goodcounter = 0;
                List<int> list = new List<int>();
                HashSet<int> set = new HashSet<int>();

                foreach (int i in ints)
                {

                    if (!set.Add(i))
                    {
                        set.Remove(i);
                    }

                    //if (list.Contains(i)) //if the number appears in our list we can remove it
                    //{
                    //   list.Remove(i);
                    //}
                    //else if (!list.Contains(i)) //if the number isnt in our list we'll add it
                    //{
                    //    list.Add(i);
                    //}
                    // 2 is now inside the list, we will now remove 2, now we add one
                }
                return set.First();
                //return list[0];
            }
            string Reverse(string text)
            {
                char[] cArray = text.ToCharArray();
                string reverse = "";
                for (int i = cArray.Length - 1; i > 0; i--)
                {
                    reverse += cArray[i];
                }
                return reverse;
            }
            string ReverseEasy(string text)
            {
                string reverse = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reverse += text[i];
                }
                return reverse;
            }
            void FindFibonacci(int findFib)
            {
                int previous = 1;
                int previous2 = 0;

                for (int i = 2; i <= findFib; i++)
                {
                    int temp = previous;
                    previous = previous + previous2;
                    previous2 = temp;

                    //int temp = previous + previous2;
                    //previous2 = previous;
                    //previous = temp;

                    Console.WriteLine(previous + previous2);
                }
            }
            int AddEvenFibonacci(int findFib)
            {
                int previous = 1;
                int previous2 = 0;
                int sum = 0;

                for (int i = 2; i <= findFib; i++)
                {
                    int temp = previous;
                    previous = previous + previous2;
                    previous2 = temp;

                    if (previous % 2 == 0)
                    {
                        sum += previous;
                    }
                }
                return sum;
            }
            void PrimeNumber()
            {
                int number = 20;
                int newnumber;
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        newnumber = i;
                        int counter = 0;
                        for (int j = newnumber; j >= 2; j--)
                        {
                            if (newnumber % j == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 1)
                        {
                            Console.WriteLine(newnumber);
                        }
                    }
                }
            }
            void PrimeNumber2()
            {
                int number = 20;
                int newnumber;
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        newnumber = i;
                        int counter = 0;
                        for (int j = 2; j <= newnumber; j++)
                        {
                            if (i % j == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 1)
                        {
                            Console.WriteLine(newnumber);
                        }
                    }
                }
            }

            for (int i = 2; i <= 50; i++)
            {
                int counter = 0;

                for (int j = 2; j <= 50; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 1 && i > 25)
                {
                    Console.WriteLine(i);
                }
            }

            //int height = int.Parse(Console.ReadLine());
            //int width = int.Parse(Console.ReadLine());
            //string material = Console.ReadLine();


            //var row = new String(material[0], width);
            //foreach (var i in Enumerable.Range(0, height))
            //    Console.WriteLine(row);


            //Find the maxiumum value of string array and divide that by the minimum value.

            //mara//

            string input = "3 5 7 2 10";
            string[] words = input.Split(' ');
            int max = 0;
            int min = 1000; //this is assuming we're not dealing with huge numbers, not sure how to set it up otherwise at the moment but whatever
            List<int> numbaa = new List<int>();

            for (var i = 0; i < words.Length; i++)
            {
                int currentNumber = Int32.Parse(words[i]);
                Console.WriteLine(currentNumber);
                numbaa.Add(currentNumber);

                //if (currentNumber < min)
                //{
                //    min = currentNumber;
                //}
                //if (currentNumber > max)
                //{
                //    max = currentNumber;
                //}
            }
            //Console.WriteLine($"Min number: {min}\nMax number: {max}\n Max/Min: {max/min}");
            Console.WriteLine(numbaa.Max() / numbaa.Min());
            Console.WriteLine(numbaa.Min());

            //SODUKU PROBLEM
            string b = "12345?789";
            string k = "123456789?";
            char[] letters = k.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (!b.Contains(letters[i]))
                {
                    Console.WriteLine(letters[i]);
                }
            }

            //string Text = "1 One, 2 Two, 3 Three is good.";

            //string[] digits = Regex.Split(Text, @"\D+");

            //foreach (string value in digits)
            //{
            //    int number;
            //    if (int.TryParse(value, out number))
            //    {
            //        Console.WriteLine(value);
            //    }
            //}

            string str = "Icecream";
            char[] result;

            // copies 4 chars from index 3 of str
            result = str.ToCharArray(3, 4);

            // prints result
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            string RemoveSpecialChars(string str)
            {
                // Create  a string array and add the special characters you want to remove

                string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
                //Iterate the number of times based on the String array length.

                for(int i = 0; i <chars.Length; i++)
                {
                    if (str.Contains(chars[i]))
                    {
                        str = str.Replace(chars[i],"");
                    }
                }
               return str;

            }
            string strs = "$['Money']";
            string noSpecialcharacters = RemoveSpecialChars(strs);
            Console.WriteLine(noSpecialcharacters);

            var vals = new int[] { 1, 2, 3, 4, 5 };

            ModifyArray(vals);

            Console.WriteLine(string.Join(", ", vals));

            void ModifyArray(int[] data)
            {
                Array.Reverse(data);
            }

            string[] names = { "Jane", "Frank", "Alice", "Tom" };
            string[] names2 = new string[4];

            Array.Copy(names, names2, names.Length);

            Console.WriteLine(string.Join(", ", names2));

            Array.Clear(names2);

            Console.WriteLine(string.Join(", ", names2));

        }
    }
}

  