using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class molemanger : MonoBehaviour
{
    public int ck = 0;
    public int ck2 = 0;
    public int mole = 0;
    public int mole2 = 0;
    public int score = 0;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f - (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * .1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ck == 0)
        {
            if (GameObject.Find("manger").GetComponent<Timer>().LimitTime > 0.2)
            {
                mole = Random.Range(1, 10);
                ck = 1;
                Invoke("cker", speed);
            }
        }
        if (ck2 == 0)
        {
            if (GameObject.Find("manger").GetComponent<Timer>().LimitTime > 0.2)
            {
                mole2 = Random.Range(1, 10);
                ck2 = 1;
                Invoke("cker2", speed);
            }
        }

        if (GameObject.Find("manger").GetComponent<Molenext>().gameover == 1)
        {
            mole = 0;
            mole2 = 0;
        }
    }

    public void cker()
    {
        ck = 0;
    }

    public void cker2()
    {
        ck2 = 0;
    }

}
