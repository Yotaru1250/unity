using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
	public GameObject GoalText;
    public GameObject GoalUI;
    // Use this for initialization
    void Start () {
		GoalText.SetActive(false);
        GoalUI.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
       

    }
	
	 void OnTriggerEnter(Collider collider){

		if(collider.gameObject.tag == "Player" )
        {
			 //StartCoroutine(Example());
		}
			
	}
	

	IEnumerator Example()
    {
        GoalText.SetActive(true);
        GoalUI.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
		
    }


}
