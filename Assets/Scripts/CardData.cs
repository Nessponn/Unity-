using UnityEngine;

public class CardData : MonoBehaviour
{
    public Type CardType = default;//カードの状態をインスペクターから変更できるように
    public enum Type : int//Typeというenum型の変数を作成。intとして割り当てる
    {
        Spade = 0,
        Club = 1,
        Diamond = 2,
        Heart = 3
    }
    public int Number = 0;//カードの状態をインスペクターから変更できるように
    public int Group = 0;//カードの状態をインスペクターから変更できるように
    private void Update()
    {
        if(Number > 13 || Number < 0)//カードの番号が範囲外だった時のエラー
        {
            Debug.LogError("カード番号が0~13ではありません。");
        }
    }
}
