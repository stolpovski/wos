using UnityEngine;

public class LightController : MonoBehaviour
{
	public float DayLength;
	private float _rotationSpeed;

	void Update()
	{
		_rotationSpeed = Time.deltaTime / DayLength;
		transform.Rotate(0, _rotationSpeed, 0);
	}
}
