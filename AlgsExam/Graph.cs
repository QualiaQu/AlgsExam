namespace AlgsExam;

public static class Graph
{
    public static void Obhod()
    {
        // int[][] graph = new int[8][];
        // graph[0] = new[] { 0, 1, 1, 1, 1, 0, 0, 1};
        // graph[1] = new[] { 1, 0, 0, 0, 0, 0, 0, 0};
        // graph[2] = new[] { 1, 0, 0, 0, 0, 0, 0, 1};
        // graph[3] = new[] { 1, 0, 0, 0, 0, 0, 0, 0};
        // graph[4] = new[] { 1, 0, 0, 0, 0, 1, 0, 0};
        // graph[5] = new[] { 0, 0, 0, 0, 1, 0, 1, 0};
        // graph[6] = new[] { 0, 0, 0, 0, 0, 1, 0, 1};
        // graph[7] = new[] { 1, 0, 1, 0, 0, 0, 1, 0};
        
        int[][] graph = new int[7][];
        graph[0] = new[] { 0, 1, 1, 0, 0, 0, 1};
        graph[1] = new[] { 1, 0, 1, 1, 0, 0, 0};
        graph[2] = new[] { 1, 1, 0, 0, 0, 0, 0};
        graph[3] = new[] { 0, 1, 0, 0, 1, 0, 0};
        graph[4] = new[] { 0, 0, 0, 1, 0, 1, 0};
        graph[5] = new[] { 0, 0, 0, 0, 1, 0, 1};
        graph[6] = new[] { 1, 0, 0, 0, 0, 1, 0};
        
        int[] nodes = new int[graph[1].Length];
        for (int i = 0; i < nodes.Length; i++)
            nodes[i] = 0;
        
        Stack<int> queue = new Stack<int>();
        queue.Push(0);
        while (queue.Count != 0)
        {
            int node = queue.Pop();
            nodes[node] = 2;
            for (int i = 0; i < nodes.Length; i++)
            {
                if (graph[node][i] == 1 && nodes[i] == 0)
                {
                    queue.Push(i);
                    nodes[i] = 1;
                }
            }

            Console.WriteLine(node);
        }
    }

    public static List<string> GetLinks(int[][] graph)
    {
        var result = new List<string>();
        for (var i = 0; i < graph.Length; i++)
        {
            string link = i + "-";

            for (var j = 0; j < graph[i].Length; j++)
            {
                if (graph[i][j] == 1)
                {
                    result.Add(link + j);
                }
            }
        }

        return result;
    }
}

