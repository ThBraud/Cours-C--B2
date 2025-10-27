namespace TP3;

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
        get => postalcode;
        set => postalcode = value;
    }

    public string City
    {
        get => city;
        set => city = value ?? throw new ArgumentNullException(nameof(value));
    }
}