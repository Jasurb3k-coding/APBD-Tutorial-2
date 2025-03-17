using TutorialThree.Enums;

namespace TutorialThree.Containers;

public class LiquidContainer(float height, float weight, float depth, float maxPayload) : BaseContainer(ContainerType.Liquid, height, weight, depth, maxPayload)
{
    
}