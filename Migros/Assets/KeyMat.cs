using UnityEngine;

public class KeyMat : MonoBehaviour
{
	public bool status = false;
	public Color normalColor;
	public Color hoverColor;

	private void Start() {
		InputCast.Instance.ResetEvent += () => status = false;
	}

	private void Update() {
		GetComponent<Renderer> ().material.color = status ? hoverColor : normalColor;
	}
}