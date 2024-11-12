using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text_Timer;

    // Update is called once per frame
    void Update()
    {
        text_Timer.text = GameObject.Find("manger").GetComponent<molemanger>().score + " / " + GameObject.Find("manger").GetComponent<Molenext>().goal;
    }
}
