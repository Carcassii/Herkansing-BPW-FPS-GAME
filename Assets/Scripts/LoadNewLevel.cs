using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    public string LoadLevel;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
        SceneManager.LoadScene(LoadLevel);  
        }
        
    }
}
