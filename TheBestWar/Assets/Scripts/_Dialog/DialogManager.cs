using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DialogManager : MonoBehaviour {
	public Text nameText;
	public Text dialogText;

	Queue<string> sentences;

	void Start () {
		sentences = new Queue<string> ();
	}

	public void StartDialog (Dialog dialog) {
//		Debug.Log ("Начался диалог с " + dialog.name);

		nameText.text = dialog.name;
		sentences.Clear ();

		foreach (string sentence in dialog.sentences) {
			sentences.Enqueue (sentence);
		}
		DisplayNextSentence ();
	}

	public void DisplayNextSentence () {
		if (sentences.Count == 0) {
			EndDialog ();
			return;
		}
		string sentence = sentences.Dequeue ();
		StopAllCoroutines ();
		StartCoroutine (TypeSentence (sentence));		//отвечает за вывод букв диалога

//		Debug.Log (sentence);
	}

	IEnumerator TypeSentence (string sentence) {
		dialogText.text = "";
		foreach (char letter in sentence.ToCharArray()) {
			dialogText.text += letter;
			yield return null;
		}
	}

	public void EndDialog () {
		Debug.Log ("Stop conversation");
	}
}