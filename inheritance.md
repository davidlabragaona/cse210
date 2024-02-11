# Inheritance

## Definition

Inheritance is the mechanism by which some classes receive attributes and methods from another class. Through inheritance it is possible to go from one general class, to very specific classes while sharing some behavior. This provides a hierarchy of classes. Base or supper classes define functionality that is later reused or extended through subclasses.

## Benefit

One important benefit of inheritance is code reuse. This promotes modularity, this is objects more compact, and reduces redundancy.

## Application

Let's say that we have a class named Person. We can define general attributes that describe a person. The name, an ID, the date of birth, and so on. A person can have multiple roles for a given software. Let's say that we have a system that is created to manage courses, students and professors for a college enrollment system. Later, we can define a student class and a professor class. Both classes will *inherit* from person, the base attributes while both will have specific new attributes or functionality.

## Code Example

Following the example from above, we provide the base class Person, and we define a Student class that inherits from Person:

```
public class Person
{
    private string _name;
    private DateTime _dateOfBirth;
    .
    .
    .
    public int CalculateAgeFromDOB() {
        DateTime today = DateTime.Today();
        return today.Year - _dateOfBirth.Year;
    }
}

public class Student : Person
{
    private string _id;
    .
    .
    .

    public string GetRegistrationID() {
        return _id;
    }
}

public class Program
{
    static void Main(string[] args) {
        Student student = new Student();
        int age = student.CalculateAgeFromDOB();
        string id = student.GetRegistrationID();
        .
        .
        .
    }
}
```

We can see the hierarchy between Student and Person, and how Student inherits some functionality from the base class Person.

