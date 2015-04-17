﻿// RopeTape script
// Copyright (C) 2013 Sergey Taraban <http://staraban.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticlesController))]
public class ExpCurve : MonoBehaviour {
	
	ParticlesController mParticlesController = null;
	
	float timer = 0;
	float mPhase = 0;
	
	public float Amplitude = 9.56f;
	public float AmplitudeZ = 25.4f;
	public float XIncrement = 69.97f;
	public float dx = -4.85f; 
	public float PhaseIncrement = 0.17f;
	public float Width = 1.54f;
	
	bool CompletedOnePeriod = false;
	
	// Use this for initialization
	void Start () {
		mParticlesController = GetComponent<ParticlesController>();
	}
	
	// Update is called once per frame
	void Update () {
		mPhase += PhaseIncrement*Time.deltaTime*Mathf.PI;
		
		if (mPhase > 6.11f && mPhase < 6.28f) { // 350 degrees to 360 degrees
			CompletedOnePeriod = true;
		}
		
		if(mParticlesController.IsReadyToUse() && !CompletedOnePeriod) 
		{
			timer += Time.deltaTime;
			int particlesNum = mParticlesController.particleSystem.particleCount;
			mParticlesController.SetVertexCount(particlesNum);
			float t = 0;
			float fy = 0;
			float fz = 0;
			float dl = 0.01f;
			for(int i = 0; i < particlesNum; i++) 
			{
				fy = Amplitude * Mathf.Sin(t + mPhase);
				fz = AmplitudeZ * Mathf.Sin(t + mPhase);
				mParticlesController.SetPosition(i, transform.position + new Vector3(dx*i, fy, fz));
				t += XIncrement*0.001f*Mathf.PI;
				mParticlesController.SetScale(i, Width);
			}
		}
	}
}