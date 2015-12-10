using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor(typeof(EnableSpriteShadow))]
public class Inspector_EnableSpriteShadow : Editor {
	public override void OnInspectorGUI()
	{
		EnableSpriteShadow targeted = (EnableSpriteShadow)target;
		DrawDefaultInspector ();
		if (GUI.changed)
			targeted.SendMessage ("Reset");
	}
}
