using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public EnemyHealth a;

    public Text text;


    void Awake ()
    {
        a = GameObject.FindGameObjectWithTag("Zombunny").GetComponent<EnemyHealth>();  
        text = GetComponent <Text> ();
        score = 0;
    }


    void Update ()
    {

        text.text = "Score: " + score;
    }
}
