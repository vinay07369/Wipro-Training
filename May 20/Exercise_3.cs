using System;
using System.Collections.Generic;

public class Dijkstra
{
    private int V;
    private int[,] graph;

    public Dijkstra(int vertices)
    {
        V = vertices;
        graph = new int[V, V];
    }

    public void AddEdge(int source, int destination, int weight)
    {
        graph[source, destination] = weight;
    }

    private int MinDistance(int[] dist, bool[] sptSet)
    {
        int minVal = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (sptSet[v] == false && dist[v] <= minVal)
            {
                minVal = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    private List<int> GetPath(int[] parent, int j)
    {
        List<int> path = new List<int>();
        if (parent[j] == -1)
        {
            path.Add(j);
            return path;
        }

        path.AddRange(GetPath(parent, parent[j]));
        path.Add(j);
        return path;
    }

    public void FindShortestPaths(int src)
    {
        int[] dist = new int[V];
        bool[] sptSet = new bool[V];
        int[] parent = new int[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
            parent[i] = -1;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, sptSet);

            if (u == -1)
                break;

            sptSet[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!sptSet[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    parent[v] = u;
                }
            }
        }

        PrintSolution(dist, parent, src);
    }

    private void PrintSolution(int[] dist, int[] parent, int src)
    {
        Console.WriteLine($"Shortest distances from source node {src}:");
        for (int i = 0; i < V; i++)
        {
            Console.Write($"  Node {i}: Distance = ");
            if (dist[i] == int.MaxValue)
            {
                Console.Write("Infinity");
            }
            else
            {
                Console.Write(dist[i]);
            }

            Console.Write(", Path = ");
            List<int> path = GetPath(parent, i);
            Console.WriteLine(string.Join(" -> ", path));
        }
    }

    public static void Main(string[] args)
    {
        int numVertices = 5;
        Dijkstra djk = new Dijkstra(numVertices);

        djk.AddEdge(0, 1, 10);
        djk.AddEdge(0, 2, 3);
        djk.AddEdge(1, 2, 1);
        djk.AddEdge(1, 3, 2);
        djk.AddEdge(2, 1, 4);
        djk.AddEdge(2, 3, 8);
        djk.AddEdge(2, 4, 2);
        djk.AddEdge(3, 4, 5);

        int sourceNode = 0;
        djk.FindShortestPaths(sourceNode);

        Console.WriteLine("\n--- Testing with another source node (Node 3) ---");
        djk.FindShortestPaths(3);
    }
}
