***************************************************************
README v1.0 / DECEMBAR 2018.
***************************************************************

# Projekat škola

## Uvod (Introduction)

Projekat škola predstavlja veb aplikaciju uz pomoæ koje korisnici mogu, u zavisnosti od nivoa pristupa, izvršavati neke osnovne komande (unos, izmena, brisanje, štampanje..) nad formom koja sadrži informacije o školama i njenim kontaktima.

https://imgur.com/uNd8DS3

PRE NEGO ŠTO POÈNETE, NEOPHODNO JE DA PROÈITATE UPUTSTVA!!!




## Uputstva (Guide instructions)

*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***
*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***

1. Preuzmite repozitorijum pod nazivom "PROJEKAT" na GitHub-u.

2. Nakon što preuzmete repozitorijum "PROJEKAT", neophodno je da iz foldera "Baza podataka", oba fajla (BazaProjekat.mdf i BazaProjekat_log.ldf) prebacite/kopirate u Vaš DATA folder MS SQL Servera,a on se obièno nalazi u: C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA

3. Nakon što ste to uradili, pokrenite MS SQL Server
 - Desni klik na DATABASES u padajuæem meniju ispod imena Vaše baze u "Object Exploreru" i kliknite na "ATTACH"
 - Nakon toga Vam se otvori prozor "Attach databases" i u njemu "Databases to Attach" kliknite na dugme za dodavanje  --- > "Add" <---
 - Trebalo bi da Vam se otvori po default-u DATA folder gde ste prebacili neophodne fajlove (BazaProjekat.mdf i BazaProjekat_log.ldf), a ako se kojim sluèajem nije otvorio, pronaðite ga sami na : C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA
 - OBELEŽITE FAJL BazaProjekat.mdf i kliknite "Ok".

4. Uspešno ste ubacili bazu neophodnu za ovaj projekat, ostalo je još samo da u samom projektu u Microsoft Visual Studiu, postavite vaše ime baze, a to æete uraditi na sledeæi naèin.

5. Pokrenite fajl/solution "ProjekatFinalni.sln"

6. Nakon što Vam se otvori, na DNU prozora "Solution Explorer", stajaæe fajl Web.config, otvorite ga.

7. Izmedju <connectionStrings></connectionStrings>, treba da pronaðete "data source = DUKA" i umesto imena naše baze "DUKA", postavite ime Vaše Baze (Videti u MS SQL Serveru u "Object Exploreru"). Ponovite to svuda gde piše "data source = DUKA". 

**PrtScr** https://imgur.com/a/DMibANp 

8. Nakon što ste završili sve navedene stavke, pokušajte da pokrenete aplikaciju CTRL + F5.

9. U sluèaju da aplikacija radi normalno, nastavite sa èitanjem "Naèina korišæenja". Ukoliko ne radi, proèitajte "Pomoæ".

*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***
*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***



## Naèin korišæenja (Usage instructions)

1. Pokretanje aplikacije

- Nakon što ste pokrenuli aplikaciju, pojaviæe vam se poèetna stranica koja daje kratak opis o veb aplikaciji, nastavite dalje klikom na dugme "Zapoèni>>", naredna stvar koja æe se pokrenuti je stranica za prijavu, ukoliko se veæ niste registrovali, morate to uèiniti klikom na link "Registracija".

2. Registracija

- Jedan od važnijih koraka pri korišæenju aplikacije je "Registracija". U prostor namenjen za unos podataka, unesite "Korisnièko ime", kratko ime koje æete koristiti kada se budete prijavljivali. Sledeæa stavka je "Lozinka", pažljivo odaberite Vašu lozinku, savetujemo Vam da sadrži minimum 8 cifara, koristite mešavinu velikih i malih slova kao i brojeva. Sledi odabir vrste naloga koji želite da koristite u skladu sa tim kakav stepen pristupa želite:

** Admin ** Poseduje maksimalan pristup podacima, i sa njim æete moæi da imate totalnu kontrolu nad podacima veb aplikacije, kako nad informacijama o školama, tako i nad registrovanim korisnicima.

** Gost ** Ima moguænost pregleda škola i informacijama o njima, kao i opciju za štampanje potrebnih informacija, ostale moguænosti su za njega zakljuèane.

** Pravo za unos "" Ova vrsta naloga Vam omoguæava, izmenu informacija o postojeæim školama, kao i moguænost kreiranja nove i naravno moguænost štampanja stranice.

Da bi se uspešno registrovali, kliknite na "Kreiraj".

3. Prijava

- Nakon što ste se registrovali, neophodno je da se prijavite. Unesite korisnièko ime koje ste izabrali kao i lozinku za validaciju i kliknite "Prijavi se".

4. Lista škola

- Ako je prijava bila uspešna, pojaviæe se Vaše korisnièko ime u gornjem desnom æošku,a prva stranica koja æe nakon prijave biti pokrenuta je "Lista škola". Na kojoj se nalaze nazivi škola i informacije o njima, naravno ukoliko postoji neka škola uneta u bazu podataka. Ukoliko ste napravili nalog sa nivoom pristupa "Admin" ili "Pravo za unos" imaæete moguænost dodavanja nove škole, a "Admin" takoðe može da menja informacije o veæ postojeæim školama kao i da ih briše. 

5. Napravi novu školu

- Prilikom dodavanja nove škole, morate popuniti obrazac za kreiranje nove škole. Neophodno je uneti sve bitne podatke, ukoliko to ne uèinite, pojaviæe se poruka koja Vam nalaže da to uèinite.

6. Izmeni - Obriši

** Izmeni ** Možete menjati informacije o unetim školama klikom na dugme "Izmeni", nakon toga možete izmeniti željene podatke i saèuvati ih na dugme "Saèuvaj". 

** Obriši ** Takoðe možete i obrisati unete škole, klikom na dugme "Obriši".


7. Informacije o kontaktima

- Sada kada ste dodali novu školu, dodatnim informacijama o kontaktima možete pristupiti klikom na naziv željene škole. Pojaviæe Vam se nova stranica o informacijama u vezi kontakata (zaposlenih) u toj školi, klikom na "Email" i "Telefoni" u sklopu kontakta, možete pristupiti sadržaju. 

8. Komandna linija

- Tokom rada aplikacije, nebitno na kojoj stranici se nalazite, iznad æe stajati komandna linija tirkizne boje, pomoæu koje æete lako moæi da se kreæete kroz aplikaciju, tu se pored preèice za Listu škola i Vašeg korisnièkog imena, nalazi i preèica za odjavu sa aplikacije. Korisnik sa nivoom pristupa "Admin" æe još imati preèicu "Korisnici" uz pomoæ koje æe moæi da pristupi registrovanim korisnicima aplikacije.

9. Korisnici

- Kao admin, možete da manipulišete veæ postojeæim korisnicima, da menjate njihova prava pristupa, da im resetujete lozinku ili da ih u potpunosti obrišete. Takoðe, možete da kreirate i novog korisnika i da mu po Vašoj volji dodelite šifru i prava pristupa.

** Promeni prava korisnika ** Klikom na link, promeni prava korisnika, otvara Vam se stranica na kojoj æete moæi da promenite pravo pristupa za željenog korisnika, a klikom na dugme "Promeni" da izvršite promenu.

** Obriši korisnika ** Pojaviæe Vam se nova stranica koja æe Vas upitati da li ste sigurni da zaista želite da obrišete odabranog korisnika, a klikom na dugme, "Obriši" to potvrðujete.

** Resetuj lozinku korisinika ** Ovde možete resetovati lozinku bilo kog korisnika, unesite dva puta željenu lozinku, drugi put kako bi je potvrdili, a klikom na dugme "Resetuj", lozinka æe biti resetovana.


### Pomoæ (Help)


- Polazimo od pretpostavke da koristite Microsoft Visual Studio 2017 i imate instalirane sve neophodne dodatke za ASP.NET.

*******Uèestali problemi*******

[1]
Da biste koristili aplikaciju nesmetano, neophodno je da su Vam NuGet Packages(paketi) ažurirani. Ukoliko nisu, desnim klikom na ime projekta u "Solution explorer/ProjekatFinalni" kliknite na "Manage NuGet packages" u otvorenom prozoru kliknite na dugme "Browse" i prekopirajte ovaj tekst "Microsoft.CodeDom.Providers.DotNetCompilerPlatform". Skinite ekstenziju koja Vam se pojavila i instalirajte je. Ponovo pokrenite projekat za svaki sluèaj.

[2]
Could not find a part of the path '...\bin\roslyn\csc.exe'.

U sluèaju ovog problema, neophodno je da pronadjete fajl sa ektenzijom .csproj i da u njega prekopirate kod ispod.

<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>



- U sluèaju drugih problema kontaktirajte nas mejlom na:
dusan59517@its.edu.rs 


### Neophodne aplikacije (Requirements)

1. Microsoft Visual Studio 2017

2. Microsoft SQL Server


### Projektanti (Project Contributors - Credits)

1. Marina Jevremoviæ - RM
2. Nikola Jevremoviæ - IT
3. Dušan Jovièiæ - IT
4. Aleksandar Vukoviæ - IT
5. Luka Brdar - IT

### Kontakt (Contact)

E-mail: dusan59517@its.edu.rs


------------------------------------------------------------------------------------

Prosleðene informacije su namenjene iskljuèivo osobama ili entitetima na koje je poruka adresirana. Bilo kakvo širenje informacija, njihovo kopiranje i parafraziranje ili bilo koja druga upotreba ili preduzimanje akcije od strane lica ili entiteta na koje poruka nije adresirana, a vezano za informacije iz poruke i bez izrièite dozvole pošiljaoca se zabranjuje. Pošiljalac nije odgovoran ni za kakav prenos komunikacija, niti za kašnjenje poruke. 

The information transmitted is intended only for the person or entity to which it is addressed. Any review, retransmission, dissemination or other use of, or taking of any action in reliance upon this information by persons or entities other than the intended recipient - without the sender's explicit permission - is prohibited. The sender is neither liable for the proper transmission of this communication nor for any delay in its receipt.




 







