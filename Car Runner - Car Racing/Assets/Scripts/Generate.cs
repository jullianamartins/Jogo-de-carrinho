using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

    public GameObject tool;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }
    void CreateObstacle()
    {
        Instantiate(tool);

    }
}
