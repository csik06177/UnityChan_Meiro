using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		Debug.Log ("Goal!");
	}
}
