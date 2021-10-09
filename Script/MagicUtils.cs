using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

namespace Magic.Utils
{
    public struct MagicVector3
    {
        public float x;
        public float y;
        public float z;

        public MagicVector3(float x = 0f, float y = 0f, float z = 0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static MagicVector3 operator +(MagicVector3 a, UnityEngine.Vector2 b)
        {
            return new MagicVector3(a.x + b.x, a.y + b.y, a.z);
        }

        public static MagicVector3 operator +(MagicVector3 a, UnityEngine.Vector3 b)
        {
            return new MagicVector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static MagicVector3 operator +(UnityEngine.Vector3 a, MagicVector3 b)
        {
            return new MagicVector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static MagicVector3 operator +(MagicVector3 a, MagicVector3 b)
        {
            return new MagicVector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static MagicVector3 operator +(MagicVector3 a, MagicVector2 b)
        {
            return new MagicVector3(a.x + b.x, a.y + b.y, a.z);
        }
    }

    public struct MagicVector2
    {
        public float x;
        public float y;

        public MagicVector2(float x = 0f, float y = 0f)
        {
            this.x = x;
            this.y = x;
        }

        #region Add
        float Add(float a, float b) { return a + b; }

        public static MagicVector2 operator +(UnityEngine.Vector3 a, MagicVector2 b)
        {
            return new MagicVector2(a.x + b.x, a.y + b.y);
        }

        public static MagicVector2 operator +(UnityEngine.Vector2 a, MagicVector2 b)
        {
            return new MagicVector2(a.x + b.x, a.y + b.y);
        }

        public static MagicVector2 operator +(MagicVector2 a, UnityEngine.Vector2 b)
        {
            return new MagicVector2(a.x + b.x, a.y + b.y);
        }

        public static MagicVector2 operator +(MagicVector2 a, MagicVector2 b)
        {
            return new MagicVector2(a.x + b.x, a.y + b.y);
        }

        public static MagicVector2 operator +(MagicVector2 a, MagicVector3 b)
        {
            return new MagicVector2(a.x + b.x, a.y + b.y);
        }
        #endregion

        #region Subtraction
        float Sub(float a, float b) { return a - b; }

        public static MagicVector2 operator -(UnityEngine.Vector3 a, MagicVector2 b)
        {
            return new MagicVector2(a.x - b.x, a.y - b.y);
        }

        public static MagicVector2 operator -(UnityEngine.Vector2 a, MagicVector2 b)
        {
            return new MagicVector2( a.x - b.x, a.y - b.y);
        }

        public static MagicVector2 operator -(MagicVector2 a, UnityEngine.Vector2 b)
        {
            return new MagicVector2(a.x - b.x, a.y - b.y);
        }

        public static MagicVector2 operator -(MagicVector2 a, MagicVector2 b)
        {
            return new MagicVector2(a.x - b.x, a.y - b.y);
        }

        public static MagicVector2 operator -(MagicVector2 a, MagicVector3 b)
        {
            return new MagicVector2(a.x - b.x, a.y - b.y);
        }
        #endregion

        #region Multyplication
        float Mul(float a, float b) { return a * b; }

        public static MagicVector2 operator *(UnityEngine.Vector3 a, MagicVector2 b)
        {
            return new MagicVector2(a.x * b.x, a.y * b.y);
        }

        public static MagicVector2 operator *(UnityEngine.Vector2 a, MagicVector2 b)
        {
            return new MagicVector2(a.x * b.x, a.y * b.y);
        }

        public static MagicVector2 operator *(MagicVector2 a, UnityEngine.Vector2 b)
        {
            return new MagicVector2(a.x * b.x, a.y * b.y);
        }

        public static MagicVector2 operator *(MagicVector2 a, MagicVector2 b)
        {
            return new MagicVector2(a.x * b.x, a.y * b.y);
        }

        public static MagicVector2 operator *(MagicVector2 a, MagicVector3 b)
        {
            return new MagicVector2(a.x * b.x, a.y * b.y);
        }
        #endregion

        #region Division
        float Div(float a,b) { return a / base; }

        public static MagicVector2 operator *(UnityEngine.Vector3 a, MagicVector2 b)
        {
            return new MagicVector2(Div(a.x, b.x), Div(a.y, b.y);
        }

        public static MagicVector2 operator *(UnityEngine.Vector2 a, MagicVector2 b)
        {
            return new MagicVector2(Div(a.x, b.x), Div(a.y, b.y);
        }

        public static MagicVector2 operator *(MagicVector2 a, UnityEngine.Vector2 b)
        {
            return new MagicVector2(Div(a.x, b.x), Div(a.y, b.y);
        }

        public static MagicVector2 operator *(MagicVector2 a, MagicVector2 b)
        {
            return new MagicVector2(Div(a.x, b.x), Div(a.y, b.y);
        }

        public static MagicVector2 operator *(MagicVector2 a, MagicVector3 b)
        {
            return new MagicVector2(Div(a.x, b.x), Div(a.y, b.y);
        }
        #endregion
    }

    public static class MagicUtils
    {
        /// <summary>
        /// Convert a MagicVector3 to standard unity Vector3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static MagicVector3 ConvertToMagicVector(this UnityEngine.Vector3 a)
        {
            return new MagicVector3(a.x, a.y, a.z);
        }

        /// <summary>
        /// Convert a standard unity Vector3 to a MagicVector3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static UnityEngine.Vector3 ConvertToUnityVector(this MagicVector3 a)
        {
            return new UnityEngine.Vector3(a.x, a.y, a.z);
        }

        /// <summary>
        /// Convert a standard unity Vector2 to a MagicVector3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static MagicVector3 ConvertToMagicVector(this UnityEngine.Vector2 a)
        {
            return new MagicVector3(a.x, a.y, 0f);
        }

        /// <summary>
        /// Convert a MagicVector2 to standard unity Vector3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static UnityEngine.Vector3 ConvertToUnityVector(this MagicVector2 a)
        {
            return new UnityEngine.Vector3(a.x, a.y, 0f);
        }


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
        /// Return the same vector with absolute value of XYZ
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static Vector3 VectorAbs(Vector3 pos)
        {
            return new Vector3(Mathf.Abs(pos.x), Mathf.Abs(pos.y), Mathf.Abs(pos.z));
        }

        /// <summary>
        /// Return the same vector with absolute value of XY
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static Vector2 VectorAbs(Vector2 pos)
        {
            return new Vector2(Mathf.Abs(pos.x), Mathf.Abs(pos.y));
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
            return new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
        }

        /// <summary>
        /// Get random direction between -1 and 1 on X Z axis
        /// Set a Y position, default is 0 (zero)
        /// </summary>
        /// <param name="yPos"></param>
        /// <returns></returns>
        public static Vector3 GetRandomDirectionXZ(float yPos = 0f)
        {
            return new Vector3(UnityEngine.Random.Range(-1f, 1f), yPos, UnityEngine.Random.Range(-1f, 1f));
        }

        public static Vector3 GetVectorFromAngle(float angle)
        {
            float angleRad = Mathf.Abs(angle) * (Mathf.PI / 180f);
            return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
        }

        public static Vector3 GetVectorFromAngle(int angle)
        {
            float angleRad = Mathf.Abs(angle) * (Mathf.PI / 180f);
            return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
        }

        /// <summary>
        /// Max is inclusive
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static float GetRandomNumber(float min = 0f, float max = 100f)
        {
            return UnityEngine.Random.Range(min, max);
        }

        /// <summary>
        /// Max is inclusive
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomNumber(int min = 0, int max = 100)
        {
            max += 1;
            return UnityEngine.Random.Range(min, max);
        }
    }
}
