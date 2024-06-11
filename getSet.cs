public class Person
{
    private int _age;

    // Getter (accessor)
    public int Age
    {
        get { return _age; }
    }

    // Setter (mutator)
    public void SetAge(int age)
    {
        if (age >= 0 && age <= 120) // Validating the age
        {
            _age = age;
        }
    }
}
