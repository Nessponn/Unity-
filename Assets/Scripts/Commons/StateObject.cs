using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateObject : IStateObject
{
    private ITransition transition;
    private bool isActivated = false;

    protected abstract void OnActivate();
    protected abstract void OnUpdate();
    protected abstract void OnDeactivate();

    public void Activate()
    {
        OnActivate();
        isActivated = true;
    }

    public void Update()
    {
        OnUpdate();
    }

    public void Deactivate()
    {
        OnDeactivate();
        isActivated = false;
    }

    public void SetTransition(ITransition transition)
    {
        this.transition = transition;
    }

    public ITransition GetTransition() => transition;
    public bool GetActivated() => isActivated;
}
