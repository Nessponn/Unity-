public interface ITransition
{
    bool Condition();
    StateObject To();
}
