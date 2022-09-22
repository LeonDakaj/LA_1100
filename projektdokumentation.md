# LA_1100
# Projekt-Dokumentation

Leon Dakaj

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 01.09.2022      | 0.0.1   | Zahl wurde generiert, Benutzer kann Zahl eraten beim eingeben, Hinweiss wird bei falscher eingegebener Zahl angezeigt, Anzahl Rateversuche werden angegeben |
|  08.09.2022     | 0.0.2     | Bei Nicht eingegebener Zahl steht wird eine Fehlangabe angezeigt, Hinweiss wird bei falscher eingegebener Zahl angezeigt (in Rot), Nachdem eraten der richtigen Zahl, wird gefragt, ob man wieder spielen möchte  |

## 1 Informieren


### 1.1 Ihr Projekt

Random-Number-Generator-game


### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss           | Funktional| Als ein Benutzer soll eine Zahl generiert werden, damit ich sie eraten kann|
| 2    |  Muss           | Funktional| Als ein Benutzer kann ich eine geratene Zahl eingeben |
| 3    |  Kann           | Funktional| Als ein Benutzer soll mir ein Hinweiss angezeigt werden falls die geratene Zahl zu hoch oder zu niedrig ist |
| 4    |  Muss           | Funktional| Als ein Benutzer soll mir die Anzahl Rateversuche ausgegeben werden |
| 5    |  Muss           | Funktional| Als ein Benutzer soll mir angezeigt werden, das wenn ich text anstatt einer Zahl eingebe, das eine Fehlangabe steht  |
| 6    |  Muss           | Qualität| Als ein Benutzer soll mir Angezeigt werden, wenn mir ein Hinweiss angezeigt wird, soll dies (rot) angezeigt werden |
| 7    |  Kann           | Randbedingung| Als ein Benutzer soll der Intro schön dargestellt werden  |
| 8    |  Kann           | Randbedingung| Als ein Benutzer soll ich die Auswahl haben, das Spiel wieder zu spielen  |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Zahl wird generiert             |  Eingabe einer Zahl      | Ausgabe einer Zahl   |
| 2.1  |  Zahl wird generiert            |   20      |        Zahl ist zu gross!        |
| 2.2  |  Zahl wird generiert            |   15      |        Zahl ist zu klein!        |
| 3.1  |  Zahl wird generiert            |   20      |        Zahl ist zu gross! Versuch kleiner!|
| 3.2  |  Zahl wird generiert            |   15      |        Zahl ist zu klein! Versuch grösser!|
| 4.1  |  Zahl wird eraten               | 50(x)     |                   Anzahl versuche(y)    |
| 5.1  |  Programm startet            |   string(Text)      |    Ist keine Zahl zwischen 1-100    |
| 6.1  |  Zahl wird generiert             |   30   |   Zahl ist zu gross! Versuch kleiner! / Zahl ist zu klein! Versuch grösser! (Alles in Rot) |
| 7.1  |  Programm startet            |   ---      |   Guess-MyNumber-Game |
| 8.1  |  Zahl wird eraten            |   ---      |   Willst du wieder Spielen? (J/Nein): |


### 1.4 Diagramme

<img width="419" alt="image" src="https://user-images.githubusercontent.com/89085609/186597761-2260bdce-cfe4-4eaa-b4a6-bcc628ef41c7.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 01.09.22|Leon Dakaj| Zahlen generien können  |2 * 45 Minuten|
| 2.A  | 01.09.22|Leon Dakaj| Zahlen eraten können  |2 * 45 Minuten|
| 1.B  | 08.09.22|Leon Dakaj| Hinweiss soll bei einer falsch eratenen Zahl angezeigt werden | 2 * 45 Minuten|
| 2.B  | 08.09.22|Leon Dakaj| Anzahl Rateversuche soll angezeigt werden |3 * 45 Minuten|
| 1.C  | 15.09.22|Leon Dakaj| Fehlangabe soll angezeigt werden  |3 * 45 Minuten|
| 2.C  | 15.09.22|Leon Dakaj| Hinweiss soll rot angezeigt werden  |2 * 45 Minuten|
| 3.C  | 15.09.22|Leon Dakaj| Eingabe einer Zahl wird Blau dargestellt  |30 Minuten|
| 4.C  | 15.09.22|Leon Dakaj| Wird gefragt ob man wieder spielen möchte |2 * 45 Minuten|
| 5.C  | 15.09.22|Leon Dakaj| Verschönern  |2 * 45 Minuten|


## 3 Entscheiden


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  01.09.22     |   Leon Dakaj        |   2 * 45Minuten            |    45 Minuten               |
| 2.A  |  01.09.22     |   Leon Dakaj        |   2 * 45Minuten            |    45 Minuten               |
| 1.B  |  01.09.22     |   Leon Dakaj        |   2 * 45Minuten            |    2 * 45 Minuten               |
| 2.B  |  08.09.22     |   Leon Dakaj        |   2 * 45Minuten            |    2 * 45 Minuten               |
| 1.C  |  08.09.22     |   Leon Dakaj        |   2 * 45Minuten            |    45 Minuten               |
| 2.C  |  08.09.22     |   Leon Dakaj        |    45 Minuten            |    45 Minuten               |
| 3.C  |  08.09.22     |   Leon Dakaj        |    30 Minuten            |    30 Minuten               |
| 4.C  |  08.09.22     |   Leon Dakaj        |    2 * 45Minuten            |    2 * 45 Minuten               |


## 5 Kontrollieren


### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 2.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 3.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 4.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 5.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 6.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 7.1  |   22.09.22    |    OK      |   Leon Dakaj     |
| 8.1  |   22.09.22    |    OK      |   Leon Dakaj     |

Alles Funktioniert. Der Benutzer kann das Spiel ohne Probleme spielen.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
