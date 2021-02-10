Feladat egy gyártóüzem megrendeléseinek nyilvántartása és adatszolgáltatás az üzem felé.

Törzsadatok:
------------
Vevők
- Név (egyedi)
- Helység
- Cím (utca, házszám)
- IRSZ

Termékek
- Megnevezés (egyedi)
- Mennyiségi egység
- Készlet

Alapanyagok
- Megnevezés (egyedi)
- Termék

Forgalmi adatok:
---------------
Megrendelések
Fejléc:
- Megrendelés száma (egyedi)
- Rendelés dátuma
- Szállítás napja
- Vevő
Tételsorok
- Termék
- Mennyiség
- Mennyiségi egység

Adatszolgáltatás: csak képernyős megjelenítés
1./ A törzsadatokat természetesen tudni kell karbantartani illetve megjeleníteni.
2./ Áttekintő form
Két táblázatos ablakkal.  A felső ablak tartalmazza a megrendelés fejadatait, az alsó pedig a hozzá tartozó tételsorok adatait.
3./ Határidős form
A formon van egy dátum kiválasztó komponens (ComboBox vagy DateTimePicker) a szállítási dátum kiválasztására. Az itt kiválasztott dátumnak megfelelő megrendelések az alatta levő táblázatban jelennek meg.  Ezen a formon nem kell az adatokat karbantartani.



Magyarázatok
1./ Egy vevő több megrendelést leadhat.
2./ Egy megrendelésen egy vagy több termék  szerepelhet.
3./ Egy termék nulla vagy több alapanyagból állhat.
4./ Egy alapanyag több termékhez is kapcsolódhat, de más-más mennyiséggel és mennyiségi egységgel.



