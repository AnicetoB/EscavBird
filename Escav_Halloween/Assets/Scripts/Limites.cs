using UnityEngine;
using System.Collections;

public class Limites : MonoBehaviour {

	void OnMouseOver(){
		//if(!GameControl.dead){
			GameControl.limit = true;
		//}
	}
}