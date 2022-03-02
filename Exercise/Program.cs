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

        bool[] visited = new bool[6];

        // 행렬(adj변수)을 이용한 DFS
        // 1) 우선 now부터 방문하고,
        // 2) now와 연결된 정점들을 하나씩 확인해서, 아직 미방문 상태라면 방문
        public void DFS(int now)
        {
            Console.WriteLine(now);
            visited[now] = true; // 1) 우선 now부터 방문하고,

            for (int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0) // 연결되어 있지 않으면 스킵
                    continue;

                if (visited[next]) // 이미 방문했으면 스킵
                    continue;

                DFS(next);
            }
        }

        // 리스트(adj2변수)을 이용한 DFS
        public void DFS2(int now)
        {
            Console.WriteLine(now);
            visited[now] = true; // 1) 우선 now부터 방문하고,
          
            foreach(int next in adj2[now])
            {
                if (visited[next]) // 이미 방문했으면 스킵
                    continue;

                DFS2(next);
            }
        }

        // 만약 노드가 끊어졌을때 모든 노드를 찾을 수 있는 함ㄹ
        public void SearchAll()
        {
            visited = new bool[6];
            for (int now = 0; now < 6; now++)
                if (visited[now] == false)
                    DFS(now);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph();
            graph.DFS2(3);
        }
    }
}

