using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountDiamonds : MonoBehaviour {

	private Text txt;

	void Start () {
		txt = GetComponent <Text> ();
		txt.text = PlayerPrefs.GetInt ("Diamonds").ToString ();
	}
}
