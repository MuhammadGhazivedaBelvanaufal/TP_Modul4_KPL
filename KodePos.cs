using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220011
{
    public class KodePos
    {
        public static Dictionary<string, int> tabelKodePos = new Dictionary<string, int>
    {
        {"Batununggal", 40266},
        {"Kujangsari", 40287},
        {"Mengger", 40267},
        {"Wates", 40256},
        {"Cijaura", 40287},
        {"Jatisari", 40286},
        {"Margasari", 40286},
        {"Sekejati", 40286},
        {"Kebonwaru", 40272},
        {"Maleer", 40274},
        {"Samoja", 40273}
    };

        public int getKodePos(string kelurahan)
        {
            int kodePos;
            if (tabelKodePos.ContainsKey(kelurahan))
            {
                kodePos = tabelKodePos[kelurahan];
            }
            else
            {
                Console.Write($"Kode pos untuk kelurahan '{kelurahan}' tidak ditemukan. Masukkan kode pos: ");
                while (!int.TryParse(Console.ReadLine(), out kodePos))
                {
                    Console.Write("Input tidak valid. Masukkan angka untuk kode pos: ");
                }
                tabelKodePos[kelurahan] = kodePos;
            }
            return kodePos;
        }
    }
}
