using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Taydogmus
{
    public class WorkPlaceUI : MonoBehaviour
    {
        public WorkplaceType WorkplaceType;

        public Button AddWorkerButton;
        public Button RemoveWorkerButton;

        private void Awake()
        {
            AddWorkerButton.onClick.AddListener(TryToAddWorker);
            RemoveWorkerButton.onClick.AddListener(TryToRemoveWorker);
        }

        private void TryToRemoveWorker()
        {
            //Request arm to remove worker
        }

        private void TryToAddWorker()
        {
            //Request worker to add worker
        }
    }
}