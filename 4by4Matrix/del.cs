using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4by4Matrix
{
    partial class Program
    {
        class del
        {
           public (List<List<int>>,int) deleter(List<List<int>> value, int index)
           {
                
                var current = value[0][index];
                if(index % 2 != 0)
                {
                    current = current * -1;
                }
                value.RemoveAt(0);
                foreach(var x in value)
                {
                    x.RemoveAt(index);
                }

                return (value,current);
           }




            public static T DeepClone<T>(T obj)
            {
                using (var ms =new MemoryStream())
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(ms, obj);
                    ms.Position = 0;
                    return (T)formatter.Deserialize(ms);
                }
            }


            public static  int by3Matrix(int[,]val= default)
            {
                int i, j;
                int[,] arr1 = val;
                int det = 0;


                //Console.Write("\n\nCalculate the determinant of a 3 x 3 matrix :\n");
                //Console.Write("-------------------------------------------------\n");

                //Console.Write("Input elements in the matrix :\n");
                //for (i = 0; i < 3; i++)
                //{
                //    for (j = 0; j < 3; j++)
                //    {
                //        Console.Write("element - [{0}],[{1}] : ", i, j);
                //        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                //    }
                //}
                //Console.Write("The matrix is :\n");
                //for (i = 0; i < 3; i++)
                //{
                //    for (j = 0; j < 3; j++)
                //        Console.Write("{0}  ", arr1[i, j]);
                //    Console.Write("\n");
                //}

                for (i = 0; i < 3; i++)
                    det = det + (arr1[0, i] * (arr1[1, (i + 1) % 3] * arr1[2, (i + 2) % 3] - arr1[1, (i + 2) % 3] * arr1[2, (i + 1) % 3]));

                Console.Write("\nThe Determinant of the matrix is: {0}\n\n", det);
                return det;
            }



           public static int[,] ListtoArray(List<List<int>> array)
            {
                int i, j;
                int[,] arr1 = new int[array.Count, array[0].Count];
                for (i = 0; i < array.Count; i++)
                {
                    for (j = 0; j < array[0].Count; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = array[i][j];
                    }
                }

                return arr1;
            }


        }


    }



    
}




