public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUsaAddress()
    {
        if (_country == "USA")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string ToStringAddress()
    {
        string addressString = $"   {_street}\n   {_city}, {_state}\n   {_country}";
        return addressString;
    }
}