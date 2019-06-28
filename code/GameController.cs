using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public GameObject GoalText;
	// Use this for initialization
	void Start () {
		GoalText.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider collider){

		if(collider.gameObject.tag == "Player"){
			 StartCoroutine(Example());
		}
			
	}
	

	IEnumerator Example()
    {
        
		GoalText.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Menu");
		
    }


}
