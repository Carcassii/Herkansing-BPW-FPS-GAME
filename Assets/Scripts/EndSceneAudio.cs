using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneAudio : MonoBehaviour
{
    public AudioSource Music;
    public GameObject ZombieEnemy01;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Musicfinish());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator Musicfinish()
    {
        Music.Play();
        yield return new WaitForSeconds(35);
        ZombieEnemy01.SetActive(true);
        yield return true;
    }

}
