using System;

namespace RSPLS_Csharp
{

	public class Human : Player

	{
		public string player_choice;


		public Human(string name, string chosen_gesture, string gestures) : base(gestures)
		{
			this.name = name;
			this.chosen_gesture = chosen_gesture;
			this.score = 0;

		}
		public override void ChooseGesture()
        {
			for (int count = 0; count < gestures.length; count++)
				Console.WriteLine($"Enter {count++} to use {gestures}");

			if (chosen_gesture == "")
				Console.WriteLine("Make your choice: ");
				player_choice = Console.ReadLine();
				return player_choice;

			if (player_choice == "1")
				chosen_gesture = gestures[0];
			Console.WriteLine($"You have chosen {gestures[0]}");

			if(player_choice == "1")
				chosen_gesture = gestures[1];
			Console.WriteLine($"You have chosen {gestures[1]}");

			if(player_choice == "1")
				chosen_gesture = gestures[2];
			Console.WriteLine($"You have chosen {gestures[2]}");

			if(player_choice == "1")
				chosen_gesture = gestures[3];
			Console.WriteLine($"You have chosen {gestures[3]}");

			if(player_choice == "1")
				chosen_gesture = gestures[4];
			Console.WriteLine($"You have chosen {gestures[4]}");

		}	
	}
}
