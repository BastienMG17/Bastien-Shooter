using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text txt;

    void Update()
    {
        txt.text = score.ToString();
    }
}
