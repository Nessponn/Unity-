using System.Collections;
using System.Collections.Generic;

public class StateMachine<T> where T : class, new()
{
    private T parent = null;
    private List<StatePack> statePacks = null;
    private IStateObject currentStateObject = null;
    private IStateObject initialStateObject = null;
    private Dictionary<string, StateParameter> stateParameters;

    public StateMachine(T parent)
    {
        this.parent = parent;
        statePacks = new List<StatePack>();
        stateParameters = new Dictionary<string, StateParameter>();
    }

    public void Update()
    {
        if (!currentStateObject.GetActivated())
        {
            currentStateObject.Activate();
        }

        currentStateObject.Update();

        if (currentStateObject.GetTransition().Condition())
        {
            currentStateObject.Deactivate();
        }
    }

    public void End()
    {

    }

    public T GetParent() => parent;

    public void AddStateObject(IStateObject stateObject, ITransition transition)
    {
        var statePack = new StatePack(transition, stateObject);
        transition.SetFrom(stateObject);

        if (currentStateObject == null)
        {
            currentStateObject = stateObject;
        }

        if (initialStateObject == null)
        {
            initialStateObject = stateObject;
        }
        statePacks.Add(statePack);
    }

    private void TransitionCurrentState()
    {
        if (currentStateObject != null)
        {
            currentStateObject = currentStateObject.GetTransition().GetTo();
        }
    }

    public void TransitionInitialState()
    {
        // 直接Deactivateを呼んでしまう
        currentStateObject.Deactivate();
        currentStateObject = initialStateObject;
    }
}
