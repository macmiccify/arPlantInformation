using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TrackedImageChangeHandler : MonoBehaviour
{
    [Serializable]
    public struct MarkerPrefab
    {
        public string name;
        public GameObject prefab;
        public GameObject panel;
    }
    public List<MarkerPrefab> markerPrefabs = new List<MarkerPrefab>();
    ARTrackedImageManager arTrackedImageManager;

    void Awake()
    {
        arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }
    void OnEnable()
    {
        if (arTrackedImageManager != null)
        {
            arTrackedImageManager.trackedImagesChanged += OnImageChanged;
        }
    }
    void OnDisable()
    {
        if (arTrackedImageManager != null)
        {
            arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
        }
    }
    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            foreach (var markerPrefab in markerPrefabs)
            {
                if (markerPrefab.name == trackedImage.referenceImage.name)
                {
                    GameObject prefab = Instantiate(markerPrefab.prefab, trackedImage.gameObject.transform);
                    //GameObject panel = Instantiate(markerPrefab.panel, transform.position,transform.rotation);
                    continue;
                }
            }
        }
        foreach (var trackedImage in args.updated)
        {
            if (trackedImage.trackingState == TrackingState.Tracking)
            {
                trackedImage.gameObject.SetActive(true);
            }
           else
            {
                trackedImage.gameObject.SetActive(false);
            }
        }
    }
}
