using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int scoreRes;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + scoreRes;
    }
}
