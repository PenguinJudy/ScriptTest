using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ここから、発展課題Bossクラスの部分
public class Boss{
    private int mp = 53;
    public void Magic(int k){
        if (this.mp >= 5){

        this.mp -= k;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else{
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}
public class Test : MonoBehaviour {

	// Use this for initialization
    // ここから、課題：配列を宣言して出力しましょう
    void Start () {
        int[] array = { 19, 97, 12, 17, 21 };
        for (int i = 0; i < 5; i++){
            Debug.Log(array[i]);
        }
        for (int j = 4; j > -1;j--){
            Debug.Log(array[j]);
        }
        // ここから、発展課題Start関数の部分
        Boss lastboss = new Boss();
        for (int k = 1; k <= 11; k++){
            lastboss.Magic(5);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
