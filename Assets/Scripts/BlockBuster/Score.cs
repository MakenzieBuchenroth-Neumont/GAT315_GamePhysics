using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	[SerializeField] int score = 0;
	[SerializeField] int boxPoints = 2;
	[SerializeField] int enemyPoints = 2;
	[SerializeField] int singlePoints = 5;

	[SerializeField] TMP_Text scoreText;

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Structure") {
			score += boxPoints;
			scoreText.text = score.ToString();
			Destroy(other.gameObject, 2);
		}
		if (other.gameObject.tag == "Enemy") {
			score += enemyPoints;
			scoreText.text = score.ToString();
			Destroy(other.gameObject, 2);
		}
		if (other.gameObject.tag == "SingleStructure") {
			score += singlePoints;
			scoreText.text = score.ToString();
			Destroy(other.gameObject, 2);
		}
	}
}
