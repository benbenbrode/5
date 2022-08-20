using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("event").GetComponent<egg>().eggnum == 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        if (GameObject.Find("event").GetComponent<Timer>().gameclearck == 0)
        {
            GameObject.Find("event").GetComponent<egg>().eggnum = GameObject.Find("event").GetComponent<egg>().eggnum - 1;
        }
    }
}
