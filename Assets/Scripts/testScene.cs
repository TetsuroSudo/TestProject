using UnityEngine;
using System.Collections;

public class testScene : MonoBehaviour {

	public int m_num;

	public bool m_isFlag;

	public GameObject m_Object;

	public void TestFunc( int _num )
	{
		
	}

	// Use this for initialization
	void Start () {
		Debug.Log("機会");

		m_num = 0;

		m_isFlag = false;

		if( m_num == 0 ){

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
