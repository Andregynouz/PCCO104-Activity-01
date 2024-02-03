using System;

class Program {
  public static void Main (string[] args) {
    string fname = "Andre Robert";
    string Lname = "Lorenzo";
    int age = 19;
    Console.WriteLine ("Hello!"+ " " + fname + " " + Lname + " " + age);
    Console.WriteLine ($"Hello! {fname} {Lname} {age}" );
  }
}