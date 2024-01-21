# Abstraction

## Definition

Abstraction is the process of simplifying complex ideas or objects. With abstraction we concentrate in specific characteristics and discard all other features that may not be important for the problem domain.

## Benefit

Abstraction is a key aspect in programming because it *hides* the complexity associated with an object and provides a more friendly interface to interact with. Another great aspect of abstraction we find in the Object Oriented paradigm where we model objects from the real world and concentrate on specific elements.

## Application

Computer Languages and Operating Systems are a way of abstracting functions into more friendly operations. Let's say that we want to create software that is executed in a vast range of devices, and moreover, we don't know all the possible hardware components that may be commercialized, but by defining simple operations that hide the complexity from the user it is not necessary to know the list of all possible devices existing in the world.

## Code Example
Let's abstract a Person for our problem Domain. We will concentrate on some characteristics that are needed in our system:

```
public class Person
{
    public string _name;
    public string _id;
    public string _contract_date;
    public DateTime _dateOfBirth;
    .
    .
    .
    public DateTime customerSince;

    public int CalculateAgeFromDOB() {
        DateTime today = DateTime.Today();
        return today.Year - _dateOfBirth.Year;
    }
}
```

