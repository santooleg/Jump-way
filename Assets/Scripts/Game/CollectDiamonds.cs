using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectDiamonds : MonoBehaviour {

	public AudioClip collectDiamond;
 	public Text diamonds;

	void OnTriggerEnter (Collider other) {		
		if (other.tag == "Diamond") {
			Destroy (other.gameObject);
			PlayerPrefs.SetInt ("Diamonds", PlayerPrefs.GetInt ("Diamonds") + 1);
			diamonds.text = PlayerPrefs.GetInt ("Diamonds").ToString ();
			GetComponent <AudioSource> ().clip = collectDiamond;
			GetComponent <AudioSource> ().Play ();
		}
	}
}
