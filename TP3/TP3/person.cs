namespace TP3;
using TP3;
public class person
{
    private String firstname;

    private String lastname;
    
    private int birthdate;
    
    private Details adressDetails;

    private int taille;

    public int Taille
    {
        get => taille;
        set => taille = value;
    }

    public Details AdressDetails
    {
        get => adressDetails;
        set => adressDetails = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Firstname
    {
        get => firstname;
        set => firstname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Lastname
    {
        get => lastname;
        set => lastname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Birthdate
    {
        get => birthdate;
        set => birthdate = value;
    }
    
}