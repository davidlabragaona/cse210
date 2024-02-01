# Encapsulation

## Definition

Encapsulation means to enclose or as if in a capsule. In a way, we *hide* the details of our abstractions from the outside world.
When we worked with abstractions we modeled objects based on reality. We took the most relevant behavior and state from objects that we designed to understand our problem domain. Encapsulation provides an enhanced way of dealing with abstractions.

## Benefits

* As one of the benefits, encapsulation brings integrity. By hiding the internal state of objects, it is the responsability of the object to "regulate" or to modify its internal data, thus provising integrity. There are no external agents that could tamper the internals of the objects.

* Another benefit could be the responsability. When we hide internal aspects of a class or objects, we provide the necessary functions to the outside world to perform our actions. As external users, there is no need to know all the variables from an object.

* A third benefit could be maintainability. When there are needs for changes in our classes, modifications could be made to our design without affecting the code that other classes may use from our modified class.

## Application

In a classic example, we could imagine that we are designing a Bank Account class. Encapsulation ensures that our bank account is only accessible and can be modifierd through its defined methods, thus preventing unauthorized changes. We *close* the internals so that no unauthorized access or modification is not allowed.

## Code Example

In this basic example we focus on the age of a person; we don't define the whole class.
We define a private variable called _dateOfBirth. We use a function called getAge() to calculate the age comparing today's date and the private member _dateOfBirth. Other classes may consume the getAge() but the responsible to calculate is the Person Class.

```
public class Person
{
    private string _name;
    private DateTime _dateOfBirth;
    .
    .
    .
    public int getAge() {
        DateTime today = DateTime.Today();
        return today.Year - _dateOfBirth.Year;
    }
}
```
