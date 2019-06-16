using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Endhealth : MonoBehaviour
{
    public static int PlayerHealth = 10;
    public int InternalHealth;


    void Update()
    {
        InternalHealth = PlayerHealth;
        if (PlayerHealth == 0)
        {
            SceneManager.LoadScene(7);
        }

    }
}