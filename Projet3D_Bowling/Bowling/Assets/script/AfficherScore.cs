using UnityEngine;
using System.Collections;
// affichage du score
public class AfficherScore : MonoBehaviour {
	
	
	public CalculScore calscr;
	
	void OnGUI()
	{
		//calscr._FrameBall = 1; 
		Rect r = new Rect(Screen.width - 320, 10, 100, 20);
		GUI.Box(r,"Score : "+calscr._Score.ToString());
		
		Rect s = new Rect(Screen.width - 220, 10, 200, 20);
		string frameball = "Essai: {0}    Ballon:{1}";
		
		GUI.Box(s, string.Format(frameball, calscr._Frame, calscr._FrameBall));	
		GUI.backgroundColor = Color.gray; 


		Rect t = new Rect(Screen.width - 300, 30, 300, 20);
		/**
		GUI.Label(t, "                 ( === | Gauche ) pour cibler");
		**/
	    Rect q = new Rect(Screen.width - 300, 40, 300, 20);
		GUI.Label(q, "appuyer sur 'Espace'  pour charger ensuite , Tirez !");
		if (calscr._FrameBall == 0 && calscr._Score % 10 != 0) {
						GUI.Label (t, "Vous avez perdu :(");

				} else if (calscr._Frame /2== 1 && calscr._Score % 10 == 0) {
				
			GUI.Label (t, "Vous avez gagné :) ");
		
		}
	}
}
