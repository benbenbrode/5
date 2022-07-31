using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart3Move : MonoBehaviour
{
    public bool moved3;
    private bool up = true;
    private float y3;
    // Start is called before the first frame update
    void Start()
    {
        moved3 = false;
        y3 = GameObject.Find("Heart3").transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (moved3 == false && GameObject.Find("Heart2").GetComponent<heart2Move>().moved2 == true && GameObject.Find("Heart1").GetComponent<heart1Move>().moved1 == true)
        {
            if (up == true)
            {
                y3 += 0.1f;
                GameObject.Find("Heart3").transform.position = new Vector2(GameObject.Find("Heart3").transform.position.x, y3);
                if (y3 > -27)
                {
                    up = false;
                }
            }
            else
            {
                y3 -= 0.1f;
                GameObject.Find("Heart3").transform.position = new Vector2(GameObject.Find("Heart3").transform.position.x, y3);
                if (y3 <= -30)
                {
                    up = true;
                    GameObject.Find("Heart1").GetComponent<heart1Move>().moved1 = false;
                    GameObject.Find("Heart2").GetComponent<heart2Move>().moved2 = false;
                }
            }
        }
        if (GameObject.Find("Lifenum").GetComponent<Life>().Lifenum < 3)
        {
            GameObject.Find("Heart3").transform.position = new Vector2(GameObject.Find("Heart1").transform.position.x + 100, y3);
        }
    }

}
