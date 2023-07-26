using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CreateScript : MonoBehaviour
{

    void bolenleriBul(int ilksayi, int ikincisayi)
    {
        List<int> ikiyeBolunenler = new List<int>();
        List<int> uceBolunenler = new List<int>();
        List<int> dordeBolunenler = new List<int>();
        List<int> beseBolunenler = new List<int>();

        for(int i=ilksayi; i <= ikincisayi; i++)
        {
            if (i % 2 == 0)
            {
                ikiyeBolunenler.Add(i);
            }
            else if (i % 3 == 0)
            {
                uceBolunenler.Add(i);
            }
            else if (i % 4 == 0)
            {
                dordeBolunenler.Add(i);
            }
            else if (i % 5 == 0)
            {
                beseBolunenler.Add(i);
            }
        }

        UnityEngine.Debug.Log("Ýkiye Bölünenler: " + string.Join(", ", ikiyeBolunenler));
        UnityEngine.Debug.Log("Üçe Bölünenler: " + string.Join(", ", uceBolunenler));
        UnityEngine.Debug.Log("Dörde Bölünenler: " + string.Join(", ", dordeBolunenler));
        UnityEngine.Debug.Log("Beþe Bölünenler: " + string.Join(", ", beseBolunenler));
    }


    private void Start()
    {
        bolenleriBul(20, 44);
    }


}
