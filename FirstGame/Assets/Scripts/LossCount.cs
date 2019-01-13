using UnityEngine;
using UnityEngine.UI;


public class LossCount : MonoBehaviour
{
	public Text losses;

	void Update() {
		string loss = PlayerPrefs.GetInt("lose").ToString("0");
		losses.text = loss;
	}
}
