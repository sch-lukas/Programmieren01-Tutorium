/*
 Ein Wein hat einen Namen, einen Jahrgang (z.B. 1996) und einen Preis (z.B. 15.20).
 a.) Schreiben Sie eine Struktur, die einen Wein beschreibt.
 
 b.) Erzeuge verschiedene Weine aus den Jahren 1996, 2000, 2018, 2020 , 2021
 
 c.) Schreibe Eigenschaften mit ,,getter'' für alle Felder.
     Füge für die Eigenschaft vom Preis zusätzlich einen ,,setter hinzu''.

 d.) Lege eine ToString Methode für den Wein an und teste diese in der Main Methode.
   
 e.) Schreiben Sie eine Methode, die das durchschnittliche Alter eines Weins im Jahr 2016 be
rechnet. Wenn das Feld leer ist, soll 0 zurückgegeben werden.
 public static double DurchschnittsAlter(List<Wein> dieWeine)
 
 f.) Schreiben Sie eine Methode, die den durchschnittlichen Preis aller Weine ermittelt, die eine
 bestimmten Namen haben.
 public static double DurchschnittsPreis(List<Wein> dieWeine, string name)
 
 g.) Schreiben Sie eine Methode, die ein Feld mit allen Weinen zurückgibt, die nicht teurer sind
 als ein gegebener Preis.
 public static List<Wein> AlleNichtTeurerAls(List<Wein> dieWeine, double PreisGrenze)
 
 h.) Schreiben Sie eine Methode, die Indizes der teuersten Weine eines Jahrgangs liefert.
 public static List<int> MaxPreis(List<Wein> dieWeine, int Jahrgang)
 */