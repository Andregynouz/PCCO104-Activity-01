using System;

class Program {
  public static void Main (string[] args) {
    string fname = "Andre Robert";
    string Lname = "Lorenzo";
    Console.WriteLine ("Hello!"+ " " + fname + " " + Lname);
    Console.WriteLine ($"Hello! {fname} {Lname}" );
  }
}