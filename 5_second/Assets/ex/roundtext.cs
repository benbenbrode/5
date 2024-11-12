using UnityEngine;
using UnityEngine.UI;

public class roundtext : MonoBehaviour
{
    public int round;
    public Text text_round;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        round = GameObject.Find("BG").GetComponent<Bg>().gameround;
        text_round.text = round.ToString();
    }
}
