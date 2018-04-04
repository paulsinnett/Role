using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAbility : MonoBehaviour {
	void Start () {

		System.Random randomNumberGenerator = new System.Random(0);
		Ability ability = new Ability(randomNumberGenerator);
		Debug.Log(ability.Modifier());		
	}
}
