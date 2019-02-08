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
            Tree<string> Boompje = new Tree<string>("Play Music");
            TreeNode<string> Child1 = Boompje.AddChildNode("Halo", Boompje.TopParent);
            TreeNode<string> Child2 = Boompje.AddChildNode("wereld", Child1);
            TreeNode<string> Child21 = Boompje.AddChildNode("wereld", Child1);
            TreeNode<string> Child11 = Boompje.AddChildNode("De", Boompje.TopParent);
            TreeNode<string> Child31 = Boompje.AddChildNode("wereld", Child11);
            TreeNode<string> Child32 = Boompje.AddChildNode("is", Child11);
            TreeNode<string> Child33 = Boompje.AddChildNode("van", Child11);
            

            string TraverseBoom = Boompje.TraverseNodes(Boompje.TopParent);


            System.Console.WriteLine(TraverseBoom);
            //System.Console.WriteLine(Boompje.Count.ToString() + " " + Boompje.LeafCount.ToString());
            var SumLeafs = Boompje.SumToLeafs(Boompje.TopParent);
            System.Console.WriteLine(SumLeafs.ToString());

            System.Console.ReadLine();
        }
    }
}
