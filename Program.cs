using tpmodul4_1302220011;

internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        int kodePosKelurahan = kodePos.getKodePos(kelurahan);
        Console.WriteLine($"Kode pos untuk kelurahan {kelurahan} adalah {kodePosKelurahan}");

        // Memanggil seluruh isi tabel kode pos
        Console.WriteLine("\nDaftar Kode Pos:");
        foreach (var item in KodePos.tabelKodePos)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
    }
}