using UnityEngine;
using System.Collections;

public class DestroyPoster : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
    }

    public class Poster
    {
        public static int NumPosters = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(GetGameObjectClicked());
        }
    }
    GameObject GetGameObjectClicked()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit)
        {
            Poster.NumPosters--;
            return hit.collider.gameObject;
        }
        return null;
    }
}