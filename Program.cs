using System;
class  Program
{
    static int Calculate(int a){//Cevre sahesi
        int p = 3;
        return a * p*p;
    }
    static int Calculate(int a, int b){//duzbucaqli sahesi
        return a*b;
    }
    static int Calculate(int a, int b,int c){// para sahe
        return 2 *(a*b+ a*c + b*c);
    }
     static int Calculate(int a,int b,int c,int r){
        int perimetr = (a+b+c)/2;
        return perimetr * r;
    }
  
  static int pow(int x){
    return x*x;
}
static int pow(int x,int c){
    int result = 1;
   for(int i = 0; i<c;i++){
    result *= x;

   }
   return result;
}
  static void Main(){
    Console.WriteLine("Cevrenin Sahesi " + Calculate(5));
    Console.WriteLine("Duzbucaqli sahesi " + Calculate(5,3));
    Console.WriteLine("Para sahesi " + Calculate(5,3,4));
    Console.WriteLine("Ucbucaqlinin  daxiline cekilmis cevre " + Calculate(3,4,5,6));
    Console.WriteLine("1ci hesab "+ pow(3));
    Console.WriteLine("2ci hesab "+ pow(5,3));
}
}



