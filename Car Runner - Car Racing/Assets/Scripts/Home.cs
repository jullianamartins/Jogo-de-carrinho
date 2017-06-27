using UnityEngine;
using System.Collections;

public class Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void onClickPlayButton()
    {
        Application.LoadLevel("Game");
    }

    public void onClickCarButton()
    {
        Application.LoadLevel("ChangeCar");
    }

    public void onClickRankingButton()
    {
        Application.LoadLevel("Ranking");
    }

    public void onClickVolButton()
    {
       // Application.LoadLevel("ChangeBird");
    }

    public void onClickPowerButton()
    {
      //  Application.LoadLevel("ChangeBird");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
