using GFDLibrary.IO.Common;
using GFDLibrary.Textures.GNF;
using System.IO;
using System.Text;

namespace image2gnf
{
    internal class GNFexport
    {
        public static bool CanImportCore(Stream stream, string filename = null)
        {
            using (EndianBinaryReader reader = new EndianBinaryReader(stream, Encoding.Default, true, Endianness.LittleEndian))
            {
                bool isValid = reader.ReadInt32() == GNFTexture.MAGIC;
                reader.BaseStream.Position = 0;
                return isValid;
            }
        }

        public static void ExportCore(GNFTexture obj, Stream stream, string filename = null)
        {
            obj.Save(stream);
        }
    }
}