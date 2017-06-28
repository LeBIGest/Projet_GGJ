using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MainScript2 : MonoBehaviour
{

    NetworkScript net;
    ParsingScript parser;
    private float TimeIntervale = 0.0f;
    Char delim = ' ';

    void Start()
    {
        net = new NetworkScript();
        parser = new ParsingScript();

        parser.CreateDico();
        net.setupSocket();
        net.writeSocket("GRAPHIC");
    }

    private void OnDestroy()
    {
        net.closeSocket();
    }

    void Update()
    {
        TimeIntervale += Time.deltaTime;
        String line = null;

  //      if (TimeIntervale >= 0.1f)
  //      {
  //          TimeIntervale = 0.0f;
            if ((line = net.readSocket()) != "")
            {
  //              print(line);
                String[] cmd = line.Split(delim);
             parser.SetServSend(cmd);
            parser.SearchInDico(cmd[0]);
            }
   //    }
    }
}
