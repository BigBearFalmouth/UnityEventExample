using UnityEngine;
using System.Collections;

public class AIListener : MonoBehaviour {

    public Material successMaterial;

    Renderer renderer;
    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();
    }


    public void OnCharacterArrivedAtWaypoint()
    {
        renderer.material = successMaterial;
    }
}
