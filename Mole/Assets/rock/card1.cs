using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card1 : MonoBehaviour
{
    public float speed;
    void Start()
    {
        transform.position = new Vector3(0, 20, 0);
    }
    // Update is called once per frame
    void Update()
    {
        speed = .5f + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * .15f;
        if (GameObject.Find("EventSystem").GetComponent<mix>().mixnum == 1)
        {
            if (GameObject.Find("EventSystem").GetComponent<mix>().mixnum2 == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0f, 0), speed);
                if (transform.position.y == 0f)
                {
                    GameObject.Find("EventSystem").GetComponent<mix>().mixck = 0;
                    transform.position = new Vector3(0, 20, 0);

                }
            }
            if (GameObject.Find("EventSystem").GetComponent<mix>().mixnum2 == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -20f, 0), speed );
                if (transform.position.y == -20f)
                {
                    GameObject.Find("EventSystem").GetComponent<mix>().mixck = 0;
                    transform.position = new Vector3(0, 20, 0);

                }
            }

        }

        if (GameObject.Find("EventSystem").GetComponent<mix>().mixnum2 == 1)
        {
            if (GameObject.Find("EventSystem").GetComponent<mix>().mixnum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0f, 0), speed );
                if (transform.position.y == 0f)
                {
                    GameObject.Find("EventSystem").GetComponent<mix>().mixck2 = 0;
                    transform.position = new Vector3(0, 20, 0);

                }
            }
            if (GameObject.Find("EventSystem").GetComponent<mix>().mixnum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -20f, 0), speed);
                if (transform.position.y == -20f)
                {
                    GameObject.Find("EventSystem").GetComponent<mix>().mixck2 = 0;
                    transform.position = new Vector3(0, 20, 0);

                }
            }

        }

    }
}

