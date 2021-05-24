using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    public float gravity = -9.8f;
    private CharacterController charController;
    private CombatBase combatBase;
    
    void Awake()
    {
        combatBase = GetComponent<CombatBase>();
        charController = GetComponent<CharacterController>();
    }


    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        charController.Move(movement);

        if (Input.GetKeyUp("space"))
        {

            combatBase.TryAttack();
            Debug.Log("hit hit");
        }

    }

}



