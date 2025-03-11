using UnityEngine;

public class SmallEnemy : MonoBehaviour, ICharacter 
{
	float startingHealth = 100f;
	float m_CurrentHealth;

	public Quaternion Rotation
	{
		get
		{
			return transform.rotation;
		}
	}

	void Start()
	{
		m_CurrentHealth = startingHealth;
	}

	public void Attack()
	{
		//Do something, attack player
		print("Attack");
	}

	public void Death()
	{
		//Do something, dying
		print("Death");
	}

	public void Damaged(float damage)
	{
		m_CurrentHealth -= damage;
	}
}
