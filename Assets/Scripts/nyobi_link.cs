using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nyobi_link : MonoBehaviour {

	/* 参考元:https://qiita.com/7of9/items/3b5f6dd0af4f8af353c5
	https://sysken.org/blog/3707/
	*/
	// Use this for initialization
	// void Start () {
	//
	// }
	//
	// Update is called once per frame
	public void OnClick(){
				switch(transform.name){
					case "google_test":
						Application.OpenURL("https://www.google.com");
						Debug.Log("Google表示");
						break;
					case "N_yobi":
						Application.OpenURL("https://www.nnn.ed.nico/oauth_login");
						Debug.Log("N予備校ログイン画面表示");
						break;
				}
			}
}
