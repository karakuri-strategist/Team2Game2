using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLock : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
        //transform.rotation = Quaternion.Euler(new Vector3(target.rotation.x,target.rotation.y,target.rotation.z));
    }
}