using UnityEngine;
using System.Collections;

public class AIListener : MonoBehaviour {

    public Material successMaterial;

    Renderer renderer;
    public EventManager eventManager;
    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();
        eventManager.AddCharacterArrivedDelegate(OnCharacterArrivedAtWaypoint);

    }


    void OnCharacterArrivedAtWaypoint()
    {
        renderer.material = successMaterial;
    }
}
