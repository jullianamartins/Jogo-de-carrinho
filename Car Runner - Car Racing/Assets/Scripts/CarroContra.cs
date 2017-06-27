using UnityEngine;
using System.Collections;

public class CarroContra : MonoBehaviour {
    /// <summary>
    /// Faz os carros aparecerem no inicio da tela
    /// </summary>
    /// 


    public bool EUmInstanciador = false;
    public GameObject ObjetoASerInserido;
    private float Contador;

   // public GameObject carroPlayer;

    //Rigidbody2D rig;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (EUmInstanciador)
        {
            Contador += Time.deltaTime;

            if (Contador >= Random.value * 100)
            {
                Contador = 0;
                Instantiate(ObjetoASerInserido, new Vector3(Random.value * 3.2f - 1.8f, 9, 0), ObjetoASerInserido.transform.rotation);
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (0, -5);
        }

       
         
	}
}
