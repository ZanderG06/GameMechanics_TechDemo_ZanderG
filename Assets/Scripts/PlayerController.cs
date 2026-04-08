using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 moveInput;

    public float speedBoostDuration;

    private Rigidbody playerRB;

    public TMP_Text scoreText;
    private int score;

    private Transform checkpoint;
    
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed * Time.deltaTime;
        playerRB.MovePosition(playerRB.position + move);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            score += 1000;
            scoreText.text = $"Score: {score:N0}";
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Checkpoint"))
        {
            checkpoint = other.transform;
        }
        if(other.CompareTag("KillBox"))
        {
            playerRB.position = checkpoint.position;
        }
        if(other.CompareTag("SpeedBoost"))
        {
            Destroy(other.gameObject);
            StartCoroutine(TemporarySpeedBoost(speedBoostDuration));
        }
    }

    private IEnumerator TemporarySpeedBoost(float duration)
    {
        moveSpeed *= 2;
        yield return new WaitForSeconds(duration);
        moveSpeed /= 2;
    }
}