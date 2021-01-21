using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.ToplamaYap(7899787, 1565456);

            dortIslem.ToplamaYap(6, 9);
        }
    }
}
