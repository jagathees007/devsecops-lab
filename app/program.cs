using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Graph definition (Adjacency List)
        var graph = new Dictionary<string, List<string>>
        {
            ["A"] = new List<string> { "B", "C" },
            ["B"] = new List<string> { "D" },
            ["C"] = new List<string> { "D", "E" },
            ["D"] = new List<string> { "E" },
            ["E"] = new List<string>()
        };

        string start = "A";
        string end = "E";

        var path = ShortestPath(graph, start, end);

        if (path.Count > 0)
            Console.WriteLine("Shortest Path: " + string.Join(" -> ", path));
        else
            Console.WriteLine("No path found");
    }

    static List<string> ShortestPath(
        Dictionary<string, List<string>> graph,
        string start,
        string end)
    {
        var queue = new Queue<string>();
        var visited = new HashSet<string>();
        var parent = new Dictionary<string, string>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current == end)
                break;

            foreach (var neighbor in graph[current])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    parent[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Reconstruct path
        var path = new List<string>();
        if (!visited.Contains(end))
            return path;

        for (var node = end; node != null; node = parent.GetValueOrDefault(node))
            path.Add(node);

        path.Reverse();
        return path;
    }
}

