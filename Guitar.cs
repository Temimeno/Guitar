public class Guitar{
    private string serialNumber;
    private double price;
    private string builder;
    private string model;
    private string wood;

    public Guitar(string serialNumber, double price, string builder, string model, string wood) {
        this.serialNumber = serialNumber;
        this.price = price;
        this.builder = builder;
        this.model = model;
        this.wood = wood;
    }

    public string GetSerialNumber() {

        return this.serialNumber;
    }

    public double GetPrice() {

        return this.price;
    }

    public string GetModel() {
        return this.model;

    }

    public string GetBuilder() {

        return this.builder;
    }

    public string GetWood() {
        
        return this.wood;
    }
}