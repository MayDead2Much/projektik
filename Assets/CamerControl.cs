using UnityEngine;

public class CamerControl : MonoBehaviour 
{
	public Transform target;
	public float smoothSPeed = 0.125f;

	private Vector3 offset;


	void Start () 
	{
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.08f);
	}
}
