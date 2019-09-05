using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

// TODO Player hit cooldown
// TODO Spells
// TODO Better fighting system
public class PlayerController : MonoBehaviour 
{

	public GameObject player;
	public NavMeshAgent agent;
	public GameObject enemy;
	public Stats stats;
	private bool attacked;
	public float lastTime;
	public float time;

	void Start () {
		stats = new Stats(250, 150, 12, 1.5);
	}
	
	void Update (Collider other) {
		time += Time.deltaTime;

		if(Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)) {
				if (hit.transform.tag == "enemy")
				{
					enemy = hit.transform.gameObject;
				}
				else
					enemy = null;
				agent.SetDestination(hit.point);
				
			}
		}

		Attack();
	}

	/// <summary>
	///	Attacks
	/// </summary>
	void Attack()
	{	
		if(lastTime + stats.attackSpeed < time) {
			if (enemy != null && Input.GetMouseButtonDown(0))
			{
				enemy.GetComponent<EnemyController>().stats.hp -= 10;
				attacked = true;
				if(enemy.GetComponent<EnemyController>().stats.hp <= 0) {
					enemy.transform.position = enemy.transform.position - new Vector3(0.0f, 1.0f, 0.0f);
					Destroy(enemy, 1.0f);
				}
				lastTime = time;
			}	
		}
	}
}
