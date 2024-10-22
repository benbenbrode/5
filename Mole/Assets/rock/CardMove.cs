using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class CardMove : MonoBehaviour
{
    public RectTransform image1;
    public RectTransform image2;
    public RectTransform image3;
    public float speed = 200f;

    private Vector3 initialPos1;
    private Vector3 initialPos2;
    private Vector3 initialPos3;
    private bool swapping = false;
    public bool fin = false;
    private int swapnum = 0;
    private int swapnum2 = 10;
    private bool startcker = false;

    public GameObject jokercard;
    public Sprite after_img;

    void Start()
    {
        Invoke("wait", 2);
        // 이미지의 초기 위치 저장
        initialPos1 = image1.anchoredPosition;
        initialPos2 = image2.anchoredPosition;
        initialPos3 = image3.anchoredPosition;
        speed = speed + ((GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 200);
    }

    void Update()
    {
        if (startcker == false)
            return;

        if (swapnum == 2 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 2)
        {
            fin = true;
            return;
        }

        if (!swapping)
        {
            swapnum2 = Random.Range(0, 3);
            swapping = true;
        }


        if(swapnum2 == 0)
        {
            // 이미지1을 이미지2의 위치로 이동
            image1.anchoredPosition = Vector3.MoveTowards(image1.anchoredPosition, initialPos2, speed * Time.deltaTime);
            // 이미지2를 이미지1의 위치로 이동
            image2.anchoredPosition = Vector3.MoveTowards(image2.anchoredPosition, initialPos1, speed * Time.deltaTime);

            // 이미지들이 서로의 위치에 도달했는지 확인
            if (Vector2.Distance(image1.anchoredPosition, initialPos2) < 0.1f &&
              Vector2.Distance(image2.anchoredPosition, initialPos1) < 0.1f)
            {
                initialPos1 = image1.anchoredPosition;
                initialPos2 = image2.anchoredPosition;
                initialPos3 = image3.anchoredPosition;
                swapnum++;
                swapping = false;
            }
        }

        if(swapnum2 == 1)
        {
            // 이미지1을 이미지3의 위치로 이동
            image1.anchoredPosition = Vector3.MoveTowards(image1.anchoredPosition, initialPos3, speed * Time.deltaTime);
            // 이미지3를 이미지1의 위치로 이동
            image3.anchoredPosition = Vector3.MoveTowards(image3.anchoredPosition, initialPos1, speed * Time.deltaTime);

            // 이미지들이 서로의 위치에 도달했는지 확인
            if (Vector2.Distance(image1.anchoredPosition, initialPos3) < 0.1f &&
              Vector2.Distance(image3.anchoredPosition, initialPos1) < 0.1f)
            {
                initialPos1 = image1.anchoredPosition;
                initialPos2 = image2.anchoredPosition;
                initialPos3 = image3.anchoredPosition;
                swapnum++;
                swapping = false;
            }
        }

        if(swapnum2 == 2)
        {
            // 이미지3을 이미지2의 위치로 이동
            image3.anchoredPosition = Vector3.MoveTowards(image3.anchoredPosition, initialPos2, speed * Time.deltaTime);
            // 이미지2를 이미지3의 위치로 이동
            image2.anchoredPosition = Vector3.MoveTowards(image2.anchoredPosition, initialPos3, speed * Time.deltaTime);

            // 이미지들이 서로의 위치에 도달했는지 확인
            if (Vector2.Distance(image3.anchoredPosition, initialPos2) < 0.1f &&
              Vector2.Distance(image2.anchoredPosition, initialPos3) < 0.1f)
            {
                initialPos1 = image1.anchoredPosition;
                initialPos2 = image2.anchoredPosition;
                initialPos3 = image3.anchoredPosition;
                swapnum++;
                swapping = false;
            }
        }

    }

    void wait()
    {
        startcker = true;
        jokercard.GetComponent<Image>().sprite = after_img;
    }
}
