using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
   public Transform lookAt;
   public Transform camTransform;

   private Camera _cam;

   private float _distance = 10.0f;
   private float _currentX = 0.0f;
   private float _sensitivityX = 4.0f;
   private float _sensitivityY = 1.0f;

   private void Start()
   {
      camTransform = transform;
      _cam = Camera.main;

   }
}
