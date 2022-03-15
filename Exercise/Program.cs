using System;
using System.Collections.Generic;

namespace Exercise
{

    class Graph
    {

        int[,] adj = new int[6, 6]
        {
            {0,1,0,1,0,0 }, // 1번 노드
            {1,0,1,1,0,0 }, // 2번 노드
            {0,1,0,0,0,0 }, // 3번 노드
            {1,1,0,0,1,0 }, // 4번 노드
            {0,0,0,1,0,1 }, // 5번 노드
            {0,0,0,0,1,0 }  // 6번 노드
        };

        List<int>[] adj2 = new List<int>[]
        {
            new List<int>() { 1, 3 }, // 1번 노드
            new List<int>() { 0, 2, 3 }, // 1번 노드
            new List<int>() { 1 }, // 1번 노드
            new List<int>() { 0, 1, 4 }, // 1번 노드
            new List<int>() { 3, 5 }, // 1번 노드
            new List<int>() { 4 } // 1번 노드
        };

        public void BFS(int start)
        {
            bool[] found = new bool[6];
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            found[start] = true;

            while(q.Count > 0)
            {
                int now = q.Dequeue();
                Console.WriteLine(now);

                for(int next = 0; next < 6; next++)
                {
                    if (adj[now, next] == 0) // 인접하지 않았으면 스킵
                        continue;
                    if (found[next]) // 이미 발견한 애라면 스킵
                        continue;

                    q.Enqueue(next);
                    found[next] = true;
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph();
            graph.BFS(0);
        }
    }
}

