using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll {
	List<Die> dice;
	int modifier;
	public Roll(IEnumerable<Die> dice, int modifier) {
		this.dice = new List<Die>(dice);
		this.modifier = modifier;
	}
	public int Total(System.Random randomNumberGenerator) {
		int total = modifier;
		foreach (Die d in dice) {
			total += d.Roll(randomNumberGenerator);
		}
		return total;
	}
}

