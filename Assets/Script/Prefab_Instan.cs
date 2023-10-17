using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Prefab_Instan : DefaultObserverEventHandler
     
{
    public GameObject modelPrefab;
    GameObject modelObject;

    protected override void OnTrackingFound()
    {
        Debug.Log("Target Found");

        if (modelObject == null)
            InstantiatePrefab();

        base.OnTrackingFound();

    }

    void InstantiatePrefab()
    {
        if(modelPrefab != null)
        {
            Debug.Log("Target found, instantiating");
            modelObject = Instantiate(modelPrefab, mObserverBehaviour.transform);
            modelObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            modelObject.SetActive(true);
        }
    }
}
