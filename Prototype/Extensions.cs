using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
    public static class Extensions
    {
        public static T DeepCopy<T>(this T self)
        {
            using (var stream = new MemoryStream()) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                object deepCopy = formatter.Deserialize(stream);
                return (T)deepCopy;
            }
        }
    }
}
