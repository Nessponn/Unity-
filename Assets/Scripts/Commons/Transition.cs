using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Transition
{
    public abstract bool Condition();
    public abstract StateObject To();
}
