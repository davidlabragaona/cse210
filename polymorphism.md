# Polymorphism

## Definition

Polymorphism, as its name states *Poly* = multiple and *morphism* form, is the ability to take on many forms, meaning that an object can have multiple behaviors based on the context. To accomplish this, polymorphism uses method overriding. This means that subclasses may override or re-define functionality from supperclasses. The method keeps the same name, but the behavior changes.

## Benefit

The main advantage with Polymorphism is that we can create objects that know how to behave depending on the context where we create them. 


## Application

For a moment let's imagine that we are writing a program to keep track of our refrigerator food supply. We define a base class called RefrigeratorItem. Then we derive RefrigeratorItem into FoodItem, BeverageItem and finally MedicationItem. Each of these classes will have their own properties. We will use the overridden Display method to access the information for each item.


## Code Example

```
public class RefrigeratorItem
{
    private string _name;
    public RefrigeratorItem(string name) {
        _name = name;
    }

    public virtual void Display() {
        Console.WriteLine($"Item: {Name}");
    }
}
```

```
public class FoodItem : RefrigeratorItem
{
    private float _weight;
    public FoodItem(string name, float weight) : base (name) {
        _weight = weight;
    }

    public override void Display() {
        Console.WriteLine($"Food: {Name}");
    }
}
```

```
public class BeverageItem : RefrigeratorItem
{
    private float _volume;
    public BeverageItem(string name, float volume) : base (name) {
        _volume = volume_;
    }

    public override void Display() {
        Console.WriteLine($"Beverage: {Name}");
    }
}
```

```
public class MedicationItem : RefrigeratorItem
{
    private DateTime _expiration;
    public MedicationItem(string name, DateTime expiration) : base (name) {
        _expiration = expiration;
    }

    public override void Display()
    {
        Console.WriteLine($"Medication: {Name}");
    }
}
```

```
class Program
{
    static void Main(string[] args)
    {
        List<RefrigeratorItem> refrigeratorItems = new List<RefrigeratorItem>();

        FoodItem foodItem = new FoodItem("Apple", 60);
        refrigeratorItems.Add(foodItem);

        BeverageItem beverageItem = new BeverageItem("Water", 90)
        refrigeratorItems.Add(beverageItem);

        MedicationItem medicationItem = new MedicationItem("Aspirin", "2026-01-01");
        refrigeratorItems.Add(medicationItem);

        foreach (RefrigeratorItem item in refrigeratorItems)
        {
            item.Display();
        }
    }
}
```

In the example above, we have derived 3 classes from our base class. Each of them will redefine the Display behavior.