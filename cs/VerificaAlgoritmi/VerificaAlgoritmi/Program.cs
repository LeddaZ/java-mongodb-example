using System;
using System.Runtime.InteropServices;

namespace VerificaAlgoritmi { 

    class TreeNode
    {
        public int value;
        public TreeNode[] children;

        public TreeNode(int val)
        {
            value = val;
            children = new TreeNode[0];
        }

        public TreeNode(int val, TreeNode[] childNodes)
        {
            value = val;
            children = childNodes;
        }
    }

    internal class Program

    {
        public static int CalcolaPeso(TreeNode root)
        {
            int weight = 0;
            if (root.children.Length == 0)
            {
                weight++;
            }

            foreach (TreeNode child in root.children)
            {
                weight += CalcolaPeso(child);
            }

            return weight;
        }
        static void Main(string[] args)
        {
            int[] array = { 54, 17, 14, 10, 9, 6, 6, 5, 4, 3 };
            int indice_f(int[] A)
            {
                int n = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] >= i + 1)
                        n++;
                }
                return n;
            }
            Console.WriteLine(indice_f(array));
            Console.ReadKey();
            Console.WriteLine();

            // Esempio di utilizzo
            TreeNode leaf1 = new TreeNode(9);
            TreeNode leaf2 = new TreeNode(10);
            TreeNode leaf3 = new TreeNode(11);
            TreeNode[] children = { leaf1, leaf2, leaf3 };
            TreeNode root = new TreeNode(8, children);

            int weight = CalcolaPeso(root);
            Console.WriteLine("Peso del nodo radice: " + weight); // Output: 8
        }
    }
}
