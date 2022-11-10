using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    class Reversi
    {
        static void Main(string[] arguman)
        {
            Console.WriteLine("Bu oyun Reversi (Merhaba).");
            // While döngüsünü kapsülleme
            OyunTahtası oyun = new OyunTahtası();
            oyun.print();

            Tuple<int, int> move;
            int sıra, sutun;
            char onayla = 'N';