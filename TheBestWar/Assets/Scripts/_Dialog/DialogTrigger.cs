using UnityEngine;
using System.Collections;

public class DialogTrigger : MonoBehaviour {
	public Dialog dialog;

	public void TriggerDialog () {
		FindObjectOfType<DialogManager> ().StartDialog(dialog);
	}
}