using UnityEngine;
using System.Collections;

public class Carro : MonoBehaviour {

    public float velocidade = 3;
    public GameObject GameOver;
  
   // public Animation Fire;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * velocidade * Input.GetAxis("Horizontal"), 0, 0);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
       
       // Fire.Play();
        Destroy(gameObject);
        Instantiate(GameOver);
      //  Animation Fire;

        Application.LoadLevel("TelaFinal");
    }

  
}
