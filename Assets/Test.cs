using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    private int hp = 100;
    private int power = 50;

    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Damage(int damage) {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

public class Test : MonoBehaviour
{
    void callName(string name) {
        Debug.Log("Hello, " + name);
    }

    int add(int a, int b) {
        int c = a + b;
        return c;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");

        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "kitamura";
        Debug.Log(name);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        answer = 3 - 4;
        Debug.Log(answer);
        answer = 6 * 5;
        Debug.Log(answer);
        answer = 8 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        int herbNum = 1;
        if (herbNum == 1) {
            Debug.Log("HPが50回復");
        }

        int hp = 180;
        if (hp <= 50) {
            Debug.Log("逃走!");
        } else if (hp >= 200) {
            Debug.Log("攻撃!");
        } else {
            Debug.Log("防御!");
        }

        for (int i = 0; i < 5; i++) {
            Debug.Log(i);
        }

        for (int i = 0; i < 10; i += 2) {
            Debug.Log(i);
        }

        for (int i = 3; i <= 5; i++) {
            Debug.Log(i);
        }

        for (int i = 3; i >= 0; i--) {
            Debug.Log(i);
        }

        int sum = 0;
        for(int i = 1; i <= 10; i++) {
            sum += 1;
        }
        Debug.Log(sum);

        int[] array = new int[5];
        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;
        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }

        int[] point = { 83, 99, 52, 93, 15 };
        int secondSum = 0;
        for (int i = 0; i < point.Length; i++) {
            secondSum += point[i];
            if (point[i] >= 90) {
                Debug.Log(point[i]);
            }
        }
        //int average = secondSum / point.Length;
        float average = 1.0f * secondSum / point.Length;
        Debug.Log(average);

        callName("Tom");

        int secondAnswer;
        secondAnswer = add(3, 4);
        Debug.Log(answer);

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
