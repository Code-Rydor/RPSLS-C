using System;
using System.Collections.Generic;

namespace RSPLS_Csharp
{
	public abstract class Player
	{
		public string name;
		public int score;
		public string chosen_gesture;
		public List<string> gestures;

		//Constructor
		public Player(string name, string chosen_gesture)
        {
			this.name = name;
			this.chosen_gesture = ""; // TODO: Correct this later
			gestures = new List<string>();
			gestures.Add("Rock");
			gestures.Add("Paper");
			gestures.Add("Scissors");
			gestures.Add("Lizard");
			gestures.Add("Spock");
		}


		public abstract void ChooseGesture();
		
	}
}
