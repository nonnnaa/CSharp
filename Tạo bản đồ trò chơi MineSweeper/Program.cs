using System;
using System.Collections.Generic;
using System.Text;

namespace mineText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] MineSweeper = {
                {"*", ".", ".", "."},
                {".", ".", ".", "."},
                {".", "*", ".", "."},
                {".", ".", ".", "."}
            };
            int n = MineSweeper.GetLength(0);
            int m = MineSweeper.GetLength(1);

            int[] dx = new int[8] 
            {
                -1, -1, -1, 0, 1, 1, 1, 0
            };
            int[] dy = new int[8] 
            {
                -1, 0, 1, 1, 1, 0, -1, -1
            };
            string[,] ans = new string[n,m];
            for(int i=0 ; i<n ; i++)
            {
                for(int j=0 ; j<m ; j++)
                {
                    if(MineSweeper[i,j] == "*")
                    {
                        ans[i,j] = "*";
                    }
                    else
                    {
                        int res = 0;
                        for(int z=0 ; z<8 ; z++)
                        {
                            int i1 = i + dx[z];
                            int j1 = j + dy[z];
                            if(i1 > -1 && i1 < n && j1 > -1 && j1 < m && MineSweeper[i1, j1] == "*")
                            {
                                res++;
                            }
                        }
                        ans[i,j] = res.ToString();
                    }

                }
            }
            for(int i=0 ; i<n ; i++)
            {
                for(int j=0 ; j<m ; j++)
                {
                    Console.Write(ans[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
