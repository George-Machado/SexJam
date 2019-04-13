using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
   public Transform lookAt;
   public Transform camTransform;

   private Camera _cam;
   private const float _yAngleMin = 0.0f;
   private const float _yAngleMax = 50.0f;

   private float _distance = 10.0f;
   private float _currentX = 0.0f;
   private float _currentY = 0.0f;
   private float _sensitivityX = 4.0f;
   private float _sensitivityY = 1.0f;

   private void Start()
   {
      camTransform = transform;
      _cam = Camera.main;

   }

   private void Update()
   {
      _currentX += Input.GetAxis("Mouse X");
      _currentY += Input.GetAxis("Mouse Y");

      _currentY = Mathf.Clamp(_currentY, _yAngleMin, _yAngleMax);

   }

   private void LateUpdate()
   {
      Vector3 dir = new Vector3(0,0,-_distance);
      Quaternion rotation = Quaternion.Euler(_currentY,_currentX,0);
      camTransform.position = lookAt.position + rotation * dir;
      camTransform.LookAt(lookAt.position);

   }
}
