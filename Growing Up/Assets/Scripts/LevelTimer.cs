using UnityEngine;
using System.Collections;

public class LevelTimer : MonoBehaviour {

// Use this for initialization
	void Start () {
    }

    float timeLeft = 20.0f;

    // Update is called once per frame
    void Update () {
        timeLeft -= Time.deltaTime;

        Debug.Log(timeLeft);
        Debug.Log(global::DestroyPoster.Poster.NumPosters);

        if (global::DestroyPoster.Poster.NumPosters == 0) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        }

        if (timeLeft < 0 && global::DestroyPoster.Poster.NumPosters > 0) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
}
