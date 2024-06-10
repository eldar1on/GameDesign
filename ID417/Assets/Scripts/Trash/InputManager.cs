using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class InputManager : MonoBehaviour
    {
        private Vector3 inputVector;

        public Vector3 InputVector => inputVector;
        
        private void Update()
        {
            inputVector = Vector3.zero;
            inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
    }
}