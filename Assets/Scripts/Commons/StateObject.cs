using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateObject : IStateObject
{
    public abstract void OnActivate();
    public abstract void Update();
    public abstract void OnDeactivate();
}
