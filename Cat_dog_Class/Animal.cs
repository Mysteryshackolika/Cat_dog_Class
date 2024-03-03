

namespace Cat_dog_Class;
abstract internal class Animal
{
    private string nickname;
    private int age;
    private int price;
    private string gender;
    private int energy;
    public Animal()
    {
        Nickname = "Nick";
        Gender = "Male";
        Age = 1;
        Price = 11;

    }

    public Animal(int age, int price, string nickname, string gender)

    {
        Nickname = nickname;
        Gender = gender;
        Age = age;
        Price = price;
    }

    public string Nickname
    {
        get { return nickname; }
        set
        {
            if (value.Length > 3)
                nickname = value;
        }
    }

    public int Energy
    {
        get { return energy; }
        set
        {
            if (value > 0 && value<15)
                energy = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0 && value < 15)
                age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            if (value == "Male" || value == "Female")
                gender = value;
        }
    }
    public int Price
    {
        get { return price; }
        set
        {
            if (value > 10 && value < 100)
                price = value;
        }
    }
    public void eat()
    {
        if (energy < 15)
            energy++;
        else
            Console.WriteLine("Maxsimum energy");
    }
    public void sleep()
    {
        if (energy < 15)
            energy++;
        else
            Console.WriteLine("Maxsimum energy");
    }
    public void play()
    {
        if (!(energy <= 0))
        {
            energy--;
        }
        else
            Console.WriteLine("Minimum energy");
    }
}

