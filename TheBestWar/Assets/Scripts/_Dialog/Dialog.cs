using UnityEngine;
using System.Collections;

[System.Serializable]
public class Dialog {
	public string name;

	[TextArea(3,7)]
	public string[] sentences;
}