using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Load : MonoBehaviour
{
    public static int pin;
    public static double totalamount;
    public Player player;
    void Awake()
    {
        string path = Application.persistentDataPath + "/ATMFILE.pkd";
        if (!File.Exists(path))
        {
            Debug.Log("file not found but i created......");
            player.SavePlayer();
        }
    }
    void Start()
    {
        player.LoadPlayer();
       pin= player.pin;
        totalamount=player.amount;
        Debug.Log(pin+"   "+totalamount);
    }
    private void Update()
    {
        
    }


}
