namespace TP3;

public class Classe
{
    private List<person> eleves;
    private string name;
    private string level;
    private string school;

    public List<person> Eleves
    {
        get => eleves;
        set => eleves = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Level
    {
        get => level;
        set => level = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string School
    {
        get => school;
        set => school = value ?? throw new ArgumentNullException(nameof(value));
    }
}