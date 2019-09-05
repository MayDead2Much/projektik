using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour 
{
	public float detectionRadius = 6.0f;
	public GameObject player;
	public bool chase = false;
	public Stats stats;
	public float hitRadius = 3.0f;
	public float time;
	public float lastTime;

	void Start () {
		stats = new Stats(100, 75, 8, 2);
	}
	
	void Update () {
		time += Time.deltaTime;
		if(Vector3.Distance(player.transform.position, transform.position) < detectionRadius) {
			chase = true;
		}

		if(chase) {
			GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
		}

		if(lastTime + stats.attackSpeed < time) {
			if(Vector3.Distance(player.transform.position, transform.position) < hitRadius) {
				player.GetComponent<PlayerController>().stats.hp -= stats.attack;
				player.GetComponent<Rigidbody>().AddForce(Vector3.Normalize(player.transform.position - transform.position) * 500.0f, ForceMode.Force);
				lastTime = time;
			}
		}

		player.GetComponent<Rigidbody>().velocity = Vector3.Lerp(player.GetComponent<Rigidbody>().velocity, Vector3.zero, 0.25f);
	}
}
