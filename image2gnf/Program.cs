using GFDLibrary.Textures.DDS;
using GFDLibrary.Textures.GNF;
using System;
using System.Drawing;
using System.IO;

namespace image2gnf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stream tmp = File.OpenWrite(args[1]);
            Console.WriteLine("start");
            Stream meme = File.OpenRead(args[0]);
            if (DDSExport.CanImportCore(meme) == true)
            {
                Console.WriteLine("Open DDS");
                DDSStream DDSFILE = new DDSStream(meme);
                Console.WriteLine("Decode DDS as Bitmap");
                Bitmap DecodeIMG = DDSExport.GetBitmapCore(DDSFILE);
                Console.WriteLine("Open Bitmap as GNFTexture");
                GNFTexture momo = new GNFTexture(DecodeIMG);
                Console.WriteLine("Write GNFTexture");
                GNFexport.ExportCore(momo, tmp);
            }
            tmp.Close();

            // validate GNF
            Stream tmp1 = File.OpenRead(args[1]);
            if (GNFexport.CanImportCore(tmp1))
            {
                Console.WriteLine("GNF es valido");
            }
        }
    }
}
