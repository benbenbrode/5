using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Joker : MonoBehaviour
{
    public Button joker_btn;
    public Button other_btn;
    public Button other2_btn;
    public Canvas canvas;
    public GameObject xxx;
    public GameObject ooo;

    public GameObject joker;
    public Sprite joker_img;

    private bool Timerck = false;
    public bool gameoverck = false;
    // Start is called before the first frame update
    void Start()
    {
        if(joker_btn != null)
        {
            joker_btn.onClick.AddListener(jokerevent);
        }

        if (other_btn != null)
        {
            other_btn.onClick.AddListener(otherevent);
        }
        if (other2_btn != null)
        {
            other2_btn.onClick.AddListener(otherevent);
        }
    }

    private void Update()
    {
        if (GameObject.Find("event").GetComponent<rocktimer>().LimitTime < 0.01 && Timerck == false)
        {
            xcall();
            Timerck = true;
        }
    }
    private void jokerevent()
    {
        if (GameObject.Find("mgr").GetComponent<CardMove>().fin == false)
            return;
        if (gameoverck == true)
            return;

        ocall();
        gameoverck = true;
    }

    private void otherevent()
    {
        if (GameObject.Find("mgr").GetComponent<CardMove>().fin == false)
            return;
        if (gameoverck == true)
            return;

        xcall();
        gameoverck = true;
    }

    public void xcall()
    {
        //Instantiate(xxx, new Vector3(0, 0, 0), Quaternion.identity);

        GameObject newObject = Instantiate(xxx, Vector3.zero, Quaternion.identity);

        // 생성된 오브젝트를 캔버스의 자식으로 설정합니다.
        newObject.transform.SetParent(canvas.transform, false);

        Invoke("round", 2f);
        GameObject.Find("event").GetComponent<rocktimer>().gameclearck = 1;
        joker.GetComponent<Image>().sprite = joker_img;
    }

    public void ocall()
    {
        GameObject newObject = Instantiate(ooo, Vector3.zero, Quaternion.identity);

        // 생성된 오브젝트를 캔버스의 자식으로 설정합니다.
        newObject.transform.SetParent(canvas.transform, false);
        Invoke("round2", 2f);
        GameObject.Find("event").GetComponent<rocktimer>().gameclearck = 1;
        joker.GetComponent<Image>().sprite = joker_img;
    }
    public void round()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
        GameObject.Find("BG").GetComponent<Bg>().stageck = 2;
        SceneManager.LoadScene("Round");

    }

    public void round2()
    {
        GameObject.Find("BG").GetComponent<Bg>().stageck = 2;
        SceneManager.LoadScene("Round");
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("BG").GetComponent<Bg>().difficulty = GameObject.Find("BG").GetComponent<Bg>().difficulty + 1;
    }
}
