# Unity2020.3.18f1-README-Template

### Projektbeschreibung: 
Ziel ist ein Funktionierender Addierer von zwei Integerwerten mit einem Reset und einem Calculate Button.

### Entwicklungsplattform: 
Unity 2020.3.18f, 
Visual Studios 2019;

### Zielplattform: 
WebGL Referenzauflösung (960x600) 

### Visuelle Einblicke in das Projekt: 
https://3ahmns2122mtin.github.io/03CKloesch-KinderAddierer/

### Notwendiges für die Ausführung: 
z.B.: Installationsprozess, Schritt für Schritt Anweisung, spezielles Packages welches geladen werden muss, etc.  

### Drittmaterial: 
Background: Pixel_DownTown (https://www.google.com/search?q=pixel+background&client=firefox-b-d&sxsrf=AOaemvI4iAkMMyAzWGqNJhBR_cSOy5K4Rw:1639034889053&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiHytfimNb0AhWMu6QKHQETA0EQ_AUoAXoECAEQAw&biw=1696&bih=859&dpr=1.13#imgrc=Puu9S8OUPuF_1M), 
Background Music: cxlt - Overthinking (https://www.youtube.com/watch?v=BZMaOtnDny4), 
Font: PixelDigivolve (https://www.fontspace.com/pixel-digivolve-font-f22012);

### Anforderungsliste:  
- [x] Neues Projekt in Unity anlegen
- [x] SampleScene in Main umbenennen
- [x] Ordner MyGame erstellen
- [x] Ordner für Scripts und Sprites erstellen
- [x] Canvas erstellen mit UI Elementen
- [x] Canvas Screen auf Independent setzten, Referenzauflösung auf 960 x 600
- [x] neues Script erstellen und in MainSceneController umbenennen
- [x] neues Empty GameObject erstellen und in MainSceneController umbenennen
- [x] dort Script anhängen
- [x] public Variablen für Value 1, Value 2 und Result erstellen 
- [x] im Inspector entsprechende GameObjects zu den Variablen referenzieren
- [x] im GameObject CheckAdditionBtn bei der Komponente Button bei OnClick das Script anhängen
- [x] Value 1 und 2 im Script in einer CheckAddition Methode addieren und in Variable result speichern
- [x] neue public string Variable txtResult deklarieren, GameObject referenzieren
- [x] Ergebnis von result in string konvertieren und in txtResult.txt speichern


### Limitationen:
Es war etwas schwierig, den int Wert von der Result Variable in einen string Wert zu konvertieren. Nach etwas googlen hab ich es aber geschafft.

### Lessons Learned:
- [x] Wie addiere ich im Script
- [x] Reset mit Btn Press
- [x] Abfrage ob Input richtig ist
- [x] Verwendung Btns
- [x] FeedBack UI Elements
- [x] InputFields aus Script ändern
- [x] Zugriff auf Kind Objekte
- [x] Interaktivität En/Disable

Copyright by CKloesch :)
