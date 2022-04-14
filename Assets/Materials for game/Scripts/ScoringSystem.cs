using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject scoreText;
    public int theScore;

    void OnCollisionEnter(Collision collision)
    {
        if(tag == "Projectile"  )
        {
            theScore += 100;
            scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
            Debug.Log("sCORE3");
        }
        
    }
}
