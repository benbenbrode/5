using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;
    public int gameclearck = 0;
    // Update is called once per frame
    void Update()
    {
        if (gameclearck == 0)
        {
            if (LimitTime > 0)
            {
                LimitTime -= Time.deltaTime;
            }
            if (LimitTime < 0)
            {
                LimitTime = .00f;
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
