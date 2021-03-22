      // March 22 - 2021 (14 years)
      // Project: Convert time ( Min to Sec/ Sec to Min )

using System;
class HelloWorld {
  static void Main() {
      Console.Write(converttype(78,true));
  }
  
  static string converttype(int time,bool sec2min){
      
      int returntime;
      
      string returntimeString="";
      
      if(sec2min){
          
          returntime = time/60;
          
          int leftsecond= time - returntime*60;
          
          returntimeString= returntime + " minute and " + leftsecond +" seconds!";
          
      }else{
          
          returntime = time*60;
          
          return returntimeString +=" seconds!";
          
      }
      
      return returntimeString;
  }
  
}