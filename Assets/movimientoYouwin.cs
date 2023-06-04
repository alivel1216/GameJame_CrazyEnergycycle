using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoYouwin : MonoBehaviour
{

    public float velocidad =1f;
    public bool baja ;
    public float tiempoCambio = .25f;
    public float contadorT;

    // Start is called before the first frame update
    void Start()
    {
        contadorT = tiempoCambio;
    }

    // Update is called once per frame
    void Update()
    {
        if(baja == true)
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
        }

        if(baja == false)
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
