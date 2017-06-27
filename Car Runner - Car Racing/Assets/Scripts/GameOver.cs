using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Game Over");
    }
}
