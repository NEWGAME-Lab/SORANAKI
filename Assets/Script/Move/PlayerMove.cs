using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float x = 0;
        float y = 0;

        if (Keyboard.current.wKey.isPressed)
        {
            y = 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            y = -1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            x = -1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            x = 1;
        }

        Vector3 movement = new Vector3(x, y, 0).normalized;

        transform.position += movement * speed * Time.deltaTime;
    }
}