# LA_1100
# Projekt-Dokumentation

Leon Dakaj

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

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
| 7    |  Muss           | Randbedingung| Als ein Benutzer soll der Intro schön dargestellt werden  |


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
| 7.1  |  Programm startet            |   ---      |   Welcome to the Number Geussing Game!|










### 1.4 Diagramme

<img width="419" alt="image" src="https://user-images.githubusercontent.com/89085609/186597761-2260bdce-cfe4-4eaa-b4a6-bcc628ef41c7.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 02.09.22|Leon Dakaj| Zahlen generien können  |2 * 45 Minuten|
| 2.A  | 02.09.22|Leon Dakaj| Zahlen eraten können  |2 * 45 Minuten|
| 3.A  | 09.09.22|Leon Dakaj| Hinweiss soll bei einer falsch eratenen Zahl angezeigt werden | 2 * 45 Minuten|
| 4.A  | 09.09.22|Leon Dakaj| Anzahl Rateversuche soll angezeigt werden |3 * 45 Minuten|
| 5.A  | 16.09.22|Leon Dakaj| Fehlangabe soll angezeigt werden  |3 * 45 Minuten|
| 6.A  | 16.09.22|Leon Dakaj| Hinweiss soll rot angezeigt werden  |2 * 45 Minuten|
| 7.A  | 16.09.22|Leon Dakaj| Verschönern  |2 * 45 Minuten|

Total: 


## 3 Entscheiden


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
