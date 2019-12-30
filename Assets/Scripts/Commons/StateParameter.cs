using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// パラメーター保存用
/// </summary>
public class StateParameter
{
    private bool boolParameter;
    private StateParameterType type;

    public void SetType(StateParameterType type) => this.type = type;
    public StateParameterType GetStateParameterType() => type;
    public void SetBool(bool value) => boolParameter = value;
    public bool GetBool() => boolParameter;
}
