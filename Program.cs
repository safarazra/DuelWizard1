
Wizard wizardA = new Wizard ("Spongebob", 20);
Wizard wizardB = new Wizard ("Plankton", 30);

Console.WriteLine("Permainan dimulai...\n");
wizardA.ShowStats ();
wizardB.ShowStats ();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Heal();
//wizardA.Attack(wizardB);

string pilihan;
while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nMasukkan pilihanmu (1/2/3/4): ");
    pilihan = Console.ReadLine ();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "1")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan tidak valid");
    }
}

Console.WriteLine("Permainan selesai...\n");
Console.WriteLine("statistik akhir");
wizardA.ShowStats();
wizardB.ShowStats();

if(wizardA.Energy > wizardB.Energy)
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel!!");
}
else
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel!!");
}

public class Wizard
{
    //deklarasi field
    public String Name;
    public int Energy;
    public int Damage;

    //constructor
    public Wizard (String name, int damage)
    {
        Name = name;
        Energy = 50;
        Damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energy} \n");
    }

    public void Attack(Wizard wizardLawanobj)
    {
        //mengurangi wizardlawanobj sebesar damage
        wizardLawanobj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanobj.Name}");
        Console.WriteLine($"Sisa energi {wizardLawanobj.Name} adalah {wizardLawanobj.Energy}");
    }

    public void Heal()
    {
        if (Energy < 100)
        {
            Energy += 5;
            Console.WriteLine($"{Name} melakukan heal! Energi meningkat menjadi {Energy}");
        }
        else
        {
            Console.WriteLine("sudah mencapai energi maksimum!");
        }
    }
}


