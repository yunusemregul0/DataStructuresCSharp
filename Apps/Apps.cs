
using CustomTypes;
using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apps
{
    public static class Apps
    {
        private static void CustomTypesExamples()
        {
            var arr = new Student[]
                        {
                        new Student(10,"Ahmet",3.40),
                        new Student(15,"Mehmet",2.45),
                        new Student(85,"Filiz",1.30),
                        new Student(65,"Can",2.65),
                        new Student(75,"Mete",2.40),
                        new Student(90,"Ömer",3.10),
                        new Student(12,"Fatma",1.45),
                        new Student(14,"Merve",3.80),
                        new Student(18,"Semih",2.80)
                        };


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array<Student>");

            var newArr = new DataStructures
                .Array
                .Array<Student>(arr);

            newArr.Add(new Student(22, "Aslı", 3.90));

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("SinglyLinked<Student>");

            var linkedList = new DataStructures
                .LinkedList
                .SinglyLinkedList
                .SinglyLinkedList<Student>(newArr);

            linkedList.AddAfter(linkedList.Head,
                new Student(99, "Yigit", 4.00));

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("BST<Student>");

            var bst = new DataStructures
                .Tree
                .BST
                .BST<Student>(linkedList);

            foreach (var item in bst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("MinHeap<Student>");

            var heap = new DataStructures
                .Heap
                .MinHeap<Student>(bst);

            foreach (var item in heap)
            {
                Console.WriteLine(heap.DeleteMinMax());
            }

            Console.WriteLine("MaxHeap<Student>");


            var maxHeap = new DataStructures
                .Heap
                .BinaryHeap<Student>(DataStructures.Shared.SortDirection.Descending, bst);

            foreach (var item in maxHeap)
            {
                // Console.WriteLine(item);
                Console.WriteLine(maxHeap.DeleteMinMax());
            }

            // Sıralama Algoritmalari
            Console.WriteLine("BubbleSort.Sort<Student>(arr)");

            DataStructures.SortingAlgorithms.BubbleSort.Sort<Student>(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Insertion.Sort<Student>(arr)");
            DataStructures.SortingAlgorithms
                .InsertionSort
                .Sort<Student>(arr,
                            DataStructures.Shared.SortDirection.Descending);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        private static void HeapSortAlgorithmApplication()
        {
            var arr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            var heap = new DataStructures.Heap.MinHeap<sbyte>(arr);
            foreach (var item in heap)
            {
                Console.Write($"{heap.DeleteMinMax(),-5}");
            }

            Console.WriteLine();
        }
        private static void MergeSortAlgorithmApplication()
        {
            var arr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.MergeSort.Sort<sbyte>(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        private static void QuicksortAlgorithmApplication()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            DataStructures.SortingAlgorithms.Quicksort.Sort<int>(arr);
            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        private static void InsertionSortApplication()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }


            DataStructures.SortingAlgorithms.InsertionSort.Sort<int>(arr,
                DataStructures.Shared.SortDirection.Descending);

            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            DataStructures.SortingAlgorithms.InsertionSort.Sort<int>(arr);

            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        private static void BubbleSortAlgorithmApplication()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            DataStructures.SortingAlgorithms.BubbleSort.Sort<int>(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        private static void SelectionSortApplication()
        {
            var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
            Console.WriteLine();

            DataStructures.SortingAlgorithms.SelectionSort.Sort<int>(arr,
                DataStructures.Shared.SortDirection.Descending);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }

            Console.WriteLine();

            DataStructures.SortingAlgorithms.SelectionSort.Sort<int>(arr,
                DataStructures.Shared.SortDirection.Asceding);
            foreach (var item in arr)
            {
                Console.Write($"{item,-5}");
            }
        }
        private static void KruskalsAlgorithmApplication()
        {
            // Grap oluştur
            var graph = new DataStructures
                .Graph
                .AdjancencySet
                .WeightedGraph<int, int>();

            // Vertex oluştur
            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            // Kenarları ekle 
            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(5, 4, 10);

            var algorithm = new
                DataStructures
                .Graph
                .MinimumSpanningTree
                .Kruskals<int, int>();

            algorithm.FindMinimumSpanningTree(graph)
                .ForEach(edge => Console.WriteLine(edge));
        }
        private static void PrimsAlgorithmApplication()
        {
            var graph = new DataStructures
                            .Graph
                            .AdjancencySet
                            .WeightedGraph<int, int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 7, 11);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(7, 8, 7);
            graph.AddEdge(7, 6, 1);
            graph.AddEdge(6, 8, 6);
            graph.AddEdge(2, 8, 2);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 5, 4);
            graph.AddEdge(6, 5, 2);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(5, 4, 10);

            var algorithm = new DataStructures
                .Graph
                .MinimumSpanningTree
                .Kruskals<int, int>();

            algorithm.FindMinimumSpanningTree(graph)
                .ForEach(edge => Console.WriteLine(edge));
        }
        private static void BreadthFirstSearchApplication()
        {
            var graph = new DataStructures
                            .Graph
                            .AdjancencySet
                            .Graph<int>();

            for (int i = 0; i < 12; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 9);
            graph.AddEdge(2, 9);
            graph.AddEdge(5, 7);
            graph.AddEdge(7, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(5, 6);

            var algorithm = new DataStructures
                .Graph
                .Search
                .BreadthFirst<int>();

            Console.WriteLine(algorithm.Find(graph, 5) ? "Yes." : "No!");
        }
        private static void DepthFirstSearchApplication()
        {
            var graph = new DataStructures
                            .Graph
                            .AdjancencySet
                            .Graph<int>();

            for (int i = 0; i <= 11; i++)
                graph.AddVertex(i);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 10);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 9);
            graph.AddEdge(2, 9);
            graph.AddEdge(5, 7);
            graph.AddEdge(7, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(5, 6);

            var algoritm = new DataStructures
                .Graph
                .Search
                .DepthFirst<int>();

            Console.WriteLine("{0}", algoritm.Find(graph, 5)
                ? "Yes."
                : "No!");
        }
        private static void WeightedDiGrapApplication()
        {
            var graph = new
                            DataStructures
                            .Graph
                            .AdjancencySet
                            .WeightedDiGraph<char, int>(new char[] { 'A', 'B', 'C', 'D', 'E' });

            graph.AddEdge('A', 'C', 12);
            graph.AddEdge('A', 'D', 60);
            graph.AddEdge('B', 'A', 10);
            graph.AddEdge('C', 'D', 32);
            graph.AddEdge('C', 'B', 20);
            graph.AddEdge('E', 'A', 7);

            Console.WriteLine($"Number of vertex in this graph: {graph.Count}");

            Console.WriteLine("Is there an edge between A and B? {0}",
                graph.HasEdge('A', 'B') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between B and A? {0}",
                graph.HasEdge('B', 'A') ? "Yes." : "No!");


            foreach (var vertexKey in graph)
            {
                Console.WriteLine(vertexKey);
                foreach (char key in graph.GetVertex(vertexKey))
                {
                    var nodeU = graph.GetVertex(vertexKey);
                    var nodeV = graph.GetVertex(key);
                    var w = nodeU.GetEdge(nodeV).Weight<int>();

                    Console.WriteLine($"   {vertexKey} - " +
                        $"({w}) - " +
                        $"{key}");
                }
            }
        }
        private static void DiGraphApplication()
        {
            var graph = new DataStructures
                            .Graph
                            .AdjancencySet
                            .DiGraph<char>(new char[] { 'A', 'B', 'C', 'D', 'E' });

            graph.AddEdge('B', 'A');
            graph.AddEdge('A', 'D');
            graph.AddEdge('D', 'E');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('C', 'A');
            graph.AddEdge('C', 'B');

            Console.WriteLine("Is there an edge between A and B? {0}",
                graph.HasEdge('A', 'B') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between B and A? {0}",
                graph.HasEdge('B', 'A') ? "Yes." : "No!");

            graph.RemoveVertex('C');

            foreach (var key in graph)
            {
                Console.WriteLine(key);
                foreach (var item in graph.GetVertex(key))
                {
                    Console.WriteLine($"  {item}");
                }
            }

            Console.WriteLine($"Number of vertex in graph : {graph.Count}");
        }
        private static void WeightedGraphApplication()
        {
            var graph = new DataStructures
                            .Graph
                            .AdjancencySet
                            .WeightedGraph<char, double>(new char[] { 'A', 'B', 'C', 'D' });

            graph.AddEdge('A', 'B', 1.2);
            graph.AddEdge('A', 'D', 2.3);
            graph.AddEdge('D', 'C', 5.5);

            Console.WriteLine("Is there an edge between A and B? {0}",
                graph.HasEdge('A', 'B') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between B and A? {0}",
                graph.HasEdge('B', 'A') ? "Yes." : "No!");

            foreach (char vertex in graph)
            {
                Console.WriteLine(vertex);
                foreach (char key in graph.GetVertex(vertex))
                {
                    var node = graph.GetVertex(key);
                    Console.WriteLine($"  {vertex} - " +
                        $"{node.GetEdge(graph.GetVertex(vertex)).Weight<double>()} - " +
                        $"{key}");
                }
            }

            Console.WriteLine($"Number of vertex in graph: {graph.Count}");
        }
        private static void GraphApp()
        {
            var graph = new DataStructures
                            .Graph
                            .AdjancencySet
                            .Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'D');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('D', 'E');
            graph.AddEdge('E', 'F');
            graph.AddEdge('F', 'G');


            Console.WriteLine("Is there an edge between A and B ? {0} ",
                graph.HasEdge('A', 'B') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between B and A ? {0} ",
                graph.HasEdge('B', 'A') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between B and D ? {0} ",
               graph.HasEdge('B', 'D') ? "Yes." : "No!");

            Console.WriteLine("Is there an edge between D and B ? {0} ",
              graph.HasEdge('D', 'B') ? "Yes." : "No!");




            foreach (var key in graph)
            {
                Console.WriteLine(key);
                foreach (var vertex in graph.GetVertex(key).Edges)
                {
                    Console.WriteLine("   {0}", vertex);
                }

            }
            Console.WriteLine($"Number of vertex in the graph : {graph.Count}");
        }
        private static void DisjointSetApp()
        {
            var disjointSet = new DataStructures
                            .Set
                            .DisjointSet<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });

            disjointSet.Union(5, 6);
            disjointSet.Union(1, 2);
            disjointSet.Union(0, 2);

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)}");
            }
        }
        private static void BinaryHeapApp()
        {
            var heap = new DataStructures
                            .Heap
                            .BinaryHeap<int>(DataStructures.Shared.SortDirection.Asceding,
                            new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });


            foreach (var item in heap)
            {
                Console.Write(item + "  ");
            }
        }
        private static void MinHeapApp()
        {
            var heap = new DataStructures
                .Heap
                .MinHeap<int>(new int[] { 4, 1, 10, 8, 7, 5, 9, 3, 2 });

            Console.WriteLine(heap.DeleteMinMax() + " has been removed.");

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
        }
        private static void BinaryTreePaths()
        {
            var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99, 100, 120, 130 });
            bst.Remove(bst.Root, 22);
            new BinaryTree<int>().PrintPaths(bst.Root);
        }
        private static void NumberOfFullNodesandHalfNodes()
        {
            var bst =
                            new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            bst.Remove(bst.Root, 3);
            bst.Remove(bst.Root, 99);

            Console.WriteLine($"Number of leafs         : " +
                $"{BinaryTree<int>.NumberOfLeafs(bst.Root)}");

            Console.WriteLine($"Number of full nodes    : " +
                $"{BinaryTree<int>.NumberOfFullNodes(bst.Root)}");

            Console.WriteLine($"Number of half nodes    : " +
                $"{BinaryTree<int>.NumberOfHalfNodes(bst.Root)}");
        }
        private static void DeepestNodeApp()
        {
            var bt = new BinaryTree<char>();
            bt.Root = new Node<char>('F');
            bt.Root.Left = new Node<char>('A');
            bt.Root.Right = new Node<char>('T');
            bt.Root.Left.Left = new Node<char>('D');

            var list = bt.LevelOrderNonRecursiveTraversal(bt.Root);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Deepest Node        : " +
                $"{bt.DeepestNode(bt.Root)}");
            Console.WriteLine($"Deepest Node        : " +
                $"{bt.DeepestNode()}");
            Console.WriteLine($"Max. Depth          : " +
                $"{BinaryTree<char>.MaxDepth(bt.Root)}");
        }
        private static void MaxDepthApp()
        {
            var bst = new DataStructures
                            .Tree
                            .BST
                            .BST<byte>(new byte[] { 60, 40, 70, 20, 45, 65, 85, 90 });

            var list = new DataStructures
                .Tree
                .BinaryTree
                .BinaryTree<byte>().InOrder(bst.Root);

            foreach (var node in list)
            {
                Console.Write($"{node,-3} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Min     : {bst.FindMin(bst.Root)}");
            Console.WriteLine($"Max     : {bst.FindMax(bst.Root)}");
            Console.WriteLine($"Depth   : {DataStructures.Tree.BinaryTree.BinaryTree<byte>.MaxDepth(bst.Root)}");
        }
        private static void BSTApp()
        {
            var BST = new DataStructures.Tree.BST.BST<int>(new List<int>() { 60, 40, 70, 20, 45, 65, 85 });
            var bt = new DataStructures.Tree.BinaryTree.BinaryTree<int>();

            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            BST.Remove(BST.Root, 20);
            BST.Remove(BST.Root, 40);
            BST.Remove(BST.Root, 60);

            Console.WriteLine();
            bt.ClearList();

            bt.InOrder(BST.Root)
               .ForEach(node => Console.Write($"{node,-3} "));


            Console.WriteLine();

            Console.WriteLine($"Minimum value : {BST.FindMin(BST.Root)}");
            Console.WriteLine($"Maximum value : {BST.FindMax(BST.Root)}");

            var keyNode = BST.Find(BST.Root, 100);

            if (keyNode != null)
                Console.WriteLine($"{keyNode.Value} - " +
                $"Left: {keyNode.Left.Value} - " +
                $"Right : {keyNode.Right.Value}");
        }
        private static void QeueuApp()
        {
            var numbers = new int[] { 10, 20, 30 };
            var q1 = new DataStructures.Queue.Queue<int>();
            var q2 = new DataStructures.Queue.Queue<int>(DataStructures.Queue.QueueType.LinkedList);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                q1.EnQueue(number);
                q2.EnQueue(number);
            }

            Console.WriteLine($"q1 Count : {q1.Count}");
            Console.WriteLine($"q2 Count : {q2.Count}");

            Console.WriteLine($"{q1.DeQueue()} has been removed from q1.");
            Console.WriteLine($"{q2.DeQueue()} has been removed from q2.");

            Console.WriteLine($"q1 Count : {q1.Count}");
            Console.WriteLine($"q2 Count : {q2.Count}");

            Console.WriteLine($"q1 Peek : {q1.Peek()}");
            Console.WriteLine($"q2 Peek : {q2.Peek()}");
        }
        private static void StackApp()
        {
            var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            var stack1 = new DataStructures.Stack.Stack<char>();
            var stack2 = new DataStructures.Stack.Stack<char>(DataStructures.Stack.StackType.LinkedList);

            foreach (var c in charset)
            {
                Console.WriteLine(c);
                stack1.Push(c);
                stack2.Push(c);
            }

            Console.WriteLine("\nPeek");
            Console.WriteLine($"Stack1: {stack1.Peek()}");
            Console.WriteLine($"Stack2: {stack2.Peek()}");

            Console.WriteLine("\nCount");
            Console.WriteLine($"Stack1: {stack1.Count}");
            Console.WriteLine($"Stack2: {stack2.Count}");

            Console.WriteLine("\nPop");
            Console.WriteLine($"Stack1: {stack1.Pop()} has been removed.");
            Console.WriteLine($"Stack2: {stack2.Pop()} has been removed.");
        }
        private static void DoublyLinkedListApp03()
        {
            var list = new DoublyLinkedList<int>(new int[] { 23, 44, 55, 61 });
            list.Remove(55);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void DoublyLinkedListApp02()
        {
            var list = new
                            DoublyLinkedList<char>(new char[] { 'x', 'y', 'z', 'a', 'b' });

            Console.WriteLine($"{list.RemoveFirst()} has been removed from list.");
            Console.WriteLine($"{list.RemoveLast()} has been removed from list.");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void DoublyLinkedListApp01()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(12);
            list.AddFirst(23);
            // 23 12

            list.AddLast(44);
            list.AddLast(55);
            // 23 12 44 55

            list.AddAfter(list.Head.Next,
                new DoublyLinkedListNode<int>(13));
            // 23 12 13 44 55

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void SinglyLinkedListApp05()
        {
            var list = new SinglyLinkedList<int>(new int[] { 23, 44, 32, 55 });
            list.Remove(32);
            //list.Remove(55);
            //list.Remove(23);
            // list.Remove(13);
            // list.Remove(44);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void SinglyLinkedListApp04()
        {
            var rnd = new Random();
            var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
            var list = new SinglyLinkedList<int>(initial);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{list.RemoveFirst()} has been removed.");
            Console.WriteLine($"{list.RemoveFirst()} has been removed.");


            Console.WriteLine($"{list.RemoveLast()} has been removed.");
            Console.WriteLine($"{list.RemoveLast()} has been removed.");


            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
        private static void SinglyLinkedListApp03()
        {
            // Language Integrated Query - LINQ
            var rnd = new Random();
            var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
            var linkedlist = new SinglyLinkedList<int>(initial);

            var q = from item in linkedlist
                    where item % 2 == 1
                    select item;
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            linkedlist.Where(x => x > 5)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
        private static void SinglyLinkedListApp02()
        {
            var arr = new char[] { 'a', 'b', 'c' };
            var list = new List<char>(arr);
            var clinkedlist = new LinkedList<char>(arr);
            list.AddRange(new char[] { 'd', 'e', 'f' });

            var linkedlist = new SinglyLinkedList<char>(list);

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }

            var charset = new List<char>(linkedlist);
            Console.WriteLine();
            foreach (var item in charset)
            {
                Console.Write(item + " ");
            }
        }
        private static void SinglyLinkedListApp01()
        {
            var linkedlist = new SinglyLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            // 3 2 1 O(1)

            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            // 3 2 1 4 5 O(n) 

            linkedlist.AddAfter(linkedlist.Head.Next, 32);
            linkedlist.AddAfter(linkedlist.Head.Next.Next, 33);
            // 3 2 32 33 1 4 5 O(n) 

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
