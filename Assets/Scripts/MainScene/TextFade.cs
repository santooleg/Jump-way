﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFade : MonoBehaviour {

	private Text txt;
	private Outline oLine;

	void Start () {
		txt = GetComponent <Text> ();
		oLine = GetComponent <Outline> ();
	}

	void Update () {
		txt.color = new Color (txt.color.r, txt.color.g, txt.color.b, Mathf.PingPong (Time.time / 2.5f, 1f));
		oLine.effectColor = new Color (oLine.effectColor.r, oLine.effectColor.g, oLine.effectColor.b, txt.color.a - 0.3f);
	}
}
