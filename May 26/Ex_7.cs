using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM26
{
    abstract class CompressionStrategy
    {
        public abstract void Compress(string inputPath, string outputPath);
    }
    class ZipCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}' using ZIP format.");
            // Simulated compression logic...
        }
    }

    class RarCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}' using RAR format.");
            // Simulated compression logic...
        }
    }
    class Compressor
    {
        private CompressionStrategy _strategy;

        public Compressor(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CompressFile(string inputPath, string outputPath)
        {
            _strategy.Compress(inputPath, outputPath);
        }
    }
    class Program
    {
        static void Main()
        {
            Compressor compressor = new Compressor(new ZipCompression());

            // Compress with ZIP
            compressor.CompressFile("report.docx", "report.zip");

            // Switch to RAR at runtime
            compressor.SetStrategy(new RarCompression());
            compressor.CompressFile("report.docx", "report.rar");
        }
    }
}