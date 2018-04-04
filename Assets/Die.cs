using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die {
	int faces;
	public Die(int faces) {
		this.faces = faces;
	}
	public int Roll(System.Random randomNumberGenerator) {
		return randomNumberGenerator.Next(0, faces) + 1;
	}
}
