﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	
	public static void SetMasterVolume(float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("Master volume out of range");
		}
	}
	
	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	public static void UnlockLevel(int level) {
		if (level < Application.levelCount) {
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
		} else {
			Debug.LogError("Trying to unlock error not in build order");
		}
	}
	
	public static bool IsLevelUnlocked(int level) {
		if (level >= Application.levelCount) {
			Debug.LogError("Trying to query level not in build order: " + level);
			return false;
		}
		
		string expectedLevelKey = LEVEL_KEY + level.ToString();
		return PlayerPrefs.HasKey(expectedLevelKey) && PlayerPrefs.GetInt(expectedLevelKey) == 1;
	}
	
	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	
	public static void SetDifficulty(float difficulty) {
		if (difficulty >= 1 && difficulty <= 3) {
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("Difficulty out of range");
		}
	}
}
