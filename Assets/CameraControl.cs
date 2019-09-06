using UnityEngine;

public class CameraControl : MonoBehaviour 
{
	[SerializeField] private CameraFollow cameraFollow;
	public Transform target;
	private Vector3 offset;
	private float zoom = 80f;
	private Vector3 camreaFollowPosition;
	void Start () 
	{
		offset = transform.position - target.transform.position;
		cameraFollow.Setup(() => camreaFollowPosition, () => zoom);
	}
	
	void Update () 
	{
		transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.08f);

		float zoomChangeAmount = 80f;
		if (Input.GetKey(KeyCode.KeypadPlus))
		{
			zoom -= zoomChangeAmount * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.KeypadMinus))
		{
			zoom += zoomChangeAmount * Time.deltaTime;
		}

		if (Input.mouseScrollDelta.y > 0)
		{
			zoom -= zoomChangeAmount * Time.deltaTime;
		}

		if (Input.mouseScrollDelta.y < 0)
		{
			zoom += zoomChangeAmount * Time.deltaTime;
		}
	}
}
