using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        Debug.Log("Učitavanje razine:" + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Gašenje!");
        Application.Quit();
    }
}
