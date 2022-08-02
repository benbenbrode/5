using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gotoMain : MonoBehaviour
{
    public GameObject bg;
    private Text score;
    private int sc = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("score").GetComponent<Text>();
        score.text = "0";
        StartCoroutine(scoreText());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("BG").GetComponent<Bg>().gameover = 1;
            SceneManager.LoadScene("Title");
        }
    }

    public IEnumerator scoreText()
    {
        while (sc < GameObject.Find("BG").GetComponent<Bg>().gameround)
        {
            if (GameObject.Find("BG").GetComponent<Bg>().gameround < 3)
            {
                yield return new WaitForSeconds(1f);
                sc++;
                score.text = sc.ToString();
            }
            else
            {
                if (sc + 2 >= GameObject.Find("BG").GetComponent<Bg>().gameround)
                {
                    yield return new WaitForSeconds(1f);
                    sc++;
                    score.text = sc.ToString();
                }
                else
                {
                    yield return new WaitForSeconds(.3f);
                    sc++;
                    score.text = sc.ToString();
                }
            }

        }
        yield break;
    }
}
