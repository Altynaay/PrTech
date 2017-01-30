using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    class Program
    {
        static void Main(string[] args)
        {
            int p,q,k,n,x;
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            p = s.Length + 1;
            q = t.Length + 1;
            if(p>q){
    	        n=p;
            }
            else{
    	        n=q;
            }
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            k = n - 1;
            for(int i = 0; i < n ; i++){
    	        a[i] = 0;
    	        b[i] = 0;
            }
            for(int i = s.Length - 1 ; i >= 0 ; i--){
    	        a[k] = s[i] - 48;
    	        k--;
            }
            k = n - 1;
            for(int i = t.Length - 1 ; i >= 0 ; i--){
    	        b[k] = t[i] - 48;
    	        k--;
            }
            x = 0;
            for(int i = n - 1 ; i >= 0 ; i--){
    	        if((a[i] - b[i]) < 0){
    	 	        c[i] = a[i] + 10 - b[i];
    	 	        a[i-1] = a[i-1] - 1;
    	        }
    	        else{
    		        c[i] = a[i] - b[i];
    		        a[i] = a[i] - 1;
    	        }      
            }
            int l = 0;
            if(c[0]>0){
    	        l = 0;
            }
            else if(c[0] > 0 && c[1] > 0){
    	        l = 2;
            }
            else{
   		        l = 1;
            }
            Console.WriteLine("Result:");
            for(int i = l; i < n; i++){ 
    	    Console.Write(c[i]);  
            }
            Console.ReadKey();
        }
    }
}
