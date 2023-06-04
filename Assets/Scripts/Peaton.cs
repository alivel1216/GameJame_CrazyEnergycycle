using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peaton : MonoBehaviour
{
    private Animator animator;

    public float cambio= 0;

    public float velocidad=0;
    public bool baja = true;
    public float contadorT;
    public float tiempoCambio = 3f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        contadorT = tiempoCambio;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("cambio",cambio);

        //bajar
        if(baja == true)
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;


            if(cambio > 0 && baja == true){
                
                velocidad = 1;
                cambio = 1;

                velocidad = 0;
                cambio = 0;
            }
            
            
            
        }

        //subir
        if(baja == false )
        {
            if(cambio <0.1 && baja == false){
                velocidad =1;
                cambio =1;
            }
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
