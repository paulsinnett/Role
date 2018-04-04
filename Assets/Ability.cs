using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability {
	int value;
	public Ability(int value) {
		this.value = value;
	}
	public Ability(System.Random randomNumberGenerator) {
		List<int> rolls = new List<int>();
		Die d = new Die(6);
		for (int i = 0; i < 4; ++i) {
			rolls.Add(d.Roll(randomNumberGenerator));
		}
		rolls.Sort();
		rolls.RemoveAt(0);
		this.value = 0;
		foreach (int roll in rolls) {
			this.value += roll;
			Debug.Log(roll);
		}
	}
	public int Modifier() {
		return (value - 10) / 2;
	}

}
