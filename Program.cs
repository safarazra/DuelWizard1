Wizard wizardA = new Wizard ("Spongebob", 20);
Wizard wizardB = new Wizard ("Plankton", 30);

Console.WriteLine("Permainan dimulai...\n");
wizardA.ShowStats ();
wizardB.ShowStats ();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan berakhir");
wizardA.ShowStats();
wizardB.ShowStats();

public class Wizard
{
    public String Name;
    public int Energy;
    public int Damage;

    public Wizard (String name, int damage)
    {
        Name = name;
        Energy = 100;
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
}