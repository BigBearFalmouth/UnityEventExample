using UnityEngine;
using System.Collections;

public class AIListener : MonoBehaviour {

    public Material successMaterial;
    public Material notSuccessMaterial;

    Renderer renderer;
    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();
    }


    public void OnCharacterArrivedAtWaypoint()
    {
        renderer.material = successMaterial;
    }

    public void OnCharacterNotArrivedAtWaypoint()
    {
        renderer.material = notSuccessMaterial;
    }
}
