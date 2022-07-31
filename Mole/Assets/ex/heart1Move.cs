using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart1Move : MonoBehaviour
{
    public bool moved1;
    private bool up = true;
    private float y1;
    // Start is called before the first frame update
    void Start()
    {
        moved1 = false;
        y1 = GameObject.Find("Heart1").transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(moved1 == false)
        {
            if(up == true)
            {
                y1 += 0.1f;
                GameObject.Find("Heart1").transform.position = new Vector2(GameObject.Find("Heart1").transform.position.x, y1);
                if(y1 > - 27)
                {
                    up = false;
                }
            }
            else
            {
                y1 -= 0.1f;
                GameObject.Find("Heart1").transform.position = new Vector2(GameObject.Find("Heart1").transform.position.x, y1);
                if (y1 <= -30)
                {
                    up = true;
                    moved1 = true;
                }
            }
        }
        if (GameObject.Find("Lifenum").GetComponent<Life>().Lifenum < 1)
        {
            GameObject.Find("Heart1").transform.position = new Vector2(GameObject.Find("Heart1").transform.position.x + 100, y1);
        }
    }
}
