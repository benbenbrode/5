using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorQuiz : MonoBehaviour
{
    private Button cb1;
    private Button cb2;
    private Button cb3;
    private Button cb4;
    private ColorBlock col1;
    private ColorBlock col2;
    private ColorBlock col3;
    private ColorBlock col4;
    private AudioSource b1;
    private AudioSource b2;
    private AudioSource b3;
    private AudioSource b4;

    public int[] arr = new int[6];
    public bool showEnd = false;
    public int cnt = 0;
    public GameObject good;
    public GameObject bad;
    public GameObject quizb;
    public SpriteRenderer colorc;

    void Awake()
    {
        good = Resources.Load("Prefabs/O") as GameObject;
        bad = Resources.Load("Prefabs/X") as GameObject;
        quizb = Resources.Load("Prefabs/quiz") as GameObject;

        cb1 = GameObject.Find("cb1").GetComponent<Button>();
        cb2 = GameObject.Find("cb2").GetComponent<Button>();
        cb3 = GameObject.Find("cb3").GetComponent<Button>();
        cb4 = GameObject.Find("cb4").GetComponent<Button>();

        b1 = GameObject.Find("cb1").GetComponent<AudioSource>();
        b2 = GameObject.Find("cb2").GetComponent<AudioSource>();
        b3 = GameObject.Find("cb3").GetComponent<AudioSource>();
        b4 = GameObject.Find("cb4").GetComponent<AudioSource>();

        col1 = cb1.colors;
        col2 = cb2.colors;
        col3 = cb3.colors;
        col4 = cb4.colors;

        col1.normalColor = new Color32(30, 30, 30, 255);
        col2.normalColor = new Color32(30, 30, 30, 255);
        col3.normalColor = new Color32(30, 30, 30, 255);
        col4.normalColor = new Color32(30, 30, 30, 255);

        cb1.colors = col1;
        cb2.colors = col2;
        cb3.colors = col3;
        cb4.colors = col4;

        cb1.interactable = false;
        cb2.interactable = false;
        cb3.interactable = false;
        cb4.interactable = false;

        for (int i = 0; i < arr.Length; i++)
        {
            int a = Random.Range(1, 5);
            arr[i] = a;
        }

    }

    void Start()
    {
        StartCoroutine(ColorShow());
    }

    IEnumerator ColorShow()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < arr.Length; i++)
        {
            GameObject obj = MonoBehaviour.Instantiate(quizb);
            colorc = obj.GetComponent<SpriteRenderer>();
            Vector3 pos;
            switch (arr[i])
            {
                case 1:
                    colorc.material.color = new Color(255 / 255f, 0 / 255f, 0 / 255f);
                    obj.name = arr[i].ToString();
                    pos = new Vector3(0, (float)10.2, 0);
                    obj.transform.position = pos;
                    b1.Play();
                    yield return new WaitForSeconds(.3f);
                    Destroy(obj);
                    yield return new WaitForSeconds(.3f);
                    break;
                case 2:
                    colorc.material.color = new Color(255 / 255f, 255 / 255f, 0 / 255f);
                    obj.name = arr[i].ToString();
                    pos = new Vector3(0, (float)-10.2, 0);
                    obj.transform.position = pos;
                    b2.Play();
                    yield return new WaitForSeconds(.3f);
                    Destroy(obj);
                    yield return new WaitForSeconds(.3f);
                    break;
                case 3:
                    colorc.material.color = new Color(0 / 255f, 0 / 255f, 255 / 255f);
                    obj.name = arr[i].ToString();
                    pos = new Vector3((float)10.2, 0, 0);
                    obj.transform.position = pos;
                    b3.Play();
                    yield return new WaitForSeconds(.3f);
                    Destroy(obj);
                    yield return new WaitForSeconds(.3f);
                    break;
                case 4:
                    colorc.material.color = new Color(0 / 255f, 255 / 255f, 0 / 255f);
                    obj.name = arr[i].ToString();
                    pos = new Vector3((float)-10.2, 0, 0);
                    obj.transform.position = pos;
                    b4.Play();
                    yield return new WaitForSeconds(.3f);
                    Destroy(obj);
                    yield return new WaitForSeconds(.3f);
                    break;
            }
        }
        showEnd = true;
        cb1.interactable = true;
        cb2.interactable = true;
        cb3.interactable = true;
        cb4.interactable = true;
        yield break;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
