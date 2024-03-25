using Solution.Books;
using Solution.ElectronicDevices;
using Solution.SportsEquipment;
using Solution.Vehicles;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Books
        BukuFiksi bukuFiksi = new BukuFiksi("Lord of the Rings", "J.R.R. Tolkien", "Fantasi");
        BukuPelajaran bukuPelajaran = new BukuPelajaran("Principles of Mathematics", "Bertrand Russell", "Matematika");

        Console.WriteLine($"Judul: {bukuFiksi.Judul}, Pengarang: {bukuFiksi.Pengarang}, Genre: {bukuFiksi.Genre}");
        Console.WriteLine($"Judul: {bukuPelajaran.Judul}, Pengarang: {bukuPelajaran.Pengarang}, Subjek: {bukuPelajaran.Subjek}");

        // Vehicles
        Mobil mobil = new Mobil("Toyota", "Camry", "Sedan");
        Motor motor = new Motor("Yamaha", "YZF-R1", "4 Stroke");

        Console.WriteLine($"Mobil: Merk - {mobil.Merk}, Model - {mobil.Model}, Tipe Bodi - {mobil.TipeBodi}");
        Console.WriteLine($"Motor: Merk - {motor.Merk}, Model - {motor.Model}, Tipe Mesin - {motor.TipeMesin}");

        // Electronic Devices
        FlagshipPhone flagship = new FlagshipPhone("BrandX", "ModelY", "Android", "LCD, RAM", "Camera Telephoto");
        BudgetPhone budget = new BudgetPhone("BrandZ", "ModelW", "Android", "LCD, Basic RAM", 299);

        Console.WriteLine("Flagship Phone:");
        flagship.TampilkanIdentitas();
        flagship.TampilkanFiturPremium();

        Console.WriteLine("\nBudget Phone:");
        budget.TampilkanIdentitas();
        budget.TampilkanFiturDasar();
        Console.WriteLine($"Harga: ${budget.Harga}");

        // SportsEquipment

        BolaProfesional bolaProfesional = new BolaProfesional("Bola", "Nike", "Sepakbola", "Kulit", true);
        BolaLatihan bolaLatihan = new BolaLatihan("Bola", "Adidas", "Basket", "Karet", 100);

        Console.WriteLine("Bola Profesional:");
        bolaProfesional.TampilkanInformasi();
        bolaProfesional.TampilkanStandar();

        Console.WriteLine("\nBola Latihan:");
        bolaLatihan.TampilkanInformasi();
        Console.WriteLine($"Harga: {bolaLatihan.Harga}");


        // Extras
    }
}
