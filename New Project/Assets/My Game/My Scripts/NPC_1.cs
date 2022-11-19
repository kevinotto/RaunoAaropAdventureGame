using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "Welcome adventurer!", "1");
		Speech.AddDialogue("1", "Collect coins here", "2");
		Speech.AddDialogue("2", "Find your powerup", "3");
		Speech.AddDialogue("3", "Move Across levels to unlock the secret", "4");
		Speech.AddDialogue("4", "Good Luck!");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}