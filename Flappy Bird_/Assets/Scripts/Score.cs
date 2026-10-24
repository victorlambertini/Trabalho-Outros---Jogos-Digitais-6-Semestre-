
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public float scoreValue;

    void Start()
    {
        scoreValue = 0;
        scoreTxt.text = scoreValue.ToString();
    }

    void Update()
    {
        scoreTxt.text = scoreValue.ToString();
    }
}
