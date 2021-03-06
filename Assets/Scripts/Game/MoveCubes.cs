using UnityEngine;
using System.Collections;

public class MoveCubes : MonoBehaviour {

	private bool moved = true;
	private Vector3 target;

	void Start () {
		target = new Vector3 (-3.91f, 5f, -0.24f);
	}

	void Update () { // Every frame
		if (CubeJump.nextBlock) {
			if (transform.position != target)
				transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * 5f);
			else if (transform.position == target && !moved) {
				target = new Vector3 (transform.position.x - 2.75f, transform.position.y + 2.29f, transform.position.z);
				CubeJump.jump = false;
				moved = true;
			}		

			if (CubeJump.jump)
				moved = false;
		}
	}
}
