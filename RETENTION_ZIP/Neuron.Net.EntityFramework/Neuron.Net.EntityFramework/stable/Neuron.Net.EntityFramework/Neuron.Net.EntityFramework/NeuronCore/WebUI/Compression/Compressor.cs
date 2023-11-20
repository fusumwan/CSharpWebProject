using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;
//using System.IO.Compression;
using Ionic.Zlib;

namespace NEURON.WEB.UI.COMPRESSION
{
    public static class Compressor
    {

        public static byte[] Compress(byte[] data)
        {
            MemoryStream output = new MemoryStream();
            //FOR : using System.IO.Compression;
            //GZipStream gzip = new GZipStream(output,CompressionMode.Compress, true);

            //FOR : using Ionic.Zlib;
            GZipStream gzip = new GZipStream(output, CompressionMode.Compress, CompressionLevel.BestCompression, true);

            gzip.Write(data, 0, data.Length);
            gzip.Close();
            return output.ToArray();
        }

        public static byte[] Decompress(byte[] data)
        {
            MemoryStream input = new MemoryStream();
            input.Write(data, 0, data.Length);
            input.Position = 0;
            //GZipStream gzip = new GZipStream(input,CompressionMode.Decompress, true);
            GZipStream gzip = new GZipStream(input, CompressionMode.Decompress, CompressionLevel.BestSpeed);
            MemoryStream output = new MemoryStream();
            byte[] buff = new byte[64];
            int read = -1;
            read = gzip.Read(buff, 0, buff.Length);
            while (read > 0)
            {
                output.Write(buff, 0, read);
                read = gzip.Read(buff, 0, buff.Length);
            }
            gzip.Close();
            return output.ToArray();
        }
    }
}
