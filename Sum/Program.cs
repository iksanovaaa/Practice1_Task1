using System;
using System.IO;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte.TryParse(File.ReadAllText("INPUT.TXT"), out byte n);
            if (n == 1) File.WriteAllText("OUTPUT.TXT", "45");
            else if (n == 2) File.WriteAllText("OUTPUT.TXT", "4905");
            else
            {
                File.WriteAllText("OUTPUT.TXT", "49490");
                for (int i = 1; i < n - 1; i += 2)
                {
                    File.WriteAllText("OUTPUT.TXT", File.ReadAllText("OUTPUT.TXT").Replace("90", "999000"));
                }
                if (n % 2 == 0) File.WriteAllText("OUTPUT.TXT", File.ReadAllText("OUTPUT.TXT").Replace("990", "55"));
                else File.WriteAllText("OUTPUT.TXT", File.ReadAllText("OUTPUT.TXT").Replace("99900", "55"));
            }

        }
    }
}

