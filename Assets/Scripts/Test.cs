using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TestItem
{
    public int id = 1;
    public int num = 10;
}

public class TestClass {
    public int test1; public string test2; 
    public TestItem item;
    public TestItem[] array; 
    public List<TestItem> list;
    public SerizlizerDictionary<int,TestItem> dic;

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestClass t = new TestClass();
        t.test1 = 1;
        t.test2 = "落樱";
        t.item = new TestItem();
        t.array = new TestItem[2] { new TestItem(), new TestItem() };
        t.list = new List<TestItem>() {new TestItem() };
        t.dic = new SerizlizerDictionary<int, TestItem>() { {1,new TestItem() }, { 2, new TestItem() }, { 3, new TestItem() } };
        print(Application.dataPath);
        XMLDataMgr.Instance.SaveData(t, "Test");

        TestClass t2 = XMLDataMgr.Instance.LoadData(typeof(TestClass), "Test") as TestClass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
