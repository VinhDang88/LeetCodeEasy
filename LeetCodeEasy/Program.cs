
using LeetCodeEasy;

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

            string text5 = "racecar";
            string reverse2 = "";
            for (int i = 0; i <= text5.Length -1; i++)
            {
                Console.WriteLine(text5[i]);
            }
            for (int i = text5.Length - 1; i >= 0; i--)
            {
                reverse2 += text5[i];
            }

            if(reverse2 == text5)
            {
                Console.WriteLine("palidnrome");
            }

            // A long string    
            string bio = "Mahesh Chand is a CEO";

            // Get first 12 characters substring from a string    
            string authorName = bio.Substring(0, 12);
            Console.WriteLine(authorName);

            string authorBio = bio.Substring(12);
            Console.WriteLine(authorBio);

            //Console.WriteLine("Enter a number");

            //string input1 = Console.ReadLine();

            //try
            //{
            //int t = int.Parse(input1);

            //}
            //catch
            //{
            //    Console.WriteLine(0);
            //}


            void FindPerfectSquare(int n)
            {

                int squared = n * n;
                string square = squared.ToString();
                string empty = "";

                for (int i = square.Length - 1; i > -1; i--)
                {
                    empty += square[i];
                }

                int news = int.Parse(empty);
                double squarer = Math.Sqrt(news);
                if (squarer % 1 != 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(squarer);
                }

            }

            string numbs = "1234";
            string[] numbers = numbs.Split(' ');
            int prods = 1;
            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);

                //prods *= int.Parse(numbers[i]);

                //int numb = int.Parse(numbers[i]);
                //Console.WriteLine(numb);
                ////int number = Int32.Parse(numbers[i]);
                ////prods *= number;

                //if(numb == 1234)
                //{
                //    Console.WriteLine("True");
                //}
                //else
                //{
                //    Console.WriteLine("False");
                //}
                //prods += numb;
            }
            //Console.WriteLine(prods);

            foreach(char n in numbs)
            {
                int some = n - '0';
                prods *= some;
                
            }
            Console.WriteLine(prods);

            char foo = '2';
            int bar = foo - '1';
            Console.WriteLine(bar);
            if(bar == 2)
            {
                Console.WriteLine("True");
            }

            //int prod = 1;
            //int newnumb;
            //for(int i = 0; i<numbs.Length; i++)
            //{
            //    Console.WriteLine(numbs[i]);
            //    int v = numbs[i];
            //    Console.WriteLine(v);
            //}


            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Method Syntax
            var ResultMS = stringArray.Any(name => name.Length > 5);


            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

  