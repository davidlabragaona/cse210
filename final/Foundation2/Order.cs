using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public float GetTotalCost() {
        float total = 0.0f;
        foreach (Product product in _products) {
            total += product.GetTotalCost();
        }
        if (_customer.IsInUSA()) {
            total += 5;
        }
        else {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel() {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (Product product in _products) {
            stringBuilder.AppendLine($"{product.GetName()}({product.GetProductID()})");
        }
        return stringBuilder.ToString();
    }

    public string GetShippingLabel() {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddressString()}";

    }
}