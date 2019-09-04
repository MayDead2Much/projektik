using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

	public GameObject player;
	public NavMeshAgent agent;
	public GameObject enemy;
	public Stats stats;
	private bool attacked;

	// Use this for initialization
	void Start () {
		stats = new Stats(250, 150, 12);
		attacked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)) {
				if (hit.transform.tag == "enemy")
				{
					enemy = hit.transform.gameObject;
					Attack();
					attacked = false;
				}
				else
					enemy = null;
				agent.SetDestination(hit.point);
				
			}
		}
	}

	void Attack()
	{
		if (enemy != null && Input.GetMouseButton(0) && attacked == false)
		{
			enemy.GetComponent<EnemyController>().stats.hp -= 10;
			attacked = true;
			if(enemy.GetComponent<EnemyController>().stats.hp <= 0) {
				enemy.transform.position = enemy.transform.position - new Vector3(0.0f, 1.0f, 0.0f);
				Destroy(enemy, 1.0f);
			}
		}
	}
}
