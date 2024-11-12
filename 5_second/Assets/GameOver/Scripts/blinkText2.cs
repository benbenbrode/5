using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class blinkText2 : MonoBehaviour
{
    private Text tts;
    // Start is called before the first frame update
    void Start()
    {
        tts = GameObject.Find("gomain").GetComponent<Text>();
        StartCoroutine(BlinkText());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator BlinkText()
    {
        while (true)
        {
            tts.text = "";
            yield return new WaitForSeconds(.5f);
            tts.text = "< Touch To Main >";
            yield return new WaitForSeconds(.5f);

        }
    }
}
