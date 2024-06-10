using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Taydogmus
{
    public abstract class BaseWorkPlace : MonoBehaviour
    {
        public WorkplaceType _workplaceType;
        
        public List<WorkPlaceData> _workPlaceDatas;
        public List<EmployeeSlot> _employeeSlots;

        public void TakeEmployee()
        {
            
        }

        public void ReleaseEmployee(int index)
        {
            
        }
        
        public void ReleaseAllEmployee()
        {
            
        }
        
    }
    
    public enum WorkplaceType
    {
        RestPlace,
        DevPlace,
        ArtPlace,
        HrPlace,
        FirePlace
    }
}
