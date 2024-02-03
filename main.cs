using System;

class Program {
  public static void Main (string[] args) {
    string fname = "Andre Robert";
    string Lname = "Lorenzo";
    int age = 19;
    string yrandsec = "BSIT1A";
    Console.WriteLine ("Hello!"+ " " + fname + " " + Lname + " " + age + " " + yrandsec );
    Console.WriteLine ($"Hello! {fname} {Lname} {age} {yrandsec}" );
  }
}