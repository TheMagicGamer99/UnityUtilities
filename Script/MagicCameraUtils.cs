using System.Collections;
using UnityEngine;

namespace Magic.Utils
{
    public class MagicCameraUtils : MonoBehaviour
    {
        static MagicCameraUtils instance;

        private void Awake()
        {
            if (instance != null && instance != this)
                Destroy(gameObject);
            else
                instance = this;
        }

        public static void CameraShake(float duration = .12f, float force = .12f)
        {
            instance.StartCoroutine(instance.CameraShakeEnum(duration, force, Camera.main));
        }

        public static void CameraShake(Camera cam, float duration = .12f, float force = .12f)
        {
            instance.StartCoroutine(instance.CameraShakeEnum(duration, force, cam));
        }

        IEnumerator CameraShakeEnum(float duration, float force, Camera cam)
        {
            Vector3 myPos = cam.transform.position;
            float elaspedTime = 0f;

            while (elaspedTime < duration)
            {
                float x = Random.Range(-1f, 1f) * force;
                float z = Random.Range(-1f, 1f) * force;
                cam.transform.position = new Vector3(myPos.x + x, myPos.y, myPos.z + z);
                elaspedTime += Time.unscaledDeltaTime;

                yield return null;
            }
            cam.transform.position = myPos;
        }
    }
}

