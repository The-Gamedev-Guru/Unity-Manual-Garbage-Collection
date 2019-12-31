using UnityEngine;

namespace TheGamedevGuru
{
public class GarbageCreator : MonoBehaviour
{
	[SerializeField] private int garbageCreationRate = 1024;
	private static int[] _garbage;
	void Update()
	{
		_garbage = new int[garbageCreationRate];
	}
}
}
