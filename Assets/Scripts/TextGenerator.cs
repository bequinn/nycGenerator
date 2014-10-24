using UnityEngine;
using System.Collections;

public class TextGenerator : MonoBehaviour {
	
	public TextMesh textMesh; //assign in inspector
	public Transform originalBlueprint;

	
	void Start(){
		StartCoroutine (TenPrintProcess () );
	}
	
	// Update is called once per frame
	void Update () { //gluing strings together is concatenation
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit = new RaycastHit ();
		
		if (Physics.Raycast (ray, out rayHit, 1000f)) {
			if (Input.GetMouseButtonDown(0)){
				int howManyCopies =0;
				while(howManyCopies < 9){ //make sure it's a bounded loop
					Instantiate(originalBlueprint, rayHit.point, Random.rotation);
					howManyCopies++;
				}
			}
		}
	}
	
	IEnumerator TenPrintProcess(){
		int charSoFar = 0;
		
		while (true) {
			if(Random.Range(0, 10f) < 5f){
				textMesh.text += "\\"; // two backslashes is an escaping character because \n is a special code
				charSoFar ++;

			}
			else {
				textMesh.text += "/";
			}
			if (charSoFar >= 10){
				textMesh.text += "\n";
				charSoFar = 0; //reset the counter
			}
			
			yield return new WaitForSeconds(0.1f); //tells unity to take a break
			
		}
	}
}
