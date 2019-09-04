using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	public float detectionRadius = 6.0f;

	public GameObject player;
	public bool chase = false;

	public float fireRate = 1.0f;
	public Stats stats;
	// Use this for initialization
	void Start () {
		stats = new Stats(100, 75, 8);
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(player.transform.position, transform.position) < detectionRadius) {
			chase = true;
		}

		if(chase) {
			GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
		}
	}
}
