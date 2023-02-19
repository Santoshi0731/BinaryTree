namespace BinaryTreeAssig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("---------------UC1--------------");
            //Console.WriteLine("The Binary Tree :-");
            //BinarySearchTree_UC1<int> binarySearch = new BinarySearchTree_UC1<int>(56);
            //binarySearch.Insert(30);
            //binarySearch.Insert(70);

            //binarySearch.Display();
            //binarySearch.GetSize();

            //Console.WriteLine("---------------UC2--------------");
            //Console.WriteLine("The Binary Tree :-");
            //BinarySearchTree_UC2<int> binarySearch = new BinarySearchTree_UC2<int>(56);
            //binarySearch.Insert(30);
            //binarySearch.Insert(70);
            //binarySearch.Insert(22);
            //binarySearch.Insert(40);
            //binarySearch.Insert(60);
            //binarySearch.Insert(95);
            //binarySearch.Insert(11);
            //binarySearch.Insert(65);
            //binarySearch.Insert(3);
            //binarySearch.Insert(16);
            //binarySearch.Insert(63);
            //binarySearch.Insert(67);


            //binarySearch.Display();
            //binarySearch.GetSize();
           
            Console.WriteLine("---------------UC3--------------");
            Console.WriteLine("The Binary Tree :-");
            BinarySearchTree_UC3<int> binarySearch = new BinarySearchTree_UC3<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);


            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExists(67, binarySearch);
            Console.WriteLine(result);

        }
    
    }
}