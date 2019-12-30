public interface ITransition
{
    bool Condition();
    void SetFrom(IStateObject from);
    IStateObject GetTo();
    IStateObject GetFrom();
}
