using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour 
{
	public float scrollPower = 5f;
	public float movePower = 3f;
	public int minZoom = 1;
	public int maxZoom = 100;
	public enum _cd{
		XY,
		XZ, 
		YZ
	}	
	public _cd ControlDirection;
	
	Camera _me;
	float ortosize;
	void Start ()
	{
		_me = GetComponent<Camera>();
		ortosize = _me.orthographicSize;
	}
	
	void Update () 
	{
		if (Input.GetMouseButton(0)){
			switch (ControlDirection){
				case _cd.XY :
					_me.transform.position += new Vector3(0, -Input.GetAxis("Mouse Y") * movePower, -Input.GetAxis("Mouse X") * movePower);
				break;
				case _cd.XZ :
					_me.transform.position += new Vector3(Input.GetAxis("Mouse Y") * movePower, 0, - Input.GetAxis("Mouse X") * movePower);
				break;
				case _cd.YZ :
					_me.transform.position += new Vector3(-Input.GetAxis("Mouse X") * movePower, - Input.GetAxis("Mouse Y") * movePower, 0);
				break;
			}
			
		}
		if (Input.GetAxis("Mouse ScrollWheel") !=0 ){
			ortosize -= Input.GetAxis("Mouse ScrollWheel") * scrollPower;
			ortosize = Mathf.Clamp(ortosize, minZoom, maxZoom);
			_me.orthographicSize = ortosize;
		}
	}
}