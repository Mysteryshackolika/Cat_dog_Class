using Cat_dog_Class;
Pet_Shop pet_Shop = new Pet_Shop();
bool ischeck = false;
do
{
    Console.Clear();

    Console.WriteLine(@"                   
                    1==> Heyvan elave edin
                    2==> Ad elave edin
                    3==> Secilen heyvanla oynayin
                    4==> Heyvani yatizdirin
                    5==> Heyvani yemliyin
                    6==> Exit
");
    string secim;
    Console.Write("Menudan secim edin:");
    secim = Console.ReadLine();
    Console.Clear();
    switch (secim)
    {
        case "1":
            Console.WriteLine(@"                    
                    1==> Bird 
                    2==> Dog
                    3==> Cat
                    4==> Fish
");
            string choice;
            Console.Write("Heyvani secin: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pet_Shop.birds.Add(new Bird());
                    Console.WriteLine("Bird Uqurla elave edildi");
                    break;
                case "2":
                    pet_Shop.dogs.Add(new Dog());
                    Console.WriteLine("Dog Uqurla elave edildi");
                    break;
                case "3":
                    pet_Shop.cats.Add(new Cat());
                    Console.WriteLine("Cat Uqurla elave edildi");
                    break;
                case "4":
                    pet_Shop.fishs.Add(new Fish());
                    Console.WriteLine("Fish Uqurla elave edildi");
                    break;
                default:
                    Console.WriteLine("Sehv secim");
                    break;
            }
            break;
        case "2":
            Console.WriteLine(@"                    
                    1==> Bird 
                    2==> Dog
                    3==> Cat
                    4==> Fish
");
            string choice_;
            Console.Write("Heyvani secin: ");
            choice_ = Console.ReadLine();
            switch (choice_)
            {
                case "1":
                    Console.Write("Bird adi daxil edin:");
                    string bırdname = Console.ReadLine();
                    Bird bird = new Bird();
                    bird.Nickname = bırdname;
                    pet_Shop.birds.Add(bird);
                    Console.WriteLine($"{pet_Shop.birds.Last().Nickname} adi uqurla elave edildi");
                    break;
                case "2":
                    Console.Write("Dog adi daxil edin:");
                    string dogname = Console.ReadLine();
                    Dog dog = new Dog();
                    dog.Nickname = dogname;
                    pet_Shop.dogs.Add(dog);
                    Console.WriteLine($"{pet_Shop.dogs.Last().Nickname} adi uqurla elave edildi");
                    break;
                case "3":
                    Console.Write("Cat adi daxil edin:");
                    string catname = Console.ReadLine();
                    Cat cat = new Cat();
                    cat.Nickname = catname;
                    pet_Shop.cats.Add(cat);
                    Console.WriteLine($"{pet_Shop.cats.Last().Nickname} adi uqurla elave edildi");
                    break;
                case "4":
                    Console.Write("Fish adi daxil edin:");
                    string fishname = Console.ReadLine();
                    Fish fish = new Fish();
                    fish.Nickname = fishname;
                    pet_Shop.fishs.Add(fish);
                    Console.WriteLine($"{pet_Shop.fishs.Last().Nickname} adi uqurla elave edildi");
                    break;
                default:
                    break;
            }
            break;
        case "3":
            Console.WriteLine(@"                    
                    1==> Bird 
                    2==> Dog
                    3==> Cat
                    4==> Fish
");

            Console.Write("Secim edin:");
            string choice__ = Console.ReadLine();
            switch (choice__)
            {
                case "1":
                    pet_Shop.birds.Last().play();
                    Console.WriteLine($"Bird ile oynadiniz son enerji miqdari={pet_Shop.birds.Last().Energy} ");

                    break;
                case "2":
                    pet_Shop.dogs.Last().play();
                    Console.WriteLine($"Dog ile oynadiniz son enerji miqdari={pet_Shop.dogs.Last().Energy} ");

                    break;
                case "3":
                    pet_Shop.cats.Last().play();
                    Console.WriteLine($"Cat ile oynadiniz son enerji miqdari={pet_Shop.cats.Last().Energy} ");

                    break;
                case "4":
                    pet_Shop.fishs.Last().play();
                    Console.WriteLine($"Fish ile oynadiniz son enerji miqdari={pet_Shop.fishs.Last().Energy} ");

                    break;
                default:
                    break;
            }
            break;
        case "4":
            Console.WriteLine(@"                    
                    1==> Bird 
                    2==> Dog
                    3==> Cat
                    4==> Fish
");

            Console.Write("Secim edin:");
            string choice___ = Console.ReadLine();
            switch (choice___)
            {
                case "1":
                    pet_Shop.birds.Last().sleep();
                    Console.WriteLine($"Heyvan yatdi son enerji= {pet_Shop.birds.Last().Energy}");
                    break;
                case "2":
                    pet_Shop.dogs.Last().sleep();
                    Console.WriteLine($"Heyvan yatdi son enerji= {pet_Shop.dogs.Last().Energy}");
                    break;
                case "3":
                    pet_Shop.cats.Last().sleep();
                    Console.WriteLine($"Heyvan yatdi son enerji= {pet_Shop.cats.Last().Energy}");
                    break;
                case "4":
                    pet_Shop.fishs.Last().sleep();
                    Console.WriteLine($"Heyvan yatdi son enerji= {pet_Shop.fishs.Last().Energy}");
                    break;
                default:
                    break;
            }
            break;
        case "5":
            Console.WriteLine(@"                    
                    1==> Bird 
                    2==> Dog
                    3==> Cat
                    4==> Fish
");

            Console.Write("Secim edin:");
            string choice____ = Console.ReadLine();
            switch (choice____)
            {
                case "1":
                    pet_Shop.birds.Last().eat();
                    Console.WriteLine($"Uqurla yemlendi son enerji= {pet_Shop.birds.Last().Energy}");
                    break;
                case "2":
                    pet_Shop.dogs.Last().eat();
                    Console.WriteLine($"Uqurla yemlendi son enerji= {pet_Shop.dogs.Last().Energy}");
                    break;
                case "3":
                    pet_Shop.cats.Last().eat();
                    Console.WriteLine($"Uqurla yemlendi son enerji= {pet_Shop.cats.Last().Energy}");
                    break;
                case "4":
                    pet_Shop.fishs.Last().eat();
                    Console.WriteLine($"Uqurla yemlendi son enerji= {pet_Shop.fishs.Last().Energy}");
                    break;
                default:
                    break;
            }
            break;
        case "6":
            ischeck=true;
            break;
        default:
            break;

    }
    if (ischeck)
        break;
    Thread.Sleep(4000);
} while (true);

