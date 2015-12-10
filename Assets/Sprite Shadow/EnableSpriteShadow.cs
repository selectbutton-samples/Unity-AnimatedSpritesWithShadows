using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

[ExecuteInEditMode]
public class EnableSpriteShadow : MonoBehaviour {

	[SerializeField]
	private static string		spriteMaterial = "Sprites-Default";
	[SerializeField]
	private Material 			defaultMaterial;
	[SerializeField]
	private Renderer 			targetRenderer;
	[SerializeField]
	private ShadowCastingMode 	shadowCastMode = ShadowCastingMode.TwoSided;
	[SerializeField]
	private bool 				receiveShadows = false;
	
	void Awake(){
		if (targetRenderer || (targetRenderer = GetComponent<Renderer>()))
		{
			if (targetRenderer.sharedMaterial.name == spriteMaterial && defaultMaterial)
				targetRenderer.sharedMaterial 	= defaultMaterial;
			targetRenderer.shadowCastingMode 	= shadowCastMode;
			targetRenderer.receiveShadows 		= receiveShadows;
		}
	}

	void Reset(){
		Awake ();
	}

	void Start () {
		Awake ();
	}
}
