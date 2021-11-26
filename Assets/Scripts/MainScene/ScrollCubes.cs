using UnityEngine;
using System.Collections;

public class ScrollCubes : MonoBehaviour {

	public GameObject cubes;
	private Vector3 screenPoint, offset;
	private float _lockedYPos;

	void Update () {
		if (cubes.transform.position.x > 0)
			cubes.transform.position = Vector3.MoveTowards (cubes.transform.position, new Vector3 (0f, cubes.transform.position.y, cubes.transform.position.z), Time.deltaTime * 10f);
		else if (cubes.transform.position.x < -7.23f)
			cubes.transform.position = Vector3.MoveTowards (cubes.transform.position, new Vector3 (-7.23f, cubes.transform.position.y, cubes.transform.position.z), Time.deltaTime * 10f);
	}

	void OnMouseDown () {
		_lockedYPos = 0.65f;
		offset = cubes.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		Cursor.visible = false;
	}

	void OnMouseDrag () {
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		curPosition.y = _lockedYPos;
		cubes.transform.position = curPosition;
	}

	void OnMouseUp () {
		Cursor.visible = true;
	}

}
