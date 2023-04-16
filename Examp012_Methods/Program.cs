//Вид 1
void Method1(){
    System.Console.WriteLine("Бесчеревных Михаил");
}
Method1(); 

//Вид 2
void Method2(string msg, int svg){
    int i = 0;
    while(i < svg){
        System.Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "Текст сообщения", svg: 7);

//Вид 3
int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

//Вид 4
string Method4(int count, string text){
    int i = 0;
    string result = String.Empty;
    while (i < count){
        result += text;
        i++;
    }
    return result;
}
string res = Method4(10, "Возможен такой метод ");
System.Console.WriteLine(res);
