using System;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Will adjust the camera to follow and face a target
/// </summary>
public class CameraBehaviour : MonoBehaviour
{
    [Tooltip("What object should the camera be looking at")]
    public Transform target;

    [Tooltip("How offset will the camera be to the target")]
    public Vector3 offset = new Vector3(0, 3, -6);

    // How long the object should shake for.
    public float shakeDuration = 0.25f;
    private float _shakeDuration = 0.0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.3f;
    private float _shakeAmount = 0.3f;

    public void StartShake(){
        _shakeAmount = shakeAmount;
        _shakeDuration = shakeDuration;
    }

    private void Update()
    {
        var targetPosition = new Vector3(0, target.position.y, target.position.z);
        transform.position = targetPosition + offset;
        transform.LookAt(targetPosition);

        if (_shakeDuration < 0)
        {
            _shakeDuration = 0.0f;
        }
        else if (_shakeDuration > 0)
        {
            transform.localPosition = targetPosition + offset + UnityEngine.Random.insideUnitSphere * _shakeAmount;
            _shakeDuration -= Time.deltaTime;
            _shakeAmount -= shakeAmount * (Time.deltaTime / shakeDuration);
        }

    }


}