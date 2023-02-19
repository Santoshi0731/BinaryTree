using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAssig
{
    public class BinarySearchTree_UC3<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree_UC3<T> LeftTree { get; set; }
        public BinarySearchTree_UC3<T> RightTree { get; set; }

        public BinarySearchTree_UC3(T nodeData)
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
                    this.LeftTree = new BinarySearchTree_UC3<T>(item);
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
                    this.RightTree = new BinarySearchTree_UC3<T>(item);

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

        public bool IfExists(T element, BinarySearchTree_UC3<T> node)
        {
            if (node == null)
            {
                return false;
            }

            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }

            if(element.CompareTo(node.NodeData)<0)
            {
                IfExists(element, node.LeftTree);
            }
            if(element.CompareTo(node.NodeData)>0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }

    }
}
