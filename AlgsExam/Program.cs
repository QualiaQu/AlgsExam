using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Threading.Channels;
using AlgsExam;

// var array = new[] {0, 1, 17, 78, 6, 10, 14, 4};
// PrintArray(array);
// Sort(array, 0, array.Length - 1, 78);
// PrintArray(array);

Obhod();

static void Obhod()
{
    int[][] graph = new int[6][];
    graph[0] = new[] {0,1,1,0,0,0};
    graph[1] = new[] {1,0,1,0,0,0};
    graph[2] = new[] {1,1,0,1,0,0};
    graph[3] = new[] {0,0,1,0,1,1};
    graph[4] = new[] {0,0,0,1,0,0};
    graph[5] = new[] {0,0,0,1,0,0};
    int[] nodes = new int[graph[0].Length];
    for (int i = 0; i < graph[0].Length; i++)
    {
        nodes[i] = 0;
    }

    Stack<int> stack = new Stack<int>();
    stack.Push(0);
    while (stack.Count != 0)
    {
        var node = stack.Pop();
        nodes[node] = 2;
        for (int i = 0; i < nodes.Length; i++)
        {
            if (graph[node][i] == 1 && nodes[i] == 0)
            {
                stack.Push(i);
                nodes[i] = 1;
            }
        }

        Console.WriteLine(node);
    }
}

static void Sort(int[] arr, int start, int end, int value)
{
    
}

static int Partition(int[] arr, int start, int end)
{
    return 0;
}


static void Swap(int[] arr, int first, int second)
{
    (arr[first], arr[second]) = (arr[second], arr[first]);
}



























static void PrintArray(int[] array)
{
    foreach (var elem in array)
    {
        Console.Write(elem + " ");
    }

    Console.WriteLine();
}