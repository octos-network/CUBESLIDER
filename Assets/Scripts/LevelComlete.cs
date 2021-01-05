using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComlete : MonoBehaviour {

	public void LoadNextLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
