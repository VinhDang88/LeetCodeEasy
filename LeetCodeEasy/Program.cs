
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

            int[] ints = {2,2,1,3,3,4};

            int FindOne(int[] ints) //the idea here is that if the number appears twice we can add it and then remove it right after
            {
                int counter = 0;
                int goodcounter = 0;
                List<int> list = new List<int>();
                HashSet<int> set = new HashSet<int>();

                foreach(int i in ints)
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
                for (int i = cArray.Length-1; i > 0; i--)
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
                for(int i = 2; i<= number; i++)
                {
                    if(number%i == 0)
                    {
                        newnumber = i;
                        int counter = 0;
                        for(int j = newnumber; j>=2; j--)
                        {
                            if(newnumber % j == 0)
                            {
                                counter++;
                            }
                        }
                        if(counter == 1)
                        {
                            Console.WriteLine(newnumber);
                        }
                    }
                }
            }
            PrimeNumber();

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
            PrimeNumber2();

        }
    }
}

  