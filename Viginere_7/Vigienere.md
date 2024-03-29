
# 4. Vigenère tábla

Már a XVI. században komoly titkosítási módszereket találtak ki az üzenetek elrejtésére. A század egyik legjobb kriptográfusának Blaise de Vigenère-nek a módszerét olvashatja a következőkben.

A kódoláshoz egy táblázatot és egy ún. kulcsszót használt. A táblázatot a jobb oldali ábra tartalmazza.

![](image1.png)

A tábla adatait a vtabla.dat fájlban találja a következő formában.

![](image2.png)

Készítsen programot a következő feladatok végrehajtására!

1. Olvassa be a nyiltSzöveg.txt fájlból a maximum 255 karakternyi, nem üres szöveget! A továbbiakban ez a nyílt szöveg.
2. Alakítsa át a nyílt szöveget, hogy a későbbi kódolás feltételeinek megfeleljen! A kódolás feltételei:
  - A magyar ékezetes karakterek helyett ékezetmenteseket kell használni. (Például á helyett a; ő helyett o stb.)
  - A nyílt szövegben az átalakítás után csak az angol ábécé betűi szerepelhetnek.
  - A nyílt szöveg az átalakítás után legyen csupa nagybetűs.
3. Írja ki a képernyőre az átalakított nyílt szöveget!
4. Kérjen be a felhasználótól egy maximum 5 karakteres, nem üres kulcsszót! A kulcsszó a kódolás feltételeinek megfelelő legyen! (Sem átalakítás, sem ellenőrzés nem kell!) Alakítsa át a kulcsszót csupa nagybetűssé!
5. A kódolás első lépéseként fűzze össze a kulcsszót egymás után annyiszor, hogy az így kapott karaktersorozat (továbbiakban kulcsszöveg) hossza legyen egyenlő a kódolandó szöveg hosszával! Írja ki a képernyőre az így kapott kulcsszöveget!
6. A kódolás második lépéseként a következőket hajtsa végre! Vegye az átalakított nyílt szöveg első karakterét, és keresse meg a vtabla.dat fájlból beolvasott táblázat első oszlopában! Ezután vegye a kulcsszöveg első karakterét, és keresse meg a táblázat első sorában! Az így kiválasztott sor és oszlop metszéspontjában lévő karakter lesz a kódolt szöveg első karaktere. Ezt ismételje a kódolandó szöveg többi karakterével is!
7. Írja ki a képernyőre és a kodolt.txt fájlba a kapott kódolt szöveget!
8. A program képes legyen a kodolt.txt fájl visszafordítására a kodoltMegfejtes.txt fájlba.
9. A programot írja meg úgy, hogy az képes legyen egy titkosított üzenetváltást használhatóan lekezelni. Ennek megoldási módja az ön feladata.

Példa a kódolásra:

Nyílt szöveg: Ez a próba szöveg, amit kódolunk! Szöveg átalakítása: EZAPROBASZOVEGAMITKODOLUNK Kulcsszó: auto

Kulcsszó nagybetűssé alakítása: AUTO

Nyílt szöveg és kulcsszöveg együtt:

![](image3.png)

Kódolt szöveg:

![](image4.png)
