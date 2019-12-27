public interface IStateObject
{
    void Activate();
    void Update();
    void Deactivate();
    void SetTransition(ITransition transition);
    ITransition GetTransition();
    bool GetActivated();
}