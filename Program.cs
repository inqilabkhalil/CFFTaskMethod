using System;
class  Program
{
      static string customSubstring(string sentence, int startIndex, int lastIndex){
        string result = "";

       for(int i = startIndex; i<startIndex + lastIndex;i++){//3 deyisen
        if(i<sentence.Length){

        result +=sentence[i];
        }
       
      
       }
        return result;

       }
          static string customSubstring(string sentence, int startIndex){///2 deyisen
        string result = "";

       for(int i = startIndex; i<sentence.Length ;i++){
        result +=sentence[i];

       }
       return result;
       }

       //task-1 bitis









      static bool customContains(string sentence, string word){
        for(int i = 0;i<sentence.Length;i++){
            for(int j=0;j<word.Length;j++){
                if(i+j>=sentence.Length){
                    return false;
                }
                if(sentence[i+j]==word[j]||sentence[i+j]+32==word[j]||sentence[i+j]-32==word[j]){//ai dan komek aldigimi hisse i+j ucun
                    if(j==word.Length-1){
                        return true;
                    }
                }
            }
           
        }
         return false;
      }

      // task 2 bitis
       
        static void Main(){
    Console.WriteLine(customSubstring("Hello, World!",2,10)); //1 task run
    Console.WriteLine(customContains("Hello, World!","world"));
}
    }






///467//do