using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFoolow : MonoBehaviour
{
   public Transform target;        // Об'єкт за яким слідкує камера (персонаж)
    public float smoothSpeed = 0.125f;  // Плавність руху камери
    public Vector3 offset;          // Зсув камери відносно персонажа

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);  // Зберігаємо z позицію камери
    }
}
