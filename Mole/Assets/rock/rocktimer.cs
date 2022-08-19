using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rocktimer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;
    public int gameclearck = 0;
    public GameObject x;
    int zero = 0;
    int ck = 0;
    // Update is called once per frame
    void Update()
    {
        Invoke("timer", 3f);
        if (zero == 1)
        {
            if (ck == 0)
            {
                gameclearck = 1;
                Instantiate(x, new Vector3(0, 0, 0), Quaternion.identity);
                Invoke("end", 2f);
                ck = 1;
            }
            
        }
     }

    public void timer()
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
                zero = 1;
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

    public void end()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
        GameObject.Find("BG").GetComponent<Bg>().stageck = 5;
        SceneManager.LoadScene("Round");
    }
}
