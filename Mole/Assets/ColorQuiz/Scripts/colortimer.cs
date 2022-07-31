using UnityEngine;
using UnityEngine.UI;

public class colortimer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas").GetComponent<colorQuiz>().showEnd == true)
        {
            if (LimitTime > 0)
            {
                LimitTime -= Time.deltaTime;
            }
            if (LimitTime > 5)
            {
                text_Timer.text = LimitTime.ToString("F2");
            }
            if (LimitTime < 5)
            {
                text_Timer.text = "<color=#ff0000>" + LimitTime.ToString("F2") + "</color>";
            }
        }
    }
}
