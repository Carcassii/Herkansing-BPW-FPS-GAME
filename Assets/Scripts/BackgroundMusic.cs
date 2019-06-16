using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource Music;


    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(MusicAmbient());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator MusicAmbient()
    {
        Music.Play();
        yield return true;
    }

}
