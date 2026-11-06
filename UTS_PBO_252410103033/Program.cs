using System.Runtime.CompilerServices;

interface IDapatDidistribusikan
{
    public void kirimPaket(int jumlah);
}

public class Sekolah : IDapatDidistribusikan
{

    public string idSekolah;
    public string namaSekolah;

    public int jumlahPaketDiterima;


    public Sekolah(string idSekolah, string namaSekolah, int JumlahPaketDiterima)
    {
        this.idSekolah = idSekolah;
        this.namaSekolah = namaSekolah;
        this.jumlahPaketDiterima = JumlahPaketDiterima;

    }



    void IDapatDidistribusikan.kirimPaket(int jumlah)
    {
        jumlahPaketDiterima += jumlah;
    }

    public void inpo()
    {
        Console.WriteLine($"idsekolah : {idSekolah} | nama sekolah : {namaSekolah} | jumlah paket yang diterima : {jumlahPaketDiterima} ");
    }

}

abstract class PaketMBG : IDapatDidistribusikan
{
    private string idPaket { get; set; }
    private string namaPaket { get; set; }
    private int stokDapur { get; set; }

    public abstract double HitungBiaya(int jumlah);

    void IDapatDidistribusikan.kirimPaket(int jumlah)
    {
        stokDapur -= jumlah;
    }

}

class PaketReguler : PaketMBG
{
    public string idPaket;
    public string namaPaket;
    public double harga = 15000;


    public override double HitungBiaya(int jumlah)
    {
        return jumlah * harga;
    }

}

class PaketKhusus : PaketMBG
{

    public double harga = 20000;

    public override double HitungBiaya(int jumlah)
    {
        return jumlah * harga;
    }

}




class Program
{
    static void Main(string[] args)
    {
        Sekolah smansa = new Sekolah("SM1", "SMA NEGERI 1 ", 20);
        smansa.inpo();


    }
}