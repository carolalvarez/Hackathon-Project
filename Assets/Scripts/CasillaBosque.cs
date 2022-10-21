using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasillaBosque : MonoBehaviour
{
    public SpriteRenderer Fuego;

    public SpriteRenderer spr;

    public Sprite BosqueNormal;
    public Sprite BosqueQuemado;

    public ObjetoVariables recursos;

    public bool destrozado;
    public bool quemandose;

    public float contador;

    public float id;

    public int metodo;

    Color alphaF = new Color(1f, 1f, 1f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        spr.sprite = BosqueNormal;

        destrozado = false;
        quemandose = false;
        contador = 0;

        Fuego.color = alphaF;
    }

    private void FixedUpdate()
    {
        if (FireStarter.Firedet() == id)
        {
            alphaF = new Color(1f, 1f, 1f, 1f);
            Fuego.color = alphaF;
            quemandose = true;
        }

        if(quemandose == true && destrozado == false)
        {
            contador++;

            //Si no funciona metodo == 1, ponemos Directo().
            if (contador <= 10 && metodo == 1)
            {
                recursos.agua -= 19.000f;
                quemandose = false;
                contador = 0;
                alphaF = new Color(1f, 1f, 1f, 0f);
                Fuego.color = alphaF;
            }
            else if (contador <= 10 && metodo == 2)
            {
                recursos.gente -= 10;
                quemandose = false;
                contador = 1;
                alphaF = new Color(1f, 1f, 1f, 0f);
                Fuego.color = alphaF;
            }

            if (contador > 10 && metodo == 1)
            {
                recursos.agua -= 38.000f;
                recursos.gente -= 15;
                contador = 1;
            }
            else if (contador > 10 && metodo == 2)
            {
                recursos.gente -= 5;
                quemandose = false;
                contador = 0;
                alphaF = new Color(1f, 1f, 1f, 0f);
                Fuego.color = alphaF;
            }

            if (contador == 20)
            {
                spr.sprite = BosqueQuemado;
                quemandose = false;
                destrozado = true;
                contador = 0;
                alphaF = new Color(1f, 1f, 1f, 0f);
                Fuego.color = alphaF;
            }
        }
        
        
    }

    public int Directo()
    {
        metodo = 1;
        return metodo; //1 significa método Directo
    }
    
    public int Indirecto()
    {
        metodo = 2;
        return metodo; //2 significa método Indirecto
    }

}
