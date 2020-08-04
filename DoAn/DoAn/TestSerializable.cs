using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class TestSerializable<T>
    {
        public static void Serializable(string path, LinkedList<T> data)
        {
            if (!File.Exists(path))
            {
                File.Open(path, FileMode.Create);
            }
            else
            {
                using (Stream s = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter f = new BinaryFormatter();

                    f.Serialize(s, data);
                }
            }
        }
        public static LinkedList<T> Deserializable(string path)
        {
            LinkedList<T> l = new LinkedList<T>();
            if (!File.Exists(path))
            {
                File.Open(path, FileMode.Create);
            }
            else
            {
                using (Stream s = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter f = new BinaryFormatter();

                    l = (LinkedList<T>)f.Deserialize(s);
                }
            }
            return l;
        }
    }
}
