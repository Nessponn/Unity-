
public class StatePack
{
    private ITransition transition;
    private IStateObject stateObject;

    public StatePack(ITransition transition, IStateObject stateObject)
    {
        this.transition = transition;
        this.stateObject = stateObject;
    }

    public ITransition GetTransition() => transition;
    public IStateObject GetStateObject() => stateObject;
}
