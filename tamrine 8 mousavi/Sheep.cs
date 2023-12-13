public class Sheep : Animal
{
    static Sheep() { MaxLife = 4380; }
    public static int MaxLife { get; }
    public override int Life()
    {
        int Age = (int)(DateTime.Now - BirthDate).TotalDays;

        return MaxLife - Age;
    }
    List<Environment> environments = new List<Environment>();
    List<SheepParameter> SheepParameters = new List<SheepParameter>();
    public override string ToString() =>
      $"S{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";

    public override double StressFactor()
    {
        throw new NotImplementedException();
    }

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
            case int day when days <= 876:
                KillPriority = 1;
                break;
            case int day when days > 876 && days <= 1752:
                KillPriority = 0.75;
                break;
            case int day when days > 1752 && days <= 2628:
                KillPriority = 0.5;
                break;
            case int day when days > 2628 && days <= 3504:
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
