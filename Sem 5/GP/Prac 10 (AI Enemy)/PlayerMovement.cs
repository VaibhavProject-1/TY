using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        // PC Controls using arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
#elif UNITY_ANDROID
        // Android Touch Controls
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0; // Ensure the touch is on the same Z-plane as your player
            transform.position = Vector3.MoveTowards(transform.position, touchPos, moveSpeed * Time.deltaTime);
        }
#endif
    }
}
