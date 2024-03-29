public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA() {
        if (_country.ToLower() == "usa" || _country.ToLower() == "us" || _country.ToLower() == "united states of america")
            return true;
        return false;
    }

    public string GetAddressString() {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}