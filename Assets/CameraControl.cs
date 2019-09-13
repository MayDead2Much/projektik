using UnityEngine;

public class CameraControl : MonoBehaviour 
{
	public Transform target;
	private Vector3 offset;
	private float zoom = 80f;
	private Vector3 camreaFollowPosition;
	void Start () 
	{
		offset = transform.position - target.transform.position;
	}
	
	void Update () 
	{
		transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.08f);

		offset += Vector3.Normalize(offset * Input.mouseScrollDelta.y * -100);
	}
}
