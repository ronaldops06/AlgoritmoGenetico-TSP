using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoTSP.AGClass
{
    public static class Utils
    {
        public static List<int> RandomNumbers(int start, int end)
        {
            List<int> numbers = new List<int>();
            for(int i = start; i < end; i++)
            {
                numbers.Add(i);
            }
            
            // Embaralhar a lista
            for(int i = 0; i < numbers.Count; i++)
            {
                int a = ConfigurationGA.random.Next(numbers.Count);
                int temp = numbers[i];
                numbers[i] = numbers[a];
                numbers[a] = temp;
            }

            return numbers.GetRange(0, end);
        }

        // Deep clone
        public static T DeepClone<T>(this T a)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
