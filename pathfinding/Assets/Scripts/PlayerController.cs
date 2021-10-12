using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variable for the CharacterController component
    CharacterController characterController;
    
    // The speed of the player
    [SerializeField]
    float playerSpeed;

    void Start()
    {
        // Assign the character controller
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Assign a vector for the axis' of the game and move character based on input
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}
