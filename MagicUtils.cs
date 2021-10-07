using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MagicUtils
{
    /// <summary>
    /// return Vector3 Mouse World Position using the main camera
    /// </summary>
    /// <returns></returns>
    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPosition(Mouse.current.position.ReadValue(), Camera.main);
        vec.z = 0f;
        return vec;
    }

    /// <summary>
    /// returns Vector3 Mouse World Position using the passed camera as a parameter
    /// </summary>
    /// <param name="worldCamera"></param>
    /// <returns></returns>
    public static Vector3 GetMouseWorldPosition(Camera worldCamera)
    {
        Vector3 vec = GetMouseWorldPosition(Mouse.current.position.ReadValue(), worldCamera);
        vec.z = 0f;
        return vec;
    }

    /// <summary>
    /// </summary>
    /// <param name="screenPosition"></param>
    /// <param name="worldCamera"> camera </param>
    /// <returns></returns>
    public static Vector3 GetMouseWorldPosition(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

    public static Vector3 GetMouseWorldPosition(Vector3 screenPosition)
    {
        Vector3 vec = GetMouseWorldPosition(screenPosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    /// <summary>
    /// Get random direction between -1 and 1 on X Y axis
    /// </summary>
    /// <returns></returns>
    public static Vector3 GetRandomDirectionXY()
    {
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    /// <summary>
    /// Get random direction between -1 and 1 on X Z axis
    /// Set a Y position, default is 0 (zero)
    /// </summary>
    /// <param name="yPos"></param>
    /// <returns></returns>
    public static Vector3 GetRandomDirectionXZ(float yPos = 0f)
    {
        return new Vector3(Random.Range(-1f, 1f), yPos, Random.Range(-1f, 1f));
    }
}
