﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour {
	public float Intensity;
	void Update()
	{
		Mathf.Clamp01 (Intensity);
	}
}