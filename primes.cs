using System;
using System.Collections;
  
class findingPrimes{ 
    static public void Main(String[] args){
        ArrayList primes = findPrimes(2000);
        foreach(int prime in primes){ Console.WriteLine(prime); }
    }

    static ArrayList findPrimes(int n){
        ArrayList otherlist = new ArrayList(), primes = new ArrayList();
        for(int i = 2; i < n;){
            if(otherlist.Contains(i)){
                i++;
            } else{
                primes.Add(i);
                otherlist.Add(i);
                for(int j = i; j < n;){
                    if(j+i > n){break;}
                    j = j + i;
                    if (otherlist.Contains(j)){continue;}
                    otherlist.Add(j);
                }
            }
        }
        return primes;
    }
}
