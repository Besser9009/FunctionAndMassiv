string Method4(int count, string text){
    string result = String.Empty;
    for (int i = 0; i < count; i++){
        result += text;
    }
    return result;
}
string res = Method4(10, "Возможен такой метод ");
System.Console.WriteLine(res);