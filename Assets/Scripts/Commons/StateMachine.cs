using System.Collections;
using System.Collections.Generic;

public class StateMachine<T> where T : class, new()
{
    private T parent = null;
    private List<StatePack> statePacks = null;
    private StatePack currentStatePack = null;
    private StatePack initialStatePack = null;

    public StateMachine(T parent)
    {
        this.parent = parent;
        statePacks = new List<StatePack>();
    }

    public void Update()
    {
        currentStatePack.GetStateObject().Update();
    }

    public void End()
    {

    }

    public T GetParent() => parent;

    public void AddStateObject(IStateObject stateObject, ITransition transition)
    {
        var statePack = new StatePack(transition, stateObject);
        if (initialStatePack == null)
        {
            initialStatePack = statePack;
        }

        if (currentStatePack == null)
        {
            currentStatePack = statePack;
        }

        statePacks.Add(statePack);
    }
}
