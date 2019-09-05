using UnityEngine;

public class CameraControl : MonoBehaviour 
{
	public Transform target;
	private Vector3 offset;

	void Start () 
	{
		offset = transform.position - target.transform.position;
	}
	
	void Update () 
	{
		transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.08f);
	}
}
