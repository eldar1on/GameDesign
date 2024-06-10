using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Door
{
    public class DoorSensor : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
            
            }
        }
    }   
}
