using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MainScript2 : MonoBehaviour {

    void Start () {
    //    NetworkScript test = new NetworkScript();
    //    test.setupSocket();
    //    if (test.readSocket() != "")
    //        Debug.Log("READ  " + test.readSocket());
    //    test.writeSocket("GRAPHIC");
    //    Debug.Log("READ  " + test.readSocket());
        String value = "msz 200 200\n";
        Char delim = ' ';
        String[] substrings = value.Split(delim);

        ParsingScript test = new ParsingScript();
        test.SetServSend(substrings);
        test.CreateDico();
        test.SearchInDico("msz");

    //  test.closeSocket();
    }
}
