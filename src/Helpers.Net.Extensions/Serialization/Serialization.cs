using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Helpers.Net.Extensions
{
    public static class Serialization
    {
        /// <summary>
        /// Serialize an object
        /// </summary>
        /// <param name="graph">Object to serialize.</param>
        /// <returns>Returns the serialized object.</returns>
        public static byte[] Serialize(object graph)
        {
            byte[] serializedData;
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, graph);
                serializedData = ms.ToArray();
            }
            return serializedData;
        }

        /// <summary>
        /// Deserializes serialized data.
        /// </summary>
        /// <param name="serializedData">Serialzied Data</param>
        /// <returns>Deserialized object</returns>
        public static object Deserialize(byte[] serializedData)
        {
            object graph = null;
            if (serializedData != null)
            {

                using (var ms = new MemoryStream())
                {
                    foreach (byte t in serializedData)
                        ms.WriteByte(t);
                    ms.Seek(0, SeekOrigin.Begin);
                    var formatter = new BinaryFormatter();
                    graph = formatter.Deserialize(ms);
                }
            }
            return graph;
        }

        /// <summary>
        /// Checks if object is serializable
        /// </summary>
        /// <typeparam name="T">Type of object to check</typeparam>
        /// <param name="obj">Object to check</param>
        /// <returns>Returns true if serializable, otherwise false</returns>
        public static bool IsSerializable<T>(T obj)
        {
            return obj is ISerializable ||
                   (Attribute.IsDefined(typeof(T), typeof(SerializableAttribute)));
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="graph">Object to serialize</param>
        /// <returns>Serialized data</returns>
        public static byte[] Serialize(this object graph)
        {
            return Serialization.Serialize(graph);
        }

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <param name="serializedData">Object to deserialize</param>
        /// <returns>Deserialized object</returns>
        public static object Deserialize(this byte[] serializedData)
        {
            return Serialization.Deserialize(serializedData);
        }

        /// <summary>
        /// Checks if object is serializable
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="obj">Object to check for serialization</param>
        /// <returns>Returns true if object is serializable</returns>
        public static bool IsSerializable<T>(this T obj)
        {
            return Serialization.IsSerializable(obj);
        }
    }
}
