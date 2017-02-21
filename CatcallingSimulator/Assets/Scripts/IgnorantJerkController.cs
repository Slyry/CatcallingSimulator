using UnityEngine;
using System.Collections;

public class IgnorantJerkController : MonoBehaviour {

    GameObject player;
    NavMeshAgent agent;
	// Use this for initialization

	void Start () {
        player = GameObject.Find("FPSController");
        agent = GetComponent<NavMeshAgent>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if ((agent.transform.position - player.transform.position).magnitude < 3f)
            agent.Stop();
         
	}


    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.name == "FPSController")
            agent.SetDestination(player.transform.position);
    }

}
