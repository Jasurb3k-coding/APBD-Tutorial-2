using TutorialThree.Enums;
using TutorialThree.Exceptions;

namespace TutorialThree.Containers;

public abstract class BaseContainer(ContainerType containerType, float height, float weight, float depth, float maxPayload)
{
    private static int _numberOfExistingContainers = 0;
    
    public ContainerType ContainerType { get; set; } = containerType;
    public float CurrentTotalMass { get; set; }
    
    public float Height { get; set; } = height;
    public float Weight { get; set; } = weight;
    public float Depth { get; set; } = depth; 
    public float MaxPayload { get; set; } = maxPayload;

    public string SerialNumber => $"KON-{ContainerType}-{++_numberOfExistingContainers}";

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