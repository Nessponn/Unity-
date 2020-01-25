using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject Ball;
    private enum Move
    {
        Left,Right,Stop
    }
    private Move move_dir = Move.Stop;
    Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move_dir = Move.Left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move_dir = Move.Right;
        }
        else
        {
            move_dir = Move.Stop;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = (GameObject)Instantiate(Ball, this.transform.position, Quaternion.identity);
            Destroy(obj, 3.0f);
        }

        switch (move_dir)
        {
            case Move.Left:
                rbody.velocity = new Vector3(-12f, rbody.velocity.y, 0);
                break;
            case Move.Right:
                rbody.velocity = new Vector3(12f, rbody.velocity.y, 0);
                break;
            case Move.Stop:
                rbody.velocity = new Vector3(0, rbody.velocity.y, 0);
                break;
        }
    }
    void LateUpdate()
    {
        Vector3 pos = Camera.main.transform.position;
        pos.y = this.transform.position.y + 30;
        pos.z = this.transform.position.z - 45;
        Camera.main.transform.position = pos;
    }
}
