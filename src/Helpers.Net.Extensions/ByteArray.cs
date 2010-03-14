using System;
using System.IO;
using System.Text;

namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts bytes to stream
        /// </summary>
        /// <param name="bytes">bytes to convert</param>
        /// <returns>Stream of converted bytes</returns>
        public static Stream ToStream(this byte[] bytes)
        {//todo: test
            return new MemoryStream(bytes);
        }

        /// <summary>
        /// Converts stream to bytes
        /// </summary>
        /// <param name="stream">Stream to convert</param>
        /// <returns>bytes of converted stream</returns>
        public static byte[] ToBytes(this Stream stream)
        {//todo test
            var streamLength = Convert.ToInt32(stream.Length);
            var data = new byte[streamLength];

            stream.Read(data, 0, streamLength);
            stream.Close();

            return data;
        }

        public static string ToString(this byte[] bytes, Encoding encoding)
        {//todo test
            return encoding.GetString(bytes);
        }

        public static byte[] ToBytes(this string str, Encoding encoding)
        {//todo test
            return encoding.GetBytes(str);
        }

        public static Stream ToStream(this string str, Encoding encoding)
        {//todo test
            return str.ToBytes(encoding).ToStream();
        }
    }
}
