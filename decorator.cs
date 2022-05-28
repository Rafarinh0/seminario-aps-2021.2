public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }

public class HondaCity : IVehicle
  {
    public string Make
    {
      get { return "HondaCity"; }
    }
    public string Model
    {
      get { return "CNG"; }
    }
    public double Price
    {
      get { return 1000000; }
    }
  }

public abstract class VehicleDecorator : IVehicle
  {
    private IVehicle _vehicle;
    public VehicleDecorator(IVehicle vehicle)
      {
        _vehicle = vehicle;
      }
    public string Make
      {
        get { return _vehicle.Make; }
      }
    public string Model
      {
        get { return _vehicle.Model; }
      }
    public double Price
      {
        get { return _vehicle.Price; }
      }
  }

public class SpecialOffer : VehicleDecorator
  {
    public SpecialOffer(IVehicle vehicle) : base(vehicle) { }
    public int DiscountPercentage { get; set; }
    public string Offer { get; set; }
    public double Price
    {
      get
      {
        double price = base.Price;
        int percentage = 100 - DiscountPercentage;
        return Math.Round((price * percentage) / 100, 2);
      }
    }
  }

class Program
  {
    static void Main(string[] args)
    {
      HondaCity car = new HondaCity();
      Console.WriteLine($"Honda City preço : {car.Price}");
      
      SpecialOffer offer = new SpecialOffer(car);
      offer.DiscountPercentage = 25;
      offer.Offer = "25 % de desconto";
      Console.WriteLine($"{offer.Price} @ Honda preço especial : {offer.Offer} ");
      Console.ReadKey();
    }
  }