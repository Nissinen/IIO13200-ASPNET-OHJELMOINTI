using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLotto
/// </summary>
public class BLLotto
{ 
    public string TeeLotto(int lkm) { 
        Random rnd = new Random();
        int luku;
        List<int> luvut = new List<int>();
        string lukujono = "";

        for (int i = 0; i < lkm; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                luku = rnd.Next(1, 39);
                if (luvut.Contains(luku))
                {
                    j--;
                }
                else {
                    lukujono = lukujono + " " + Convert.ToString(luku);
                }
                luvut.Add(luku);
            }
            luvut.Clear();
            lukujono = lukujono + "<br/>";
        }
        return lukujono;
    }
    public string TeeVikingLotto(int lkm)
    {
        Random rnd = new Random();
        int luku;
        List<int> luvut = new List<int>();
        string lukujono = "";

        for (int i = 0; i < lkm; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                luku = rnd.Next(1, 48);
                if (luvut.Contains(luku))
                {
                    j--;
                }
                else {
                    lukujono = lukujono + " " + Convert.ToString(luku);
                }
                luvut.Add(luku);
            }
            luvut.Clear();
            lukujono = lukujono + "<br/>";
        }
        return lukujono;
    }
}