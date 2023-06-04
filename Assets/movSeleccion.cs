using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movSeleccion : MonoBehaviour
{

    public float velocidad;
    public bool baja = true;
    private float contadorT;
    public float tiempoCambio = 3f;

    // Start is called before the first frame update
    void Start()
    {
        contadorT = tiempoCambio;
    }

    // Update is called once per frame
    void Update()
    {

        //bajar
        if(baja == true)
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;            
            
        }

        //subir
        if(baja == false )
        {

            transform.position += Vector3.up * velocidad * Time.deltaTime;

        }

        contadorT -= Time.deltaTime;

        if(contadorT <= 0)
        {
            contadorT = tiempoCambio;
            baja = !baja;
        }
    }
}
