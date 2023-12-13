public class Cow : Animal
{
    static Cow() { MaxLife = 9125; }
    public static int MaxLife { get; }

    public override int Life()
    {
        int Age = (int)(DateTime.Now - BirthDate).TotalDays;

        return MaxLife - Age;
    }
    public override string ToString() =>
     $"C{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";
    List<Environment> environments { get; set; }
    List<CowParameter> cowParameters { get; set; }


    public override string ToString() =>
       $"S{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";

    public override int TimeToDie()
    {
        int age = (int)(DateTime.Now - BirthDate).TotalDays;
        return age - MaxLife;
    }

    public override float KillPriority()
    {
        int days = MaxLife - Life();
        double KillPriority;
        switch (days)
        {
            case int day when days <= 1825:
                KillPriority = 1;
                break;
            case int day when days > 1825 && days <= 3650:
                KillPriority = 0.75;
                break;
            case int day when days > 3650 && days <= 5475:
                KillPriority = 0.5;
                break;
            case int day when days > 5475 && days <= 7300:
                KillPriority = 0.25;
                break;
            default:
                KillPriority = 0;
                break;
        }

        return (float)KillPriority;
    }


    public override int CostPerDay()
    {
        throw new NotImplementedException();
    }

    public override int ValuePerDay()
    {
        throw new NotImplementedException();
    }
}
