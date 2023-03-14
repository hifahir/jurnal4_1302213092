// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

public class KodeBuah
{
    public enum Buah { Apel, Aprikot, Alukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }
    public static String getKodeBuah(Buah fruit)
    {
        String[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "i00", "j00", "K00", "L00", "M00", "N00", "O00" };
        return kodeBuah[(int)fruit];
    }
}

public class PosisiKarakterGame
{
    enum state { Berdiri, Jongkok, Terbang };

    public static void Main()
    {
        string getKodeBuah = KodeBuah.getKodeBuah(KodeBuah.Buah.Apel);
        Console.WriteLine(getKodeBuah);
        Console.WriteLine();

        state state1 = state.Berdiri;
        string[] kondisi = { "Posisi Stanby", "Posisi Landing", "Posisi Take Off"  };
        while (state1 != null)
        {
            Console.WriteLine(kondisi[(int)state1]);
            Console.WriteLine();
            Console.WriteLine("Masukkan Perintah: ");

            String Perintah = Console.ReadLine();
            switch (state1)
            {
                case state.Terbang:
                    if(Perintah == "Jongkok")
                    {
                        state1 = state.Jongkok;
                    }
                    else if(Perintah == "Berdiri")
                    {
                        state1 = state.Berdiri;
                    }
                    else
                    {
                        state1 = state.Terbang;
                        Console.WriteLine("Perintah Salah");
                    }
                    Console.WriteLine();
                    break;

                case state.Berdiri:
                    if(Perintah == "jongkok")
                    {
                        state1 = state.Jongkok;
                    }
                    else if(Perintah == "Terbang")
                    {
                        state1 = state.Terbang;
                    }
                    else
                    {
                        state1 = state.Berdiri;
                        Console.WriteLine("Perintah Salah");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;

                case state.Jongkok:
                    if(Perintah == "Terbang")
                    {
                        state1 = state.Terbang;
                    }
                    else if(Perintah == "Berdiri")
                    {
                        state1 = state.Berdiri;
                    }
                    else
                    {
                        state1 = state.Jongkok;
                        Console.WriteLine("Perintah Salah");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}
