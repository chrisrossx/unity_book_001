using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleCollision : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }


    // void OnCollisionEnter(Collision collision)
    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Entered collision with " + collision.gameObject.name);

        if (other.gameObject.name == "Player")
        {
            Destroy(transform.parent.gameObject, 0);
            var gm = GameObject.FindObjectOfType<CameraBehaviour>();
            // gm.shakeDuration = 0.25f;
            gm.StartShake();
        }


    }

    // // Gets called during the collision
    // void OnCollisionStay(Collision collision)
    // {
    //     Debug.Log("Colliding with " + collision.gameObject.name);
    // }

    // // Gets called when the object exits the collision
    // void OnCollisionExit(Collision collision)
    // {
    //     Debug.Log("Exited collision with " + collision.gameObject.name);
    // }

}
