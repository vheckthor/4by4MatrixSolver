using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4by4Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var arr1 = new int[,] { 
                     {3,0,2,6 },
                     {2,4,0,3 },
                     {5,2,1,1 },
                     {7,6,3,4 }
            };

            var res = DeterminantVal(arr1);
            Console.WriteLine(res);
            Console.ReadKey();
        }


        static int DeterminantVal(int[,] input)
        {
             var arrlen = new List<List<int>>();

            for(var x=0; x< 4; x++)
            {
                var create = new List<int>();
                for (var y = 0; y < 4; y++)
                    create.Add(input[x, y] );

                arrlen.Add(create);
            }

            var listPut = arrlen;

            var counter = listPut[0].Count;
            var forward = 0;
            var agg = new List<int>();

            while (forward < counter)
            {
                var curr = new List<int>();
                var copy = del.DeepClone(listPut);
                var p = new del();
                var ans =  p.deleter(copy, forward);

                //convert back to matrix
                var resolved = AnotherMethod(ans.Item1);

                agg.Add(ans.Item2 * resolved);
                forward++;
            }

            return agg.Sum();


        }


        public static int by3Method(List<List<int>> ans)
        {
            
            var matrixedArray = del.ListtoArray(ans);
            var by3resolver = del.by3Matrix(matrixedArray);

            return by3resolver;
        }


        public static int AnotherMethod(List<List<int>> ans)
        {
            
            var currentArray = new List<int>();
            var ford = 0;
            while (ford < ans.Count)
            {
                List<List<int>> sac = del.DeepClone(ans); //ans.Item1;
                ;
                var delete= new del();
                var sol = delete.deleter(sac, ford);
                var fin = sol.Item2 * ((sol.Item1[0][0] * sol.Item1[1][1]) - (sol.Item1[0][1] * sol.Item1[1][0]));
                currentArray.Add(fin);
                ford++;
            }
            return currentArray.Sum();
        }


    }



    
}




