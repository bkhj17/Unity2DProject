using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public int a = 70;

    private void Awake()
    {
        print("Awake");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    // Start is called before the first frame update
    void Start()
    { 
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        //a++;
        print(a);
    }

    class Item {
        public int a;
    }

    struct Weapon
    {
        public int b;
    }

    void SetItem(Item item)
    {
        item.a = 10;
    }
    void SetWeapon(Weapon weapon)
    {
        weapon.b = 10;
    }
}
