using UnityEngine;

namespace Taydogmus
{
    [CreateAssetMenu(fileName = "WorkPlaceData", menuName = "WorkPlaceData SO", order = 0)]
    public class WorkPlaceData : ScriptableObject
    {
        public int maxWorkerCount;
    }
}