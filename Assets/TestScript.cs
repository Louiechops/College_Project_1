using UnityEngine;
using UnityEngine.InputSystem;

public class TestScript : MonoBehaviour
{
	public Rigidbody2D RB;
	public float Speed = 5;
	public int score = 0;

	void Update()
	{
		Vector2 vel = new Vector2(0, 0);

		if (Keyboard.current.rightArrowKey.isPressed) 
		{
			vel.x = Speed;
		}

		if(Keyboard.current.leftArrowKey.isPressed) 
		{
			vel.x = -Speed;		
		}

		if (Keyboard.current.upArrowKey.isPressed)
		{
			vel.y = Speed;		
		}
		
		if (Keyboard.current.downArrowKey.isPressed) 
		{
			vel.y = -Speed;		
		}

		RB.linearVelocity = vel;
	}

	
}


