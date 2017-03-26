using UnityEngine;
using System.Collections;

public class AIStatusUpdater : MonoBehaviour {

    NavMeshAgent agent;
    public GameObject listener;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}

    // Update is called once per frame
    void Update()
    {
        float distance = agent.remainingDistance;

        if (!agent.pathPending && distance != Mathf.Infinity && agent.pathStatus == NavMeshPathStatus.PathComplete && distance <= Mathf.Epsilon)
        {
            listener.SendMessage("OnCharacterArrivedAtWaypoint");
        }
        else
        {
            listener.BroadcastMessage("OnCharacterNotArrivedAtWaypoint");
        }
    }
}
