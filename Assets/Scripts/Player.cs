using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float speed = 3f;
    Rigidbody2D jugador;
    Vector2 moveInput;
    Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
        playerAnim.SetFloat("Horizontal", moveX);
        playerAnim.SetFloat("Vertical", moveY);
        playerAnim.SetFloat("Speed", moveInput.sqrMagnitude);
        
    }
     private void FixedUpdate()
    {
        jugador.MovePosition(jugador.position + moveInput * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
}
