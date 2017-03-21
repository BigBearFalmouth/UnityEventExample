using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;

public class EventManager : MonoBehaviour {


    public delegate void OnCharacterArrivedAtWaypoint();
    public event OnCharacterArrivedAtWaypoint characterArrivedDelegate;

    public List<OnCharacterArrivedAtWaypoint> characterArrivedDelegates= new List<OnCharacterArrivedAtWaypoint>();

    // Use this for initialization
    void Start () {
    }
	

    public void AddCharacterArrivedDelegate(OnCharacterArrivedAtWaypoint arrivedDelegate)
    {
        characterArrivedDelegate += arrivedDelegate;
        characterArrivedDelegates.Add(arrivedDelegate);
    }

    public void RemoveCharacterArrivedDelegate(OnCharacterArrivedAtWaypoint arrivedDelegate)
    {
        characterArrivedDelegate -= arrivedDelegate;
        characterArrivedDelegates.Remove(arrivedDelegate);
    }

    public void NotifyCharacterArrived()
    {
        characterArrivedDelegate();
    }

    void ClearArrivedDelegates()
    {
        for(int i=0;i<characterArrivedDelegates.Count;i++)
        {
            RemoveCharacterArrivedDelegate(characterArrivedDelegates[i]);
        }

        characterArrivedDelegates.Clear();
    }

    void OnDestroy()
    {
        ClearArrivedDelegates();
    }
}
