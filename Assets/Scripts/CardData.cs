using UnityEngine;

public class CardData : MonoBehaviour
{
    public Type CardType = default;
    public enum Type : int
    {
        Spade = 0,
        Club = 1,
        Diamond = 2,
        Heart = 3
    }
    public int Number = 0;
    public int Group = 0;
    private void Update()
    {
        if(Number > 13 || Number < 0)
        {
            Debug.LogError("カード番号が0~13ではありません。");
        }
    }
}
