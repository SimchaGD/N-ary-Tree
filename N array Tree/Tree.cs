using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Implementeer een Tree:
 *  De Tree is N-ary
 *  Gebruik 2 classes: TreeNode en Tree
 *  Elke TreeNode bevat een waarde van type T
 *  Implementeer de volgende properties op Tree:
 *      Count (Geef het aan Nodes van de Tree)
 *      LeafCount (Geef het aantal leaf Nodes in de Tree)
 *  Implementeer de volgende methods op Tree:
 *      AddChildNode(parentNode, value)
 *      [Voegt een nieuwe TreeNode toe met een waarde onder de parent TreeNode]
 *      RemoveNode(node)
 *      [Verwijder TreeNode met onderliggende Nodes]
 *      TraverseNodes()
 *      [Geeft alle node waardes terug (met iterator)]
 *      SumToLeafs()
 *      [Geeft de som van alle onderliggende nodes terug]
 *  
 *  Schrijf voor elk non-triviale class die je maakt een NUnit class met unit tests]
 *  
 *  Zet je uitwerking op github met twee projecten
*/
namespace N_array_Tree
{
    class Tree<T>
    {
        public int Count{ get; set; }
        public int LeafCount { get; set; }
        public TreeNode<T> TopParent { get; set; }
        public StringBuilder TraverseString = new StringBuilder();

        public Tree(T initialValue)
        {
            Count = 1;
            LeafCount = 1;
            TopParent = new TreeNode<T>(initialValue, null);
        }

        public TreeNode<T> AddChildNode(T value, TreeNode<T> Parent)
        {
            // update properties
            Count++;
            if (Parent.Children.Count > 0)
            {
                LeafCount++;
            }
            
            TreeNode<T> childNode = new TreeNode<T>(value, Parent);
            Parent.Children.Add(childNode);
            return childNode;
        }

        public string TraverseNodes(TreeNode<T> StartParent)
        {
            TraverseString.Clear();
            TraverseString.Append(StartParent.Value.ToString());
            TraverseString = TraverseStringBuilder(StartParent);
            return TraverseString.ToString();
        }

        public StringBuilder TraverseStringBuilder(TreeNode<T> StartParent)
        {
            TraverseString.Append("[");
            int ChildCount = 1;
            foreach (TreeNode<T> child in StartParent.Children)
            {
                TraverseString.Append(" " + child.Value.ToString() + ",");
                if (child.Children.Count > 0)
                {
                    TraverseStringBuilder(child);
                }
                if (StartParent.Children.Count == ChildCount) TraverseString.Append("]");
                ChildCount++;
            }

            return TraverseString;
        }

        

    }
}
