using System.Reflection.Emit;

namespace TP2;

public class Details
{
    private String street;
    private int postalcode;
    private String city;


    public Details(string street, int postalcode, string city)
    {
        this.street = street;
        this.postalcode = postalcode;
        this.city = city;
    }


    public string Street
    {
        get => street;
        set => street = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Postalcode
    {
        get => Postalcode;
        set => Postalcode = value;
    }

    public string City
    {
        get => City;
        set => City = value ?? throw new ArgumentNullException(nameof(value));
    }
}