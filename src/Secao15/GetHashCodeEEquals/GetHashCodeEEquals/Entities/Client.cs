namespace GetHashCodeEEquals.Entities;
internal class Client
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Client()
    {

    }

    public Client(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Client))
        {
            return false;
        }
        Client client = (Client)obj;
        return Email.Equals(client.Email);
    }

    public override int GetHashCode()
    {
        return Email.GetHashCode();
    }
}
