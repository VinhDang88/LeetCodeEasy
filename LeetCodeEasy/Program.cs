
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
                    //    goodcounter++;
                    //}
                    //else if (!list.Contains(i)) //if the number isnt in our list we'll add it
                    //{
                    //    list.Add(i);
                    //    counter++;
                    //}
                    // 2 is now inside the list, we will now remove 2, now we add one
                }
                return set.First();
                //return list[0];
            }
            List<int> number1 = new List<int> { 3, 2 };
            List<int> numbers2 = new List<int> { 5, 5 };
            List<int> number3 = new List<int>();
            //numbers2 = number1.ToList();
            

            foreach(int i in number1)
            {
                numbers2.Add(i);
            }
            number3 = numbers2.OrderBy(x => x).ToList();
            number3.ForEach(x => Console.WriteLine(x));

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
            Console.WriteLine(Reverse("hello"));

            string word = "hello";
            Console.WriteLine(word.Length);
            string reverse = "";

            for(int i = word.Length-1 ; i > 0; i--)
            {
                reverse += word[i];
            }
            Console.WriteLine(reverse);
            for(int i = 4; i >= 0; i--)
            {
                Console.WriteLine(i);
            }



        }
    }
}

  