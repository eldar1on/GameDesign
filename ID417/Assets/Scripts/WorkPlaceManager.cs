using System;
using AYellowpaper.SerializedCollections;
using UnityEngine;

namespace Taydogmus
{
    public class WorkPlaceManager : MonoBehaviour
    {
        [SerializedDictionary("WorkplaceType", "Workplace")]
        public SerializedDictionary<WorkplaceType, BaseWorkPlace> WorkPlaces;    
    }
    
    
}