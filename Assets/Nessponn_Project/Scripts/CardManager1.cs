using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager1 : MonoBehaviour
{
    private Vector3 Mouse_pos;
    public GameObject Cardpos1;
    public GameObject Cardpos2;
    public GameObject Cardpos3;
    public GameObject Cardpos4;
    public GameObject Cardpos5;

    public float x;
    public float y;
    public float width = 200;
    public float height = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mouse_pos = Input.mousePosition;//こいつの位置によって、
        Rect rect1 = new Rect(Cardpos1.transform.localPosition.x - x, Cardpos1.transform.localPosition.y - y, width,height);
        
        if (rect1.Contains(Mouse_pos))
        {
            Debug.Log("マウスカーソルがカード１に乗っています");
        }
    }
}
