using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ribbonMove : MonoBehaviour
{
    private float y1;
    private bool down = true;

    // Start is called before the first frame update
    void Start()
    {
        y1 = GameObject.Find("Ribbon").transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(down == true) 
        {
            y1 -= 0.008f;
            GameObject.Find("Ribbon").transform.position = new Vector2(GameObject.Find("Ribbon").transform.position.x, y1);
            if (y1 <= 12)
            {
                down = false;
            }
        }
        else
        {
            y1 += 0.008f;
            GameObject.Find("Ribbon").transform.position = new Vector2(GameObject.Find("Ribbon").transform.position.x, y1);
            if (y1 >= 16)
            {
                down = true;
            }
        }
    }
}
