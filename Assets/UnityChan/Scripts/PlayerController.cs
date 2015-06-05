using UnityEngine;
using System.Collections;

namespace UnityChan
{
	public class PlayerController : MonoBehaviour {

		Animator anim;
		CapsuleCollider c;
		float baseHeight;
		UnityChanControlScriptWithRgidBody unitychan;

		// Use this for initialization
		void Start () {
			anim = GetComponent<Animator>();
			c = GetComponent<CapsuleCollider> ();
			baseHeight = c.height;
			unitychan = GetComponent<UnityChanControlScriptWithRgidBody> ();
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void OnGoal()
		{
			unitychan.enabled = false;
			anim.SetBool ("Win", true);
		}

		void OnCollisionStay(Collision c){
			if(c.gameObject.tag == "Floor"){
				transform.parent = c.gameObject.transform;
			}
		}
		
		void OnCollisionExit(Collision c){
			transform.parent = null;
		}
	}
}
