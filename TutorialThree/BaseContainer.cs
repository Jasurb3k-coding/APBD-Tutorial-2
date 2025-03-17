namespace TutorialThree;

public class BaseContainer
{
    private static int _numberOfExistingContainers = 0;
    
    public ContainerType ContainerType { get; set; }
    public float CurrentTotalMass { get; set; }
    
    public float Height { get; set; }
    public float Weight { get; set; }
    public float Depth { get; set; }
    public string SerialNumber => $"KON-{ContainerType}-{++_numberOfExistingContainers}";

    public float MaxPayload { get; set; }


    public void EmptyCargo()
    {
        CurrentTotalMass = 0;
    }

    public void LoadCargo(float massOfTheCargo)
    {
        if (massOfTheCargo < MaxPayload)
            throw new OverfillException($"Cannot fit {MaxPayload}kgs into a container with max capacity of {MaxPayload}kgs");
        CurrentTotalMass = massOfTheCargo;
    }
}