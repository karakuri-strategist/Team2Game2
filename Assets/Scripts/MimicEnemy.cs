using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicEnemy : MonoBehaviour
{
    private new Animation animation;
    private new Rigidbody rigidbody;
    public FirstPersonLook playerLook;
    
    public GameObject player;
    private Rigidbody playerBody;
    private FirstPersonMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        rigidbody = GetComponent<Rigidbody>();
        playerBody = player.GetComponent<Rigidbody>();
        playerMovement = player.GetComponent<FirstPersonMovement>();
        animation.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = new Vector3(playerBody.velocity.x * -1, 0, playerBody.velocity.y * -1);
        rigidbody.velocity = velocity;
        transform.forward = playerLook.LookDirection * -1;
        if (velocity.magnitude != 0)
        {
            rigidbody.rotation = Quaternion.LookRotation(velocity);
        }
        if (playerMovement.IsMoving)
            animation.Play("Idle");
        else
            animation.Play("Walk");
    }
}
