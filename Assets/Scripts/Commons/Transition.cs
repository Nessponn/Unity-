using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Transition : ITransition
{
    private IStateObject to;
    private IStateObject from;

    public Transition(StateObject to)
    {
        this.to = to;
    }

    public abstract bool Condition();

    public void SetFrom(IStateObject from)
    {
        this.from = from;
    }

    public IStateObject GetTo() => to;
    public IStateObject GetFrom() => from;
}
