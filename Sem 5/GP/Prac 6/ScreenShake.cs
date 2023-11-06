using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public float shakeIntensity = 0.1f;
    public float shakeDuration = 0.2f;
    public KeyCode keyToStopShaking = KeyCode.Space;

    private Vector3 initialPosition;
    private float currentShakeDuration = 0f;

    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (currentShakeDuration > 0f)
        {
            Vector3 randomOffset = Random.insideUnitSphere * shakeIntensity;
            transform.localPosition = initialPosition + randomOffset;

            currentShakeDuration -= Time.deltaTime;
        }
        else
        {
            transform.localPosition = initialPosition;
        }

        // Keep the shaking effect going until the key is pressed
        if (Input.GetKey(keyToStopShaking))
        {
            currentShakeDuration = shakeDuration;
        }
    }

    public void StartShake()
    {
        currentShakeDuration = shakeDuration;
    }

    public void StopShake()
    {
        currentShakeDuration = 0f;
    }
}
