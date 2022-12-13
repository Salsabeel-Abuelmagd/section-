using System;
namespace Soso;
public class Soso{
private static void Main(){

//reverse a string
string str="";
string reverse ="";
int len=0;
Console.WriteLine("Enter a string");
str = Console.ReadLine();
len=str.Length -1;
for(;len>=0;len--){
reverse+=str[len];
} 
Console.WriteLine(reverse);

//count of a's 
Console.WriteLine("Enter a string");
String st=Console.ReadLine();
var count=0;
for(int i=0;i<st.Length;i++){
if (st[i]=='a'){
    count ++;
}
} Console.WriteLine("count of a's in string is " + count);

//Last index of a
Console.WriteLine("Enter a string");
String stri=Console.ReadLine();
Console.WriteLine(stri.LastIndexOf('a'));

//remove all a's
Console.WriteLine("Enter a string");
String value=Console.ReadLine();
for(int i=0;i<value.Length;i++){
if (value[i]=='a'){
    
}
} Console.WriteLine(value);

}}