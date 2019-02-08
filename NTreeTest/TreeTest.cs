using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using N_array_Tree;

namespace NTreeTest
{
    [TestFixture]
    public class TreeTest
    {
        [TestCase]
        public void AddChildNodeIntegers()
        {
            // Arrange
            int InitialValue = 4;
            Tree<int> tree = new Tree<int>(InitialValue);

            // Act
            TreeNode<int> Child1 = tree.AddChildNode(3, tree.TopParent);
            TreeNode<int> Child2 = tree.AddChildNode(4, tree.TopParent);
            TreeNode<int> Child1_1 = tree.AddChildNode(8, Child1);
            TreeNode<int> Child1_1_1 = tree.AddChildNode(9, Child1_1);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(3, tree.TopParent.Children[0].Value);
                Assert.AreEqual(4, tree.TopParent.Children[1].Value);
                Assert.AreEqual(8, tree.TopParent.Children[0].Children[0].Value);
                Assert.AreEqual(9, tree.TopParent.Children[0].Children[0].Children[0].Value);

                Assert.That(tree.Count == 5);
                Assert.That(tree.LeafCount == 2);
                Assert.AreEqual(Child1_1.Parent, Child1);
                Assert.IsNull(tree.TopParent.Parent);
            });
        }

        [TestCase]
        public void AddChildNodeString()
        {
            // Arrange
            string InitialValue = "Uien";
            Tree<string> tree = new Tree<string>(InitialValue);

            // Act
            TreeNode<string> Child1 = tree.AddChildNode("hebben", tree.TopParent);
            TreeNode<string> Child2 = tree.AddChildNode("laagjes", tree.TopParent);
            TreeNode<string> Child1_1 = tree.AddChildNode("Knoflook", Child1);
            TreeNode<string> Child1_1_1 = tree.AddChildNode("stinkt", Child1_1);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("hebben", tree.TopParent.Children[0].Value);
                Assert.AreEqual("laagjes", tree.TopParent.Children[1].Value);
                Assert.AreEqual("Knoflook", tree.TopParent.Children[0].Children[0].Value);
                Assert.AreEqual("stinkt", tree.TopParent.Children[0].Children[0].Children[0].Value);

                Assert.That(tree.Count == 5);
                Assert.That(tree.LeafCount == 2);
                Assert.AreEqual(Child1_1.Parent, Child1);
                Assert.IsNull(tree.TopParent.Parent);
            });
        }

        [TestCase]
        public void RemoveChildTest()
        {
            // Arrange
            string InitialValue = "Uien";
            Tree<string> tree = new Tree<string>(InitialValue);

            // Act
            TreeNode<string> Child1 = tree.AddChildNode("hebben", tree.TopParent);
            TreeNode<string> Child2 = tree.AddChildNode("laagjes", tree.TopParent);
            TreeNode<string> Child1_1 = tree.AddChildNode("Knoflook", Child1);
            tree.RemoveNode(Child1);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.IsEmpty(Child1.Children);
                Assert.IsTrue(tree.TopParent.Children.Count == 1);

                Assert.That(tree.Count == 2);
                Assert.That(tree.LeafCount == 1);
                Assert.IsNull(Child1.Parent);
            });
        }

        [TestCase]
        public void TraverseNodesTest()
        {
            // Arrange
            int InitialValue = 1;
            Tree<int> tree = new Tree<int>(InitialValue);
            TreeNode<int> Child1 = tree.AddChildNode(2, tree.TopParent);
            TreeNode<int> Child2 = tree.AddChildNode(3, tree.TopParent);
            TreeNode<int> Child1_1 = tree.AddChildNode(4, Child1);

            // Act
            string TraverseTree = tree.TraverseNodes();

            // Assert
            Assert.AreEqual("1[ 2,[ 4,] 3,]", TraverseTree);
        }
        //[TestCase]
        //public void SumToLeafsTestIntegers()
        //{
        //    // Arrange
        //    int InitialValue = 4;
        //    Tree<int> tree = new Tree<int>(InitialValue);
        //    TreeNode<int> Child1 = new TreeNode<int>(3, tree.TopParent);


        //    // Act

        //    // Assert
        //}
    }
}
