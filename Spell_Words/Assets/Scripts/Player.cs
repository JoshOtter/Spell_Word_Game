using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public bool groundedPlayer;
    public float playerSpeed = 10.0f;
    public float jumpHeight = 2.0f;
    public float gravityValue = -45.0f;

    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar playerHealthBar;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();

        currentHealth = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        //PLAYER MOVEMENT
        //bool value assigned based on the status of the Grounded Player property in Unity.
        groundedPlayer = controller.isGrounded;
        //When the player is on the ground after falling, the player's y vector is set back to 0;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        //creates a Vector3 variable that contains the Horizontal and Vertical input information for the x and z axes.
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        // Changes the height position of the player.
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        
    }

    //PLAYER HEALTH DROP
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bombling")
        {
            currentHealth--;
            playerHealthBar.SetHealth(currentHealth);
        }
    }
}
