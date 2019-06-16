using UnityEngine.UI;
using UnityEngine;

public class GlobalAmmo : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    public static int LoadedAmmo;
    public int internalLoaded;
    public GameObject LoadedDisplay;
    
    
    void Update()
    {
        InternalAmmo = CurrentAmmo;
        internalLoaded = LoadedAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
        LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;
    }
}
