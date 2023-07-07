using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UDPNetwork : MonoBehaviour
{
    public Text uname;

    public Text unumber;
    UdpClient client;
    private UdpClient udpClient;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Send()
    {
        Byte[] sendBytes = Encoding.ASCII.GetBytes(uname.text);
        udpClient.Send(sendBytes, sendBytes.Length);


        print("sent!");
    }

    public void Sendnum()
    {
        Byte[] sendBytes = Encoding.ASCII.GetBytes(unumber.text);
        udpClient.Send(sendBytes, sendBytes.Length);


        print("sent!");
    }


}
