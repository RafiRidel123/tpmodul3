using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD3
{
    internal class KodePos
    {
        public enum kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        };

        public KodePos()
        {
        }

        public static int GetKodePos(kelurahan inputKelurahan)
        {
            int[] arrayKodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

            return arrayKodePos[(int) inputKelurahan];
        }
    }
}
