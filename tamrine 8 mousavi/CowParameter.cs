public class CowParameter
{
    public HealthParameter TimeToStand { get; set; }

    public HealthParameter TimeToDie { get; set; }

    public HealthParameter TimeToRelax { get; set; }

    public HealthParameter NumberOfMeals { get; set; }

    public HealthParameter NumberOfMilkProduction { get; set; }

    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}
