using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class SE : MonoBehaviour {
	public AudioClip[] seLists;//効果音リスト
	AudioSource source;//AudioSource

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();//AudioSource獲得

	}
	
	public void koukaon(int i)
	{
		source.PlayOneShot (null);//効果音停止
		source.PlayOneShot(seLists[i]);//効果音
		return;
	}

}
