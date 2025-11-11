using UnityEngine;
using UnityEngine.InputSystem;

public class Patctise : MonoBehaviour
{
    void Update()
    {
        //按下
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            print("press");
        }
        //放開
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            print("release");
        }
    }
}
