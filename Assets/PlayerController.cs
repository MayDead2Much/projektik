using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

	public GameObject player;
	public NavMeshAgent agent;

	public Stats stats;

	// Use this for initialization
	void Start () {
		stats = new Stats(250, 150);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)) {
				agent.SetDestination(hit.point);
			}
		}
	}
}
