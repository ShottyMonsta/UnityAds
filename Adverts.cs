using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Adverts : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        Advertisement.Initialize ("33675", true);
        StartCoroutine (ShowAdWhenReady());
	}
	
	// Update is called once per frame
    IEnumerator ShowAdWhenReady()
    {
        while (!Advertisement.IsReady())
        {
            yield return null;
        }
        Advertisement.Show();
    }
}
