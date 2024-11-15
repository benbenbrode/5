using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart2Move : MonoBehaviour
{
    public bool moved2;
    public bool f_fail = false;
    public bool f_fail_after = false;
    private bool up = true;
    private float y2;
    // Start is called before the first frame update
    void Start()
    {
        moved2 = false;
        y2 = GameObject.Find("Heart2").transform.position.y;
        if (GameObject.Find("Lifenum").GetComponent<Life>().Lifenum < 2)
        {
            if (f_fail == false)
            {
                f_fail = true;
            }
            else
            {
                f_fail_after = true;
            }
            GameObject.Find("Heart2").transform.position = new Vector2(GameObject.Find("Heart1").transform.position.x + 100, y2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moved2 == false && GameObject.Find("Heart1").GetComponent<heart1Move>().moved1 == true)
        {
            if (up == true)
            {
                y2 += 0.1f;
                GameObject.Find("Heart2").transform.position = new Vector2(GameObject.Find("Heart2").transform.position.x, y2);
                if (y2 > -27)
                {
                    up = false;
                }
            }
            else
            {
                y2 -= 0.1f;
                GameObject.Find("Heart2").transform.position = new Vector2(GameObject.Find("Heart2").transform.position.x, y2);
                if (y2 <= -30)
                {
                    up = true;
                    moved2 = true;
                }
            }
        }
    }
}
