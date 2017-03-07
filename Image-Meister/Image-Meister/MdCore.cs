﻿using System.IO;
using System.Xml.Serialization;



namespace Image_Meister
{

    internal class MdCore
    {

        public static void Serialize<T>(T obj, string path)
        {
            if (Directory.Exists(Path.GetDirectoryName(path)))
            {
                //do nothing
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            var sw = new StreamWriter(path, false);
            var ser = new XmlSerializer(typeof(T));
            ser.Serialize(sw, obj);
            sw.Close();
        }

        public static T Deserialize<T>(string path)
        {

            var sr = new StreamReader(path);
            var ser = new XmlSerializer(typeof(T));
            var output = (T)ser.Deserialize(sr);

            sr.Close();
            return output;
        }

    }
}
