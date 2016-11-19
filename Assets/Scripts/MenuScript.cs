using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button exitText;

	// Use this for initialization
	void Start () 
	{
		
	}
		
	public void ExitGame()
	{
		Application.Quit (); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
