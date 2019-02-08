using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N_array_Tree;
/*Implementeer een Tree:
 *  De Tree is N-ary
 *  Gebruik 2 classes: TreeNode en Tree
 *  Elke TreeNode bevat een waarde van type T
 *  Implementeer de volgende properties op Tree:
 *DONE  Count (Geef het aan Nodes van de Tree)
 *DONE  LeafCount (Geef het aantal leaf Nodes in de Tree)
 *  Implementeer de volgende methods op Tree:
 *DONE  AddChildNode(parentNode, value)
 *      [Voegt een nieuwe TreeNode toe met een waarde onder de parent TreeNode]
 *DONE  RemoveNode(node)
 *      [Verwijder TreeNode met onderliggende Nodes]
 *DONE  TraverseNodes()
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
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> Boompje = new Tree<int>(1);
            TreeNode<int> Child1 = Boompje.AddChildNode(2, Boompje.TopParent);
            TreeNode<int> Child2 = Boompje.AddChildNode(3, Boompje.TopParent);
            TreeNode<int> Child1_1 = Boompje.AddChildNode(4, Child1);
            
            

            string TraverseBoom = Boompje.TraverseNodes(Boompje.TopParent);


            System.Console.WriteLine(TraverseBoom);
            //System.Console.WriteLine(Boompje.Count.ToString() + " " + Boompje.LeafCount.ToString());
            var SumLeafs = Boompje.SumToLeafs(Boompje.TopParent);
            System.Console.WriteLine(SumLeafs.ToString());

            System.Console.ReadLine();
        }
    }
}
