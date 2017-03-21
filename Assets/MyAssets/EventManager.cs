using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;

public class EventManager : MonoBehaviour {

    public UnityEvent characterEvents;

    // Use this for initialization
    void Start () {
        if (characterEvents == null)
            characterEvents = new UnityEvent();
    }
	
    public void NotifyCharacterArrived()
    {
        characterEvents.Invoke();
    }
}
