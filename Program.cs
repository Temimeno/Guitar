public class Program {
    public static Guitar[] initializeInventory() {
        Guitar[] guitars = {new Guitar("000001", 5000.52, "Nhong", "Sratocaster", "Alder"),
                            new Guitar("000002", 7412.52, "Jame", "Sratocaster", "Alder"),
                            new Guitar("000003", 3917.52, "Jo", "Sratocaster", "Alder"),
                            new Guitar("000004", 8254.52, "Ning", "Sratocaster", "Alder"),
                            new Guitar("000005", 1234.52, "Nut", "Sratocaster", "Alder")};
        return guitars;
    }

    static void printGuitarInfo(Guitar guitar) {
        Console.WriteLine("************************************");
        Console.WriteLine("guitar Serial Number: {0}", guitar.GetSerialNumber());
        Console.WriteLine("guitar Price: {0}", guitar.GetPrice());
        Console.WriteLine("guitar Builder: {0}", guitar.GetBuilder());
        Console.WriteLine("guitar Model: {0}", guitar.GetModel());
        Console.WriteLine("guitar Wood: {0}", guitar.GetWood());
        Console.WriteLine("************************************");
        Console.WriteLine();
    }
    public static void Main(string[] args) {

        Inventory inventory = new Inventory(initializeInventory());

        Guitar guitar = new Guitar("000001", 5000.52, "Nhong", "Sratocaster", "Alder");
        Guitar searchGuitar = inventory.Search(guitar);

        if (searchGuitar != null) {
            printGuitarInfo(searchGuitar);
        }
        else
            Console.WriteLine("Sorry. not found.");
    }
}