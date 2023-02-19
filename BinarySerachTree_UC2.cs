using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAssig
{
    public class BinarySearchTree_UC2<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree_UC2<T> LeftTree { get; set; }
        public BinarySearchTree_UC2<T> RightTree { get; set; }

        public BinarySearchTree_UC2(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;

        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currrentNodeValue = this.NodeData;

            if ((currrentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree_UC2<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree_UC2<T>(item);

                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
