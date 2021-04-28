
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenProc
{
    public class ДочернийПроцесс

    {
        public static void Main()

        {
            try

            {

                // Получаем текущий процесс

                Process p = Process.GetCurrentProcess();

                // Получаем блок окружения текущего процесса

                var env = p.StartInfo.EnvironmentVariables;
                

                double xmax = 11;
                double xmin = 1;
                double y = 0;




                foreach (string key in env.Keys)

                {
                    //if ((key == "Выбранные функции") && (env[key] == "1 и 2"))
                    //{
                    //    for (double x = xmin; x < xmax; x++)
                    //    {
                    //        y = Math.Sin(x) * Math.Cos(x);

                    //        Console.WriteLine("Sin({0})*Сos({0}) = {1}", x, y);


                    //    }
                    //}

                    if ((key == "Выбранная функция") && (env[key] == "6"))
                    {

                        int i, f = 1, num;
                        num =Convert.ToInt32(env[key]);
                        for (double x = xmin; x < xmax; x++)
                        {
                            for (i = 1; i <= num; i++)
                                f = f * i;

                            Console.Write("The Factorial of {0} is: {1}\n", num, f);


                        }

                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }
    }


}