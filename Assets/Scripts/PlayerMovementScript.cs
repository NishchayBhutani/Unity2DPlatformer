using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript: MonoBehaviour
{
    public float moveSpeed = 6f;

    private float horizontalMovement;
    private Rigidbody2D rb; 
    private bool isFacingRight = true;

    void Awake() {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if((isFacingRight && horizontalMovement < 0) || (!isFacingRight && horizontalMovement > 0)) {
            isFacingRight = !isFacingRight;
            Flip();
        }
        rb.velocity = new Vector2(horizontalMovement * moveSpeed, rb.velocity.y);
    }

    public void Move(InputAction.CallbackContext context) {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }

    void Flip() {
        transform.Rotate(new Vector3(0f, 180f, 0f));
    }
}
