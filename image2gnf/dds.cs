using GFDLibrary.IO.Common;
using GFDLibrary.Textures.DDS;
using System.Drawing;
using System.IO;
using System.Text;

namespace image2gnf
{
    internal class DDSExport
    {

        public static bool CanImportCore(Stream stream, string filename = null)
        {
            using (EndianBinaryReader reader = new EndianBinaryReader(stream, Encoding.Default, true, Endianness.LittleEndian))
            {
                int magic = reader.ReadInt32();
                bool isValid = magic == DDSHeader.MAGIC;
                reader.BaseStream.Position = 0;
                return isValid;
            }
        }
    }
}