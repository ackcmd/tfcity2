using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private float speed = 8.0f;
	private float zoomSpeed = 4.0f;

	public float minX = -360.0f;
	public float maxX = 360.0f;
	
	public float minY = -120.0f;
	public float maxY = 0.0f;

	public float sensX = 100.0f;
	public float sensY = 100.0f;
	
	float rotationY = 0.0f;
	float rotationX = 0.0f;
    private void Start()
    {
        rotationX = transform.localEulerAngles.x;
        rotationY = -transform.localEulerAngles.y;
    }
    void Update () {

		float scroll = Input.GetAxis("Mouse ScrollWheel");
        //transform.Translate(0, scroll * zoomSpeed, scroll * zoomSpeed, Space.Self);
        transform.Translate(0, 0, scroll * zoomSpeed, Space.Self);

        if (Input.GetKey(KeyCode.RightArrow)){
            //transform.position += Vector3.right * speed * Time.deltaTime;
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }
		if (Input.GetKey(KeyCode.LeftArrow)){
            //transform.position += Vector3.left * speed * Time.deltaTime;
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
        }
		if (Input.GetKey(KeyCode.UpArrow)){
            //transform.position += Vector3.forward * speed * Time.deltaTime;
            //transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
            transform.Translate(0, speed * Time.deltaTime, speed * Time.deltaTime, Space.Self);
        }
		if (Input.GetKey(KeyCode.DownArrow)){
            //transform.position += Vector3.back * speed * Time.deltaTime;
            //transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
            transform.Translate(0, -speed * Time.deltaTime, -speed * Time.deltaTime, Space.Self);
        }

		if (Input.GetMouseButton (1)) {
			rotationX += Input.GetAxis ("Mouse X") * sensX * Time.deltaTime;
			rotationY += Input.GetAxis ("Mouse Y") * sensY * Time.deltaTime;
			//rotationY = Mathf.Clamp (rotationY, minY, maxY);
			transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
		}

    }
}
