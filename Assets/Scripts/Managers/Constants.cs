using UnityEngine;

public class Constants : MonoBehaviour
{
	static Constants _instance;
	public static Constants Instance {
		get {
			if (_instance == null) {
				_instance = Resources.Load("constants",typeof(Constants)) as Constants;
			}
			return _instance;
		}
	}
	public int DefaultUnitHP;
	public int MaxUnitHP;
	public int DefaultUnitPower;
	public int MaxUnitPower;
}