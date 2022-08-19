using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mix : MonoBehaviour
{
    public int mixck= 0;
    public int mixck2 = 0;
    public int mixnum = 0;
    public int mixnum2 = 0;
    public int joker;
    public int jokercker;
    public bool jokerck = true;
    public int cnt = 0;
    public int start = 0;
    int time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == 1)
        {
            time = 4 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 2;
            if (cnt < time)
            {
                if (mixck == 0 && mixck2 == 0)
                {
                    mixnum = 0;
                    mixnum2 = 0;
                    jokercker = joker;
                    while (mixnum == mixnum2)
                    {
                        mixnum = Random.Range(1, 4);
                        mixnum2 = Random.Range(1, 4);
                        mixck = 1;
                        mixck2 = 1;
                    }
                    if (jokerck == true)
                    {
                        if (joker == 1)
                        {
                            if (mixnum == 1 || mixnum2 == 1)
                            {
                                joker1();
                                jokerck = false;
                            }
                        }
                    }

                    if (jokerck == true)
                    {
                        if (joker == 2)
                        {
                            if (mixnum == 2 || mixnum2 == 2)
                            {
                                joker2();
                                jokerck = false;
                            }
                        }
                    }

                    if (jokerck == true)
                    {
                        if (joker == 3)
                        {
                            if (mixnum == 3 || mixnum2 == 3)
                            {
                                joker3();
                                jokerck = false;
                            }
                        }
                    }
                    
                    cnt++;
                    jokerck = true;
                }
            }
            else
            {
                mixnum = 0;
                GameObject.Find("EventSystem").GetComponent<choose>().end = 1;
            }

        }
    }

    public void joker1()
    {
        Debug.Log("조커1");
        if (mixnum == 1)
        {
            joker = mixnum2;
        }
        if (mixnum2 == 1)
        {
            joker = mixnum;
        }
    }

    public void joker2()
    {
        Debug.Log("조커2");
        if (mixnum == 2)
        {
            joker = mixnum2;
        }
        if (mixnum2 == 2)
        {
            joker = mixnum;
        }
    }
    public void joker3()
    {
        Debug.Log("조커3");
        if (mixnum == 3)
        {
            joker = mixnum2;
        }
        if (mixnum2 == 3)
        {
            joker = mixnum;
        }
    }
}
