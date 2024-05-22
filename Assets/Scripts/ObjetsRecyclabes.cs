using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsRecyclabes : MonoBehaviour
{
    [SerializeField] private CollectableObjects collectableObjects;
    [SerializeField] private GameEvent ajoutPointage;
    private void private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Bin") 
        {
            ajoutPointage.Raise(this, collectableObjects.pointage);
        }
    }
}
