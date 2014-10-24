using UnityEngine;
using System.Collections;

public class NYCGenerator : MonoBehaviour {
	
//	public Transform originalBlueprint;
	public Transform cube1;
	public Transform cube2;
	public Transform cube3;
	public Transform cube4;


	
	void Start(){
		StartCoroutine (CubeGenerator () );
	}
	
	// Update is called once per frame
	void Update () { //gluing strings together is concatenation
		if (Input.GetKey ("r")) {
						Application.LoadLevel (0);
				}
		}
//
//		int charSoFar = 0;
//		
//		while (charSoFar < 10) {
//			Instantiate (cube, new Vector3 (charSoFar * 2.0F, 0, 0), Random.rotation);
//			charSoFar++;
//		}
//
//
//	}
	
	IEnumerator CubeGenerator(){
		int charSoFar = 0;
		int positionX = 0;
		int positionZ = 0;
		int counter = 0;

		float randomNumber;
		
//		while (true) {
//			if(Random.Range(0, 10f) < 5f){
//				textMesh.text += "\\"; // two backslashes is an escaping character because \n is a special code
//				Instantiate(cube1, new Vector3 (Random.Range (-10, 10f), 0, charSoFar + Random.Range (-9, 2.0f)), Quaternion.identity);
//				charSoFar ++;
//				
//			}
//			else {
//				textMesh.text += "/";
//				Instantiate(cube2, new Vector3 (Random.Range (-10, 10f), 0, charSoFar + Random.Range (-10, 5.0f)), Quaternion.identity);
//
//			}
//			if (charSoFar >= 10){
//				textMesh.text += "\n";
//				charSoFar = 0; //reset the counter
//			}
//			
//			yield return new WaitForSeconds(0.5f); //tells unity to take a break
//			
//		}

		while (counter < 100) {

			randomNumber = Random.Range (0, 10f);

			if(randomNumber < 2f){
				//empire state
				Instantiate(cube1, new Vector3 (positionX + Random.Range(-7, 0f), 0, positionZ), Quaternion.identity);
				positionX ++;
				positionZ ++;
			}

			if(randomNumber < 4f && randomNumber >= 2f){
				//bridge
				Instantiate(cube2, new Vector3 (positionX + 6, 0, positionZ + 13), Quaternion.identity);
				positionX ++;
				positionZ ++;
			}

			if(randomNumber < 7f && randomNumber > 5f){
				//pizza
				Instantiate(cube3, new Vector3 (positionX + 5, 0, positionZ - 4), Quaternion.identity);
				Instantiate(cube3, new Vector3 (positionX + 4, 0, positionZ - 4), Quaternion.Euler(0, 45, 0));
				positionX ++;
				positionZ ++;
			}
			
			if(randomNumber > 7f){
				//cab
				Instantiate(cube4, new Vector3 (positionX + Random.Range (-6, 2f), 0, positionZ + 1), Quaternion.Euler(0, Random.Range(0, 180), 0));
				
			}
			if (positionX >= 13) {
				charSoFar = 0; //reset the counter
				positionX = 0;
				positionZ += 2;
			}

			counter++;
			yield return new WaitForSeconds(0.5f); //tells unity to take a break
			
		}
	}


	
}
