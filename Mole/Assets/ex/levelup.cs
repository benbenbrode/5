using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class levelup : MonoBehaviour
{
    private Text tts;
    // Start is called before the first frame update
    void Start()
    {
        tts = GameObject.Find("hard").GetComponent<Text>();
        if (GameObject.Find("BG").GetComponent<Bg>().difficulty > 0 && GameObject.Find("BG").GetComponent<Bg>().difficulty % 3 == 0)
        {
            StartCoroutine(BlinkText2());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator BlinkText2()
    {
        while (true)
        {
            tts.text = "";
            yield return new WaitForSeconds(.3f);
            tts.text = "LEVEL UP";
            yield return new WaitForSeconds(.3f);

        }
    }
}
