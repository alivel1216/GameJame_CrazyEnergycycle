using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCarro : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float disappearTime = 7f;
    private float elapsedTime = -5f;

    void Update()
    {
        // Mover el sprite de derecha a izquierda
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Incrementar el tiempo transcurrido
        elapsedTime += Time.deltaTime;

        // Si se ha alcanzado el tiempo de desaparición, destruir el objeto sprite
       
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }

    }

}
