using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoIzquierda : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float disappearTime = 10f;
    private float elapsedTime = -5f;

   void Update()
{
    // Mover el sprite de derecha a izquierda
    transform.Translate(Vector3.right * speed * Time.deltaTime);

    // Incrementar el tiempo transcurrido
    elapsedTime += Time.deltaTime;

    // Si se ha alcanzado el tiempo de desaparición, destruir el objeto sprite
    if (elapsedTime >= disappearTime)
    {
        Destroy(gameObject);
    }
}
}
