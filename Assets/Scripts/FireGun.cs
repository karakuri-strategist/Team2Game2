using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject bullet;
    public FirstPersonLook look;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            var shot = Instantiate(bullet, transform.position, Quaternion.identity);
            var rigidbody = shot.GetComponent<Rigidbody>();
            var velocity = look.LookDirection.normalized * 10f;
            Debug.Log(velocity);
            rigidbody.velocity = velocity;
        }
    }
}
