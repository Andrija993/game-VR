using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("XR Rig Advanced Variant"))
        {
            print("player in trigger");
            SceneManager.LoadScene("GameScene");

        }
    }
}
