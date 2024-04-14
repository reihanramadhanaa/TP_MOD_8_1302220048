using tpmodull8_1302220048;

internal class Program
{
    private static void Main(string[] args)
    {
        MainCovidConfig appConfig = new MainCovidConfig();

        appConfig.ubahSatuan();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {appConfig.dataConfig.satuan_suhu} : ");
        double suhuBadan = Convert.ToDouble(Console.ReadLine());

        Console.Write($"Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? : ");
        int hariTerakhirDemam = int.Parse(Console.ReadLine());
        if (hariTerakhirDemam <= appConfig.dataConfig.batas_hari_demam)
        {
            if (appConfig.dataConfig.satuan_suhu == "celcius")
            {
                if (suhuBadan >= 36.5 && suhuBadan <= 37.5)
                {
                    Console.WriteLine(appConfig.dataConfig.pesan_diterima);
                }
                else
                {
                    Console.WriteLine(appConfig.dataConfig.pesan_ditolak);
                }
            }
            else if (appConfig.dataConfig.satuan_suhu == "fahrenheit")
            {
                if (suhuBadan >= 97.7 && suhuBadan <= 99.5)
                {
                    Console.WriteLine(appConfig.dataConfig.pesan_diterima);
                }
                else
                {
                    Console.WriteLine(appConfig.dataConfig.pesan_ditolak);
                }
            }
            else
            {
                Console.WriteLine("Unit suhu tidak valid.");
            }
        }
        else
        {
            Console.WriteLine(appConfig.dataConfig.pesan_ditolak);
        }
    }
}

