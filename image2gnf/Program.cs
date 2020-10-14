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
            Console.WriteLine("Start:");
            Stream meme = File.OpenRead(args[0]);
            if (DDSExport.CanImportCore(meme) == true)
            {
                Console.WriteLine("Open DDS");
                DDSStream DDSFILE = new DDSStream(meme);
                Console.WriteLine("Swizzling");
                GNFTexture momo = new GNFTexture(DDSFILE);
                Console.WriteLine("Write GNFTexture");
                GNFexport.ExportCore(momo, tmp);
            }
            tmp.Close();

            // validate GNF
            Stream tmp1 = File.OpenRead(args[1]);
            if (GNFexport.CanImportCore(tmp1))
            {
                Console.WriteLine("GNF is valid");
            }
        }
    }
}
