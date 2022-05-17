# MyCaffee

## [SRB] Projekat Iz Predmeta Softversko Inženjerstvo<br/>[ENG] Project in Software Engineering University Course

### [SRB] Opis
MyCaffee je aplikacija koja je razvijena kao projekat za predmet Softversko inženjerstvo. Aplikacija omogućava lakše praćenje narudžbina u kafiću ili u nekom drugom ugostiteljskom lokalu. MyCaffee aplikacija omogućava kreiranje vlasničkog naloga, kao i naloga koji koriste konobari. Kada se aplikacija prvi put pokrene, korisnik će videti prazan prostor koji predstavlja prostor u lokalu. Na ovaj prostor je moguće dodati stolove u onom rasporedu koji odgovara stvarnom rasporedu stolova u lokalu. Stolove je takođe moguće pomerati i uklanjati. Klikom na sto se otvara meni u kome je moguće dodati poručene artikle u odgovarajućoj količini. Pre toga je samo potrebno uneti artikle u ponudu tj. meni u podešavanjima kako bi se mogli dodavati u porudžbinu. Ukupna cena se automatski računa posle svakog unosa. Posle naplate, poružbine za sto se uklanjaju, a podaci o njima se čuvaju u dnevnom izveštaju koji je vidljiv samo korisniku sa vlasničkim nalogom.

Aplikacija je rađena u .NET framework-u i C# programskom jeziku i u pozadini koristi SQL bazu podataka. Struktura je troslojna što znači da poseduje prezentacijski, biznis sloj i sloj podataka. Od dodataka su korišćeni _Control Draggable_ koji omogućava pomeranje UI elemenata i _SautinSoft Document_ koji omogućava kreiranje PDF izveštaja.

[NAPOMENA]
Kako bi aplikacija ispravno radila, potrebno je koristiti MM/DD/YYYY format datuma na sistemu (američki format).

### [ENG] Description
MyCaffee is an app developed as a project for our Software Engineering university course. The app makes it easier to track orders in a cafe or restaurant. MyCaffee app allows you to create owner account and accounts for waiters. When the application is launched for the first time, the user will be presented with an empty space that represents the cafe floor. Users can add tables to this space in the arrangement that corresponds to the actual arrangement of tables in the cafe. Placed tables can be moved around the floor and removed if they're not needed. Clicking on the table opens a menu where items can be added to the bill from a specific table. But, before that, you need to add items/products to the menu in settings. The total price is automatically calculated after each entry. After checkout, orders from the table are removed, and data on them are stored in a daily report that is visible only to the user with the owner account.

Application is developed in .NET framework and C# language and uses SQL database. App has three layers: presentation layer, business layer and data layer. Plugins used are _Control Draggable_ which adds drag and drop behavior to UI elements and _SautinSoft Document_ which allows you to create PDF reports.

[NOTE] 
For the application to work properly, it is necessary to use the MM/DD/YYYY date format on the system (US format).