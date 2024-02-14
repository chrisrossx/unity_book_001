using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{

    /// <summary>
    /// A reference to the Rigidbody component
    /// </summary> 
    private Rigidbody rb;
    // How fast the ball moves left/right
    [Tooltip("How fast the ball moves left/right")]
    public float dodgeSpeed = 5;
    // How fast the ball moves forward automatically
    [Tooltip("How fast the ball moves forward automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5F;

    // Start is called before the first frame update
    void Start()
    {
        // Get access to our Rigidbody component
        rb = GetComponent<Rigidbody>();
        // Vector3 a = new Vector3(0,10,0);
        // rb.AddTorque(a);
        // rb.AddForce(0, 0, 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Check if we're moving to the side
        var horizontalSpeed =
            Input.GetAxis("Horizontal") * dodgeSpeed;
        var verticalSpeed = Input.GetAxis("Vertical") * dodgeSpeed;
        // rb.AddForce(horizontalSpeed, 0, rollSpeed);
        verticalSpeed = 5;
        rb.AddForce(horizontalSpeed, 0, verticalSpeed);

    }
}
