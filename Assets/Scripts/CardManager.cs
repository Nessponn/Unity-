using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    private List<CardDatas> Cards = new List<CardDatas>();
    [SerializeField]
    private GameObject CardPrefab = null;
    [SerializeField]
    private List<int> One = new List<int>();
    [SerializeField]
    private List<int> Two = new List<int>();
    private List<int> CardNums = new List<int>();
    void Start()
    {
        if (Cards.Count % 2 != 0)
        {
            return;
        }
        for (int i = 0; i < Cards.Count; i++)
        {
            GameObject Card = Instantiate(CardPrefab, new Vector3(Random.Range(0, 5), 0, Random.Range(0, 5)), Quaternion.identity);
            CardData cardData = Card.GetComponent<CardData>();
            cardData.CardType = (CardData.Type)Cards[i].CardType;
            cardData.Number = Cards[i].Number;
            cardData.Group = Distribute(i);
            if(cardData.Group == 0)
            {
                Card.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                Card.GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }

    int Distribute(int num)
    {
        if(One.Count < Cards.Count / 2 && Two.Count < Cards.Count / 2)
        {
            int Value = Random.Range(0, 2);
            if (Value == 0)
            {
                One.Add(num);
            }
            else
            {
                Two.Add(num);
            }
            return Value;
        }
        if(One.Count >= Cards.Count /2)
        {
            Two.Add(num);
            return 1;
        }
        One.Add(num);
        return 0;
    }
}

[System.Serializable]
public class CardDatas
{

    //設定したいデータの変数
    public string Name = "なまえ";
    public Type CardType = default;
    public enum Type
    {
        Spade = 0,
        Club = 1,
        Diamond = 2,
        Heart = 3
    }
    public int Number = 0;

}