/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package ins.pkg1b;

/**
 *
 * @author 91885
 */


public class railfence {
public static void main(String args[])
{
String input = "Vaibhav";
String output = "";
int len = input.length(),flag = 0;
System.out.println("Input String : " + input);
for(int i=0;i<len;i+=2) {
    output += input.charAt(i);
}
for(int i=1;i<len;i+=2) {
    output += input.charAt(i);
}
    System.out.println("Ciphered Text : "+output);
}
}
