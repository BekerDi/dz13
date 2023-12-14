using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    public class Refl
    {
        static void Main(string[] args)
        {
            Refl refl = new Refl();
            Console.WriteLine(string.Join(", ", GetAllMethodNames(refl)));
        }

        public string Output()
        {
            return "тестовый результат";
        }

        public int AddInts(int i1, int i2)
        {
            return i1 + i2;
        }

        public static string[] GetAllMethodNames(object obj)
        {
            Type type = obj.GetType();
            MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            string[] methodNames = new string[methodInfos.Length];
            for (int i = 0; i < methodInfos.Length; i++)
            {
                methodNames[i] = methodInfos[i].Name;
            }

            return methodNames;
        }
    }
}
