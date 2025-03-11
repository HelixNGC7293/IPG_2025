using UnityEngine;

public interface ICharacter
{
	Quaternion Rotation { get; }
	void Attack();
	void Damaged(float damage);
	void Death();
}
