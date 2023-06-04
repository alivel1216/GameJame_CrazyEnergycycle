using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letrasMov : MonoBehaviour
{
    public float velocidad = 1;
    public bool baja ;
    public float tiempoCambio = .1f;
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
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }

        if(baja == false)
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }

        contadorT -= Time.deltaTime;

        if(contadorT <= 0)
        {
            contadorT = tiempoCambio;
            baja = !baja;
        }

    }
}
