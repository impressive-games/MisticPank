using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogManager : MonoBehaviour {
	Queue<string> sentences;

	void Start () {
		sentences = new Queue<string> ();
	}

	public void StartDialog (Dialog dialog) {
		Debug.Log ("Начался диалог с " + dialog.name);
	}
}