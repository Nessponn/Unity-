using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawingwith_fivecards : MonoBehaviour
{
    public List<Card_detail> Cards_Spade = new List<Card_detail>(13);
    public List<Card_detail> Cards_Heart = new List<Card_detail>(13);
    public List<Card_detail> Cards_Club = new List<Card_detail>(13);
    public List<Card_detail> Cards_Diamond = new List<Card_detail>(13);

    public List<GameObject> Oneplayerside = new List<GameObject>(5);//1P側のカードをセット、データはKindsofcardsで入れておいたカードからランダムで重複なしで描画される
    public List<GameObject> Twoplayerside = new List<GameObject>(5);//2P側のカードをセット、データについては同上。

    //MeshRenderer Sp1;
    //MeshRenderer Sp2;

    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < Oneplayerside.Count;)
        {
            int Random_num1 = Random.Range(0, 5);
            GameObject obj;
            if(Random_num1 == 0)
            {
                int Random_num2 = Random.Range(0, 14);
                if (Cards_Spade[Random_num2].Get_bool())
                {
                    Cards_Spade[Random_num2].Set_bool(false);
                    obj = Instantiate(Cards_Spade[Random_num2].Cards_Object, Oneplayerside[i].transform.position, Quaternion.identity);
                    obj.transform.parent = Oneplayerside[i].transform;
                    i++;
                }
            }
            if (Random_num1 == 1)
            {
                int Random_num2 = Random.Range(0, 14);
                if (Cards_Heart[Random_num2].Get_bool())
                {
                    Cards_Heart[Random_num2].Set_bool(false);
                    obj = Instantiate(Cards_Spade[Random_num2].Cards_Object, Oneplayerside[i].transform.position, Quaternion.identity);
                    obj.transform.parent = Oneplayerside[i].transform;
                    i++;
                }
            }
            if (Random_num1 == 2)
            {
                int Random_num2 = Random.Range(0, 14);
                if (Cards_Club[Random_num2].Get_bool())
                {
                    Cards_Club[Random_num2].Set_bool(false);
                    obj = Instantiate(Cards_Spade[Random_num2].Cards_Object, Oneplayerside[i].transform.position, Quaternion.identity);
                    obj.transform.parent = Oneplayerside[i].transform;
                    i++;
                }
            }
            if (Random_num1 == 3)
            {
                int Random_num2 = Random.Range(0, 14);
                if (Cards_Diamond[Random_num2].Get_bool())
                {
                    Cards_Diamond[Random_num2].Set_bool(false);
                    obj = Instantiate(Cards_Spade[Random_num2].Cards_Object, Oneplayerside[i].transform.position, Quaternion.identity);
                    obj.transform.parent = Oneplayerside[i].transform;
                    i++;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


[System.Serializable]
public class Card_detail//スプライトの一つ一つにbool変数とSprite画像を持たせる
{
    private bool Notusingthiscard = true;//既に使われている時はfalseになる
    public GameObject Cards_Object;//ここに入れたカードのスプライトをスタート時に当てはめる

    public bool Get_bool()
    {
        return Notusingthiscard;
    }
    public void Set_bool(bool a)
    {
        Notusingthiscard = a;
    }
}


