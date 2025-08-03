using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Pega o componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura entrada do jogador (WASD ou setas)
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D ou ←/→
        movement.y = Input.GetAxisRaw("Vertical");   // W/S ou ↑/↓
    }

    void FixedUpdate()
    {
        // Move o personagem
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

