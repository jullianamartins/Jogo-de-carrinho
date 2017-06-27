using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

    float larguraTela;
    float alturaTela;

    // Use this for initialization
    void Start () {

        SpriteRenderer grafico = GetComponent<SpriteRenderer>();

        float larguraImagem = grafico.sprite.bounds.size.x;
        float alturaImagem = grafico.sprite.bounds.size.y;

        alturaTela = Camera.main.orthographicSize * 2f;
        larguraTela = alturaTela / Screen.height * Screen.width;

        Vector2 novaEscala = transform.localScale;
        novaEscala.x = larguraTela / larguraImagem;
        novaEscala.y = alturaTela / alturaImagem + 0.25f;
        this.transform.localScale = novaEscala;

        if(this.name == "background2")
        {
            transform.position = new Vector2(0f, alturaTela);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);

    }


    // Update is called once per frame
    void Update () {

        //loop do background
        if (transform.position.y <= -alturaTela)
        {
            transform.position = new Vector2(0f, alturaTela);
        }
	
	}
}
