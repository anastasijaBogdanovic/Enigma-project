using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class XTEA
    {
        uint keyBits = 64;

        public string startXTEAEncrypt(string data, string key)
        {
            byte[] dataBytes = Encoding.Unicode.GetBytes(data);
            SHA256 sha256 = SHA256.Create();
            byte[] keyBuffer = sha256.ComputeHash(Encoding.ASCII.GetBytes(key));
            uint[] blockBuffer = new uint[2];
            byte[] result = new byte[(dataBytes.Length + 7) / 8 * 8];
            Array.Copy(dataBytes, 0, result, 0, dataBytes.Length);

            using (MemoryStream stream = new MemoryStream(result))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    for (var i = 0; i < result.Length; i += 8)
                    {
                        blockBuffer[0] = BitConverter.ToUInt32(result, i);
                        blockBuffer[1] = BitConverter.ToUInt32(result, i + 4);

                        uint v0 = blockBuffer[0], v1 = blockBuffer[1], sum = 0, delta = 0x9E3779B9;
                        for (uint j = 0; j < keyBits; j++)
                        {
                            v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + keyBuffer[sum & 3]);
                            sum += delta;
                            v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + keyBuffer[(sum >> 11) & 3]);
                        }
                        blockBuffer[0] = v0;
                        blockBuffer[1] = v1;
                        writer.Write(blockBuffer[0]);
                        writer.Write(blockBuffer[1]);
                    }
                }
            }
            return Convert.ToBase64String(result);
        }

        public string startXTEADecrypt(string data, string key)
        {
            byte[] dataBytes = Convert.FromBase64String(data);
            SHA256 sha256 = SHA256.Create();
            byte[] keyBuffer = sha256.ComputeHash(Encoding.ASCII.GetBytes(key));
            uint[] blockBuffer = new uint[2];
            byte[] buffer = new byte[dataBytes.Length];
            Array.Copy(dataBytes, buffer, dataBytes.Length);

            using (MemoryStream stream = new MemoryStream(buffer))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    for (var i = 0; i < buffer.Length; i += 8)
                    {
                        blockBuffer[0] = BitConverter.ToUInt32(buffer, i);
                        blockBuffer[1] = BitConverter.ToUInt32(buffer, i + 4);

                        uint v0 = blockBuffer[0], v1 = blockBuffer[1], delta = 0x9E3779B9, sum = delta * keyBits;

                        for (uint j = 0; j < keyBits; j++)
                        {
                            v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + keyBuffer[(sum >> 11) & 3]);
                            sum -= delta;
                            v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + keyBuffer[sum & 3]);
                        }
                        blockBuffer[0] = v0;
                        blockBuffer[1] = v1;
                        writer.Write(blockBuffer[0]);
                        writer.Write(blockBuffer[1]);
                    }
                }
            }
            return Encoding.Unicode.GetString(buffer);
        }
    }
}
